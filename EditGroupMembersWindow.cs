using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymLife
{
    public partial class EditGroupMembersWindow : Form
    {
        Group Group { get; set; }
        public EditGroupMembersWindow()
        {
            InitializeComponent();
        }
        public EditGroupMembersWindow(Group group)
        {
            InitializeComponent();
            Group = group;
            this.label1.Text = String.Format("Список членів групи {0}:", Group);
            DisplayMembersOfGroupOnDataGridView();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            //тест. каша. перевірити/ upd: fixed
            Client newMember = null;
            using (AddGroupMemberWindow addGroupMemberWindow = new AddGroupMemberWindow(Group))
            {
                addGroupMemberWindow.ShowDialog();
                newMember = addGroupMemberWindow.Client;
            }
            if (newMember != null) { 
                new Client_Group(newMember, Group);
                DisplayMembersOfGroupOnDataGridView();
            }
        }

        private void deleteMemberButton_Click(object sender, EventArgs e)
        {
            Client client = null;
            try
            {
                client = (Client)this.dataGridView.CurrentRow.DataBoundItem;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ви намагаєтесь виключити клієнта з групи, в якій немає жодного учасника.",
                    "Помилка видалення члена групи", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            string message = "Ви впевнені, що хочете виключити вибраного клієнта з групи?";
            string caption = "Виключення члена групи";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                List<Client_Group> allClient_Groups = Client_Group.Items.Values.ToList();
                Client_Group client_groupToDelete = allClient_Groups.Find(
            delegate (Client_Group cl_gr)
            {
                return cl_gr.Group == this.Group && cl_gr.Client == client;
            }
            );
                client_groupToDelete.ExcludeGroupMember();
                DisplayMembersOfGroupOnDataGridView();
            }
        }

        void DisplayMembersOfGroupOnDataGridView()
        {
            List<Client_Group> client_groups = Client_Group.Items.Values.ToList();
            List<Group> groups = Group.Items.Values.ToList();

            var innerJoinQuery =
            from _group in groups
            join client_group in client_groups on _group equals client_group.Group
            where _group == this.Group
            select client_group.Client;
            //запит, який знаходить всіх клієнтів, які входять в групу Group

            List<Client> membersOfGroup = innerJoinQuery.ToList();
            this.dataGridView.DataSource = membersOfGroup;

            this.dataGridView.Columns[0].HeaderCell.Value = "Ім'я клієнта";
            this.dataGridView.Columns[1].HeaderCell.Value = "Прізвище клієнта";
            this.dataGridView.Columns[2].HeaderCell.Value = "Дата народження";
            this.dataGridView.Columns[3].HeaderCell.Value = "Вік";
            this.dataGridView.Columns[4].HeaderCell.Value = "Адреса проживання";
            this.dataGridView.Columns[5].HeaderCell.Value = "Номер телефону";

            if (this.dataGridView.Rows.Count == 0) this.deleteMemberButton.Enabled = false;
        }

        private void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.deleteMemberButton.Enabled = true;
        }
    }
}
