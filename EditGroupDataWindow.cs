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
    public partial class EditGroupDataWindow : Form
    {
        Group Group { get; set; }
        Trainer Trainer { get; set; }

        public EditGroupDataWindow()
        {
            InitializeComponent();
        }
        public EditGroupDataWindow(Group group)
        {
            InitializeComponent();
            Group = group;

            Spec[] specDataSource = { Group.Specialization };
            this.specializationComboBox.DataSource = specDataSource;
            this.specializationComboBox.SelectedIndex = 0;

            this.dateTimePicker.Value = this.Group.DateOfCreation;

            this.groupNameTextBox.Text = Group.Name;
            if (Group.Trainer!= null)
            {
                this.trainerTextBox.Text = Group.Trainer.ToString();
            }

        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            string groupName = this.groupNameTextBox.Text;

            if (!CheckGroupByName(groupName))
            {
                string mes = String.Format("Група з іменем \"{0}\" вже існує. Введіть іншу назву групи.", groupName);
                string cap = "Назва групи зайнята";
                MessageBox.Show(mes, cap, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Trainer trainer = this.Trainer;

            Group.Name = groupName;
            Group.Trainer = trainer;

            string message = String.Format("Дані групи \"{0}\" змінені успішно. Всі зміни збережено.", Group.Name);
            string caption = "Редагування даних групи";
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        bool CheckGroupByName(string groupName)
        {
            List<Group> allGroups = Group.Items.Values.ToList();
            allGroups.Remove(this.Group);
            Group group_checkup = allGroups.Find(
                delegate (Group gr)
                {
                    return gr.Name == groupName;
                });
            if (group_checkup == null)
                return true;
            else return false;
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chooseTrainerButton_Click(object sender, EventArgs e)
        {
            Spec groupSpec = (Spec)this.specializationComboBox.SelectedItem;
            using (ChooseTrainerWindow chooseTrainerWindow = new ChooseTrainerWindow(groupSpec))
            {
                chooseTrainerWindow.ShowDialog();

                this.Trainer = chooseTrainerWindow.Trainer;
                if (this.Trainer != null)
                {
                    this.trainerTextBox.Text = this.Trainer.FirstName + " " + this.Trainer.LastName;
                }
                else
                    this.trainerTextBox.Clear();
            }
        }

        private void editGroupMembersButton_Click(object sender, EventArgs e)
        {
            using (EditGroupMembersWindow editGroupMembersWindow = new EditGroupMembersWindow(this.Group))
            {
                editGroupMembersWindow.ShowDialog();
            }
        }
    }
}
