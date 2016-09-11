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
    public partial class ChooseTrainerWindow : Form
    {
        public Trainer Trainer { get; private set; }

        public Spec GroupSpecialization { get; set; }
        public ChooseTrainerWindow()
        {
            InitializeComponent();  
        }
        public ChooseTrainerWindow(Spec groupSpec)
        {
            this.GroupSpecialization = groupSpec;
            InitializeComponent();

            DisplayTrainers();
        }
        void DisplayTrainers()
        {
            List<Trainer> trainers = Trainer.Items.Values.ToList();
            this.dataGridView.DataSource = trainers.Select(o => new TrainerViewModel(o)
            {
                FirstName = o.FirstName,
                LastName = o.LastName,
                Specialization = o.Specialization,
                WorkExperience = o.WorkExperience
            })
                .Where(o => o.Specialization == this.GroupSpecialization).ToList();

            this.dataGridView.Columns[0].HeaderCell.Value = "Ім'я тренера";
            this.dataGridView.Columns[1].HeaderCell.Value = "Прізвище тренера";
            this.dataGridView.Columns[2].HeaderCell.Value = "Спеціалізація";
            this.dataGridView.Columns[3].HeaderCell.Value = "Досвід роботи";
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                TrainerViewModel trainerViewModel = (TrainerViewModel)this.dataGridView.CurrentRow.DataBoundItem;
                this.Trainer = trainerViewModel.GetModel();
            }
            catch (Exception exception)
            {
            }
            this.Close();
        }
    }
}
