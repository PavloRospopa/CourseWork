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
    public partial class AddNewSubscriptionWindow : Form
    {
        Client Client { get; set; }
        public AddNewSubscriptionWindow()
        {
            InitializeComponent();

            Spec [] specDataSource = { Spec.Fitness, Spec.StepAerobic, Spec.Boxing };
            this.specializationComboBox.DataSource = specDataSource;
            this.specializationComboBox.SelectedIndex = 0;

            int[] validityDataSource = { 30, 90, 180, 365 };                                   
            this.validityComboBox.DataSource = validityDataSource;
            this.validityComboBox.SelectedIndex = 3;

            int startingPrice = 5000;
            this.priceTextBox.Text = startingPrice.ToString("c");

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Spec specialization = (Spec) this.specializationComboBox.SelectedItem;
            DateTime activationDate = this.dateTimePicker.Value.Date;
            TimeSpan validity = new TimeSpan((int)this.validityComboBox.SelectedItem, 0, 0, 0);
            Client client = Client;

            new Subscription(specialization, validity, client, activationDate);
            MessageBox.Show("Абонемент доданий до системи успішно.", "Створення абонемента", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.ownerTextBox.Clear();
            Client = null;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void validityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.validityComboBox.SelectedIndex ==3)
            {
                int price = 5000;
                this.priceTextBox.Text = price.ToString("c");
            }
            else if (this.validityComboBox.SelectedIndex == 2)
            {
                int price = 3000;
                this.priceTextBox.Text = price.ToString("c");
            }
            else if (this.validityComboBox.SelectedIndex == 1)
            {
                int price = 2000;
                this.priceTextBox.Text = price.ToString("c");
            }
            else if (this.validityComboBox.SelectedIndex == 0)
            {
                int price = 750;
                this.priceTextBox.Text = price.ToString("c");
            }
        }
    }
}
