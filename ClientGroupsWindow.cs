using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GymLife
{
    public partial class ClientGroupsWindow : Form
    {
        Client Client { get; set; }
        public ClientGroupsWindow()
        {
            InitializeComponent();
        }
        public ClientGroupsWindow(Client client)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;

            Client = client;

            this.label1.Text = String.Format("Список груп, в які входить {0}:", Client);
            DisplayGroupsOfClientOnDataGridView();
        }
        private void leaveGroupButton_Click(object sender, EventArgs e)
        {
           Group group = null;
            try
            {
                GroupViewModel groupViewModel = (GroupViewModel) this.dataGridView.CurrentRow.DataBoundItem;
                group = groupViewModel.GetModel();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ви намагаєтесь виключити клієнта з групи, проте не обрали жодної з каталогу груп клієнта.",
                    "Помилка виключення клієнта з групи", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string message = "Ви впевнені, що хочете виключити клієнта з вибраної групи?";
            string caption = "Виключення клієнта з групи";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                List<Client_Group> allClient_Groups = Client_Group.Items.Values.ToList();
                Client_Group client_groupToDelete = allClient_Groups.Find(
            delegate (Client_Group cl_gr)
            {
                return cl_gr.Group == group && cl_gr.Client == this.Client;
            }
            );
                client_groupToDelete.ExcludeGroupMember();
                DisplayGroupsOfClientOnDataGridView();
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void DisplayGroupsOfClientOnDataGridView()
        {
            List<Client_Group> client_groups = Client_Group.Items.Values.ToList();
            List<Client> clients = Client.Items.Values.ToList();

            var innerJoinQuery =
            from client in clients
            join client_group in client_groups on client equals client_group.Client
            where client == this.Client
            select client_group.Group;
            //запит, який знаходить всі групи, в яких учасником є клієнт Client

            List<Group> clientGroups = innerJoinQuery.ToList();

            this.dataGridView.DataSource = clientGroups.Select(o => new GroupViewModel(o)
            {
               Name = o.Name, Specialization = o.Specialization, Trainer = o.Trainer                
            }).ToList();

            this.dataGridView.Columns["Name"].HeaderCell.Value = "Назва групи";
            this.dataGridView.Columns["Specialization"].HeaderCell.Value = "Тип групи";
            this.dataGridView.Columns["Trainer"].HeaderCell.Value = "Тренер групи";

            if (this.dataGridView.Rows.Count == 0) this.leaveGroupButton.Enabled = false;
        }

        private void ClientGroupsWindow_Load(object sender, EventArgs e)
        {   
            if (this.dataGridView.Rows.Count == 0)
            {
                string message = String.Format("{0} не входить в жодну групу.", Client);
                string caption = "Клієнт без групи";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                this.WindowState = FormWindowState.Normal;               
            }
        }
    }
}
