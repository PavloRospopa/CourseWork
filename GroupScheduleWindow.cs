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
    public partial class GroupScheduleWindow : Form
    {
        Group Group { get; set; }
        public GroupScheduleWindow()
        {
            InitializeComponent();
        }
        public GroupScheduleWindow(Group group)
        {
            InitializeComponent();
            this.Group = group;
            this.label1.Text = String.Format("Список тренувань групи {0}:", Group);
            DisplayWorkoutsOfGroupOnDataGridView();
        }
        void DisplayWorkoutsOfGroupOnDataGridView()
        {
            List<Workout> workouts = Workout.Items.Values.ToList();

            var query =
                from workout in workouts
                where workout.Group == this.Group
                select workout;
            //запит, який знаходить всі тренування групи Group

            List<Workout> workoutsOfGroup = query.ToList();
            this.dataGridView.DataSource = workoutsOfGroup;

            this.dataGridView.Columns[0].HeaderCell.Value = "Група";
            this.dataGridView.Columns[1].HeaderCell.Value = "Дата та час тренування";
            this.dataGridView.Columns[2].HeaderCell.Value = "Тривалість тренування";
            this.dataGridView.Columns[3].HeaderCell.Value = "Тренер";
            this.dataGridView.Columns[4].HeaderCell.Value = "Опис тренування";

            this.dataGridView.Columns[4].DisplayIndex = 4;

            if (this.dataGridView.Rows.Count == 0) this.cancelWorkoutButton.Enabled = false;
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelWorkoutButton_Click(object sender, EventArgs e)
        {
            Workout workout = null;
            try
            {
                workout = (Workout)this.dataGridView.CurrentRow.DataBoundItem;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ви намагаєтесь відмінити тренування групи, яка не має назначених тренувань.",
                    "Помилка скасування тренування", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string message = "Ви впевнені, що хочете відмінити вибране тренування?";
            string caption = "Скасування тренування";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                workout.Cancel();
                DisplayWorkoutsOfGroupOnDataGridView();
            }
        }

        private void addWorkoutButton_Click(object sender, EventArgs e)
        {
            using (AddNewWorkoutWindow addNewWorkoutWindow = new AddNewWorkoutWindow(this.Group))
            {
                addNewWorkoutWindow.ShowDialog();
            }
            DisplayWorkoutsOfGroupOnDataGridView();
        }

        private void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.cancelWorkoutButton.Enabled = true;
        }
    }
}
