using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GymLife
{
    public partial class AddGroupMemberWindow : Form
    {
        public Client Client { get; private set; }
        public AddGroupMemberWindow()
        {
            InitializeComponent();
        }
        public AddGroupMemberWindow(Group group)
        {
            InitializeComponent();

            Spec groupSpec = group.Specialization;

            List<Subscription> subs = Subscription.Items.Values.ToList();
            List<Client> clients = Client.Items.Values.ToList();

            var innerJoinQuery =
            from client in clients
            join sub in subs on client equals sub.Owner
            where sub.Specialization == groupSpec && sub.ExpirationDate > DateTime.Now.Date
            select client;
            //відображення клієнтів за відповідними абонементами + немає дублікатів, якщо клієнт має 2 абонементи одного типу
            //upd: + враховується дата дійсності абонементів

            List<Client> myClients = innerJoinQuery.ToList();
            List<Client> myClientsWithoutDups = myClients.Distinct().ToList();

            List<Client_Group> listOfClient_Groups = Client_Group.Items.Values.ToList();

            foreach (Client_Group cl_gr in listOfClient_Groups)
            {
                if (myClientsWithoutDups.Contains(cl_gr.Client) && cl_gr.Group == group)
                    myClientsWithoutDups.Remove(cl_gr.Client);
            } 


            //альтернативний спосіб
            //List<Client> myClients = new List<Client>();
            //subs = subs.Where(s => s.Specialization == groupSpec && s.ExpirationDate > DateTime.Now.Date).ToList();
            //foreach (Subscription sub in subs)
            //{
            //    if (sub != null) myClients.Add(sub.Owner);
            //}
            //List<Client> myClientsWithoutDups = myClients.Distinct().ToList();


            this.dataGridView.DataSource = myClientsWithoutDups;

            this.dataGridView.Columns[0].HeaderCell.Value = "Ім'я клієнта";
            this.dataGridView.Columns[1].HeaderCell.Value = "Прізвище клієнта";
            this.dataGridView.Columns[2].HeaderCell.Value = "Дата народження";
            this.dataGridView.Columns[3].HeaderCell.Value = "Вік";
            this.dataGridView.Columns[4].HeaderCell.Value = "Адреса проживання";
            this.dataGridView.Columns[5].HeaderCell.Value = "Номер телефону";

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Client = (Client)this.dataGridView.CurrentRow.DataBoundItem;
            }
            catch (Exception exception)
            {
            }
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
