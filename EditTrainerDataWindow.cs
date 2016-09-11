using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymLife
{
    public partial class EditTrainerDataWindow : Form
    {
        Trainer Trainer { get; set; }
        public EditTrainerDataWindow()
        {
            InitializeComponent();
        }

        public EditTrainerDataWindow(Trainer trainer)
        {
            InitializeComponent();
            this.Trainer = trainer;

            this.firstNameTextBox.Text = Trainer.FirstName;
            this.lastNameTextBox.Text = Trainer.LastName;
            this.dateTimePicker.Value = Trainer.DateOfBirth;

            Spec[] specDataSource = { Spec.Fitness, Spec.StepAerobic, Spec.Boxing };
            this.specializationComboBox.DataSource = specDataSource;
            this.specializationComboBox.SelectedItem = Trainer.Specialization;

            this.entryDateTimePicker.Value = Trainer.getEntryDate();

            int[] salaryDataSource = { 5000, 7500, 10000, 12500, 15000, 17500 };
            this.salaryComboBox.DataSource = salaryDataSource;
            this.salaryComboBox.SelectedItem = Trainer.Salary;
            this.salaryComboBox.FormatString = "c";

            this.addressTextBox.Text = Trainer.Address;
            this.phoneNumberTextBox.Text = Trainer.PhoneNumber;

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string firstName = this.firstNameTextBox.Text;
            string lastName = this.lastNameTextBox.Text;
            DateTime dateOfBirth = this.dateTimePicker.Value.Date;
            Spec specialization = (Spec)this.specializationComboBox.SelectedItem;
            DateTime entryDate = this.entryDateTimePicker.Value.Date;
            int salary = (int)this.salaryComboBox.SelectedItem;
            string address = this.addressTextBox.Text;
            string phoneNumber = this.phoneNumberTextBox.Text;

            if (firstName == string.Empty || lastName == string.Empty || address == string.Empty
                || phoneNumber == string.Empty)
            {
                MessageBox.Show("Заповніть обов'язкові поля",
                        "Обов'язкові поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Regex phoneNumpattern = new Regex(@"\+[0-9]{3}\s+[0-9]{2}\s+[0-9]{3}\s+[0-9]{4}");

            if (!phoneNumpattern.IsMatch(phoneNumber))
            {
                MessageBox.Show("Формат номеру телефону неправильний.\nПриклад дійсного номеру: +380 96 315 4473",
                    "Неправильний формат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Trainer.FirstName = firstName;
            Trainer.LastName = lastName;
            Trainer.DateOfBirth = dateOfBirth;
            Trainer.Specialization = specialization;
            Trainer.setEntryDate(entryDate);
            Trainer.Salary = salary;
            Trainer.Address = address;
            Trainer.PhoneNumber = phoneNumber;
            
            MessageBox.Show("Інформація про тренера змінена успішно. Всі зміни збережено.", "Редагування даних тренера", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
