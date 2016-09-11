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
    public partial class EditClientDataWindow : Form
    {
        public Client Client { get; private set; }
        public EditClientDataWindow()
        {
            InitializeComponent();
        }
        public EditClientDataWindow(Client client)
        {
            Client = client;
            InitializeComponent();

            this.firstNameTextBox.Text = Client.FirstName;
            this.lastNameTextBox.Text = Client.LastName;
            this.dateTimePicker.Value = Client.DateOfBirth;
            this.addressTextBox.Text = Client.Address;
            this.phoneNumberTextBox.Text = Client.PhoneNumber;
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


            if (firstName == string.Empty || lastName == string.Empty)
            {
                MessageBox.Show("Заповніть обов'язкові поля",
                        "Обов'язкові поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            string address = (this.addressTextBox.Text == string.Empty) ? "unknown" : this.addressTextBox.Text;

            string phoneNumber = (this.phoneNumberTextBox.Text == string.Empty) ? "unknown" : this.phoneNumberTextBox.Text;

            if (phoneNumber != "unknown")
            {
                Regex phoneNumpattern = new Regex(@"\+[0-9]{3}\s+[0-9]{2}\s+[0-9]{3}\s+[0-9]{4}");

                if (!phoneNumpattern.IsMatch(phoneNumber))
                {
                    MessageBox.Show("Формат номеру телефону неправильний.\nПриклад дійсного номеру: +380 96 315 4473",
                        "Неправильний формат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Client.FirstName = firstName;
            Client.LastName = lastName;
            Client.DateOfBirth = dateOfBirth;
            Client.Address = address;
            Client.PhoneNumber = phoneNumber;

            MessageBox.Show("Інформація про клієнта змінена успішно. Всі зміни збережено.", "Редагування даних клієнта", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
