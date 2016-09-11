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
    public partial class EditSubscriptionDataWindow : Form
    {
        Client Client { get; set; }
        Subscription Subscription { get; set; }
        public EditSubscriptionDataWindow()
        {
            InitializeComponent();
        }

        public EditSubscriptionDataWindow(Subscription subscription)
        {
            InitializeComponent();

            this.Subscription = subscription;

            Spec[] specDataSource = { Subscription.Specialization };
            this.specializationComboBox.DataSource = specDataSource;
            this.specializationComboBox.SelectedIndex = 0;

            int[] validityDataSource = { Subscription.Validity.Days };
            this.validityComboBox.DataSource = validityDataSource;
            this.validityComboBox.SelectedIndex = 0;

            this.dateTimePicker.Value = Subscription.ActivationDate;

            int startingPrice = Subscription.Price;
            this.priceTextBox.Text = startingPrice.ToString("c");

            if (Subscription.Owner != null)
            this.ownerTextBox.Text = Subscription.Owner.ToString();


        }

        private void chooseOwnerButton_Click(object sender, EventArgs e)
        {
            using (ChooseOwnerWindow chooseOwnerWindow = new ChooseOwnerWindow())
            {
                chooseOwnerWindow.ShowDialog();

                this.Client = chooseOwnerWindow.Client;
                if (this.Client != null)
                {
                    this.ownerTextBox.Text = this.Client.FirstName + " " + this.Client.LastName;
                }
                else
                    this.ownerTextBox.Clear();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DateTime activationDate = this.dateTimePicker.Value.Date;
            Client client = Client;

            Subscription.ActivationDate = activationDate;
            Subscription.Owner = client;

            MessageBox.Show("Дані абонемента змінені успішно. Всі зміни збережено.", "Редагування даних абонемента", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
