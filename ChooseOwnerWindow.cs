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
    public partial class ChooseOwnerWindow : Form
    {
        public Client Client { get; set; }
        public ChooseOwnerWindow()
        {
            InitializeComponent();

            this.dataGridView.DataSource = Client.Items.Values.ToList();


            this.dataGridView.Columns[0].HeaderCell.Value = "Ім'я клієнта";
            this.dataGridView.Columns[1].HeaderCell.Value = "Прізвище клієнта";
            this.dataGridView.Columns[2].HeaderCell.Value = "Дата народження";
            this.dataGridView.Columns[3].HeaderCell.Value = "Вік";
            this.dataGridView.Columns[4].HeaderCell.Value = "Адреса проживання";
            this.dataGridView.Columns[5].HeaderCell.Value = "Номер телефону";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Client = (Client)this.dataGridView.CurrentRow.DataBoundItem;      
            }
            catch(Exception exception)
            {            
            }
            this.Close();
        }
    }
}
