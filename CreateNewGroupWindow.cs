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
    public partial class CreateNewGroupWindow : Form
    {
        Trainer Trainer { get; set; }
        public CreateNewGroupWindow()
        {
            InitializeComponent();

            Spec[] specDataSource = { Spec.Fitness, Spec.StepAerobic, Spec.Boxing };
            this.specializationComboBox.DataSource = specDataSource;
            this.specializationComboBox.SelectedIndex = 0;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Spec specialization = (Spec)this.specializationComboBox.SelectedItem;
            DateTime dateOfCreation = this.dateTimePicker.Value.Date;
            string groupName = this.groupNameTextBox.Text;
            Trainer trainer = this.Trainer;

            if (!CheckGroupByName(groupName))
            {
                string mes = String.Format("Група з іменем \"{0}\" вже існує. Введіть іншу назву групи.", groupName);
                string cap = "Назва групи зайнята";
                MessageBox.Show(mes, cap, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            Group newGroup = new Group(specialization, trainer, dateOfCreation, groupName);

            string message = String.Format("Група \"{0}\" створена успішно", newGroup.Name);
            string caption = "Створення групи";
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.groupNameTextBox.Clear();
            this.trainerTextBox.Clear();
            Trainer = null;
        }
        bool CheckGroupByName(string groupName)
        {
            List<Group> allGroups = Group.Items.Values.ToList();
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
            Spec groupSpec = (Spec) this.specializationComboBox.SelectedItem;
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
    }
}
