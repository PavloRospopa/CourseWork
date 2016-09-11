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
    public partial class AddNewWorkoutWindow : Form
    {
        Group Group { get; set;}
        Trainer WorkoutTrainer { get; set; }
        public AddNewWorkoutWindow()
        {
            InitializeComponent();
            InitAllControls();

            this.groupsComboBox.DataSource = Group.Items.Values.ToList();
        }
        public AddNewWorkoutWindow(Group group)
        {          
            InitializeComponent();
            InitAllControls();

            this.Group = group;
            Group [] groupsDataSource = { group };
            this.groupsComboBox.DataSource = groupsDataSource;
            this.groupsComboBox.Enabled = false;

            if (Group.Trainer != null)
            {
                this.WorkoutTrainer = Group.Trainer;
                this.trainerTextBox.Text = this.WorkoutTrainer.ToString();
            }

        }
        void InitAllControls()
        {           
            timePortionDateTimePicker.Format = DateTimePickerFormat.Time;
            timePortionDateTimePicker.ShowUpDown = true;

            TimeSpan[] durations = { new TimeSpan(0, 45, 0),
                                     new TimeSpan(1, 0 , 0),
                                     new TimeSpan(1, 15 ,0),
                                     new TimeSpan(1, 30 , 0),
                                     new TimeSpan(2, 0, 0) };
            this.durationComboBox.DataSource = durations;
            this.durationComboBox.FormatString = @"hh\:mm";          
        }

        private void groupsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Group = (Group)this.groupsComboBox.SelectedItem;
            if (Group.Trainer != null)
            {
                this.WorkoutTrainer = Group.Trainer;
                this.trainerTextBox.Text = this.WorkoutTrainer.ToString();              
            }
            else
            {
                this.WorkoutTrainer = null;
                this.trainerTextBox.Clear();
            }
        }

        private void chooseTrainerButton_Click(object sender, EventArgs e)
        {
            using (ChooseTrainerWindow chooseTrainerWindow = new ChooseTrainerWindow(Group.Specialization))
            {
                chooseTrainerWindow.ShowDialog();
                if (chooseTrainerWindow.Trainer != null)
                {
                    this.WorkoutTrainer = chooseTrainerWindow.Trainer;
                    this.trainerTextBox.Text = this.WorkoutTrainer.ToString();
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Group group = Group;
            DateTime dateTime = datePortionDateTimePicker.Value.Date +
                    timePortionDateTimePicker.Value.TimeOfDay;
            TimeSpan duration = (TimeSpan) this.durationComboBox.SelectedItem;
            Trainer actualTrainer = this.WorkoutTrainer;
            string description = this.descriptionMultiTextBox.Text;

            new Workout(group, dateTime, duration, description, actualTrainer);
            MessageBox.Show("Тренування додане до системи успішно.", "Створення нового тренування", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
