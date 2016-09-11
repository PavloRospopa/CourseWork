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
    public partial class AddNewClientWindow : Form
    {
        public AddNewClientWindow()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string firstName = this.firstNameTextBox.Text;
            string lastName = this.lastNameTextBox.Text;
            DateTime dateOfBirth = this.dateTimePicker.Value.Date;


            if (firstName == string.Empty || lastName==string.Empty)
            {
                MessageBox.Show("Заповніть обов'язкові поля",
                        "Обов'язкові поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            string address = (this.addressTextBox.Text==string.Empty) ? "unknown" : this.addressTextBox.Text;

            string phoneNumber = (this.phoneNumberTextBox.Text == string.Empty) ? "unknown" : this.phoneNumberTextBox.Text;

            if (phoneNumber != "unknown") {
                Regex phoneNumpattern = new Regex(@"\+[0-9]{3}\s+[0-9]{2}\s+[0-9]{3}\s+[0-9]{4}");

                if (!phoneNumpattern.IsMatch(phoneNumber))
                {
                    MessageBox.Show("Формат номеру телефону неправильний.\nПриклад дійсного номеру: +380 96 315 4473",
                        "Неправильний формат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }         
            }

            new Client(firstName, lastName, dateOfBirth, address, phoneNumber);
            MessageBox.Show("Клієнт доданий успішно.","Додавання клієнта", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.firstNameTextBox.Clear();
            this.lastNameTextBox.Clear();
            this.addressTextBox.Clear();
            this.phoneNumberTextBox.Clear();
        }
    }
}
