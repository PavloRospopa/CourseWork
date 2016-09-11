using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace GymLife
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("uk-UA");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("uk-UA");

            InitializeComponent();
        }

        private void проДодатокGymLifeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.ShowDialog();
        }

        void CorrectFormSize()
        {
            this.dataGridView.Width = dataGridView.Columns[0].Width * dataGridView.Columns.Count + 43;
            this.Width = this.dataGridView.Width + 16;
        }
        private void додатиНовогоКлієнтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AddNewClientWindow addClientWindow = new AddNewClientWindow())
            {
                addClientWindow.ShowDialog();
            }
        }

        private void списокКлієнтівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView.DataSource = Client.Items.Values.ToList();
      

            this.dataGridView.Columns[0].HeaderCell.Value = "Ім'я клієнта";
            this.dataGridView.Columns[1].HeaderCell.Value = "Прізвище клієнта";
            this.dataGridView.Columns[2].HeaderCell.Value = "Дата народження";
            this.dataGridView.Columns[3].HeaderCell.Value = "Вік";
            this.dataGridView.Columns[4].HeaderCell.Value = "Адреса проживання";
            this.dataGridView.Columns[5].HeaderCell.Value = "Номер телефону";

            this.dataGridView.Columns[0].DisplayIndex = 0;
            this.dataGridView.Columns[1].DisplayIndex = 1;
            this.dataGridView.Columns[2].DisplayIndex = 2;
            this.dataGridView.Columns[3].DisplayIndex = 3;
            this.dataGridView.Columns[4].DisplayIndex = 4;
            this.dataGridView.Columns[5].DisplayIndex = 5;

            CorrectFormSize();
        }

        private void редагуватиДаніПроКлієнтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = (Client)this.dataGridView.CurrentRow.DataBoundItem;

                EditClientDataWindow editClientWindow = new EditClientDataWindow(client);
                editClientWindow.ShowDialog();
            }
            catch(Exception exception)
            {
                MessageBox.Show("Ви намагаєтесь редагувати дані не клієнта, а об'єкту даних іншого типу.",
                    "Помилка вибору клієнта для редагування", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void додатиАбонементToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewSubscriptionWindow addSubscriptionWindow = new AddNewSubscriptionWindow();
            addSubscriptionWindow.ShowDialog();
        }

        private void списокАбонементівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView.DataSource = Subscription.Items.Values.ToList();

            this.dataGridView.Columns[0].HeaderCell.Value = "Власник абонементу";
            this.dataGridView.Columns[1].HeaderCell.Value = "Тип абонементу";
            this.dataGridView.Columns[2].HeaderCell.Value = "Вартість";
            this.dataGridView.Columns[2].DefaultCellStyle.Format = "c";

            this.dataGridView.Columns[3].HeaderCell.Value = "Термін дії";
            this.dataGridView.Columns[3].DefaultCellStyle.Format = "dd";

            this.dataGridView.Columns[4].HeaderCell.Value = "Дата активації";
            this.dataGridView.Columns[5].HeaderCell.Value = "Дата дійсності";

            this.dataGridView.Columns[0].DisplayIndex = 0;
            this.dataGridView.Columns[1].DisplayIndex = 1;
            this.dataGridView.Columns[2].DisplayIndex = 2;
            this.dataGridView.Columns[3].DisplayIndex = 3;
            this.dataGridView.Columns[4].DisplayIndex = 4;
            this.dataGridView.Columns[5].DisplayIndex = 5;

            CorrectFormSize();
        }

        private void редагуватиДаніАбонементуToolStripMenuItem_Click(object sender, EventArgs e)
        {   try
            {
                Subscription subscription = (Subscription)this.dataGridView.CurrentRow.DataBoundItem;

                EditSubscriptionDataWindow editSubscriptionWindow = new EditSubscriptionDataWindow(subscription);
                editSubscriptionWindow.ShowDialog();
            }
            catch(Exception exception)
            {
                MessageBox.Show("Ви намагаєтесь редагувати дані не абонемента, а об'єкту даних іншого типу.",
                    "Помилка вибору абонемента для редагування", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void додатиНовогоТренераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewTrainerWindow addTrainerWindow = new AddNewTrainerWindow();
            addTrainerWindow.ShowDialog();
        }

        private void списокТренерівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayTrainersOnDataGridView();
        }

        private void редагуватиДаніПроТренераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Trainer trainer = (Trainer)this.dataGridView.CurrentRow.DataBoundItem;

                EditTrainerDataWindow editTrainerWindow = new EditTrainerDataWindow(trainer);
                editTrainerWindow.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ви намагаєтесь редагувати дані не тренера, а об'єкту даних іншого типу.",
                    "Помилка вибору тренера для редагування", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void звільнитиТренераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trainer trainer = null;
            try
            {
                trainer = (Trainer)this.dataGridView.CurrentRow.DataBoundItem;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ви намагаєтесь обрати для звільнення не тренера, а об'єкт даних іншого типу.",
                    "Помилка звільнення тренера", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string message = "Ви впевнені, що хочете звільнити вибраного тренера?";
            string caption = "Звільнення тренера";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes)
            { 
                    trainer.Retire();
                    DisplayTrainersOnDataGridView();         
            }
        }
        void DisplayTrainersOnDataGridView()
        {
            this.dataGridView.DataSource = Trainer.Items.Values.ToList();

            this.dataGridView.Columns[0].HeaderCell.Value = "Ім'я тренера";
            this.dataGridView.Columns[1].HeaderCell.Value = "Прізвище тренера";
            this.dataGridView.Columns[2].HeaderCell.Value = "Дата народження";
            this.dataGridView.Columns[3].HeaderCell.Value = "Вік";
            this.dataGridView.Columns[4].HeaderCell.Value = "Адреса проживання";
            this.dataGridView.Columns[5].HeaderCell.Value = "Номер телефону";
            this.dataGridView.Columns[6].HeaderCell.Value = "Спеціалізація";
            this.dataGridView.Columns[7].HeaderCell.Value = "Досвід роботи";
            this.dataGridView.Columns[8].HeaderCell.Value = "Зарплата";
            this.dataGridView.Columns[8].DefaultCellStyle.Format = "c";

            this.dataGridView.Columns[0].DisplayIndex = 0;
            this.dataGridView.Columns[1].DisplayIndex = 1;
            this.dataGridView.Columns[2].DisplayIndex = 2;
            this.dataGridView.Columns[3].DisplayIndex = 3;
            this.dataGridView.Columns[4].DisplayIndex = 4;
            this.dataGridView.Columns[5].DisplayIndex = 5;
            this.dataGridView.Columns[6].DisplayIndex = 6;
            this.dataGridView.Columns[7].DisplayIndex = 7;
            this.dataGridView.Columns[8].DisplayIndex = 8;
            //this.dataGridView.Columns["Id"].DisplayIndex = dataGridView.Columns.Count - 1;

            CorrectFormSize();
        }

        private void створитиНовуГрупуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewGroupWindow createGroupWindow = new CreateNewGroupWindow();
            createGroupWindow.ShowDialog();
        }

        private void списокГрупToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView.DataSource = Group.Items.Values.ToList();

            this.dataGridView.Columns["Name"].DisplayIndex = 0;

            this.dataGridView.Columns["Specialization"].DisplayIndex = 1;
            this.dataGridView.Columns["DateOfCreation"].DisplayIndex = 2;
            this.dataGridView.Columns["Trainer"].DisplayIndex = 3;

            this.dataGridView.Columns["Name"].HeaderCell.Value = "Назва групи";
            this.dataGridView.Columns["Specialization"].HeaderCell.Value = "Тип групи";
            this.dataGridView.Columns["DateOfCreation"].HeaderCell.Value = "Дата створення";
            this.dataGridView.Columns["Trainer"].HeaderCell.Value = "Тренер групи";

            CorrectFormSize();
        }

        private void редагуватиДаніГрупиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Group group = (Group)this.dataGridView.CurrentRow.DataBoundItem;

                EditGroupDataWindow editGroupDataWindow = new EditGroupDataWindow(group);
                editGroupDataWindow.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ви намагаєтесь редагувати дані не групи, а об'єкту даних іншого типу.",
                    "Помилка вибору групи для редагування", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void складГрупиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Group group = (Group)this.dataGridView.CurrentRow.DataBoundItem;

                using (EditGroupMembersWindow editGroupMembersWindow = new EditGroupMembersWindow(group))
                {
                    editGroupMembersWindow.ShowDialog();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ви намагаєтесь відкрити редактор складу групи, проте обрали об'єкт даних іншого типу.",
                    "Помилка відкриття редактора складу групи", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void групиКлієнтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = (Client)this.dataGridView.CurrentRow.DataBoundItem;

                using (ClientGroupsWindow clientGroupsWindow = new ClientGroupsWindow(client))
                {
                    clientGroupsWindow.ShowDialog();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ви намагаєтесь відкрити вікно груп клієнта, проте обрали об'єкт даних іншого типу.",
                    "Помилка відкриття вікна груп клієнта", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void додатиНовеТренуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Group.Items.Values.ToList().Count > 0) { 
                using (AddNewWorkoutWindow addNewWorkoutWindow = new AddNewWorkoutWindow())
                {
                    addNewWorkoutWindow.ShowDialog();
                }
            }
            else
            {
                string message = "Створіть спочатку одну чи декілька груп" +
                  " для того, щоб назначити їм тренування.";
                string caption = "В системі немає груп";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void списокТренуваньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayWorkoutsOnDataGridView();
        }
        void DisplayWorkoutsOnDataGridView()
        {
            this.dataGridView.DataSource = Workout.Items.Values.ToList();

            this.dataGridView.Columns[0].HeaderCell.Value = "Група";
            this.dataGridView.Columns[1].HeaderCell.Value = "Дата та час тренування";
            this.dataGridView.Columns[2].HeaderCell.Value = "Тривалість тренування";
            this.dataGridView.Columns[3].HeaderCell.Value = "Тренер";
            this.dataGridView.Columns[4].HeaderCell.Value = "Опис тренування";

            this.dataGridView.Columns[0].DisplayIndex = 0;
            this.dataGridView.Columns[1].DisplayIndex = 1;
            this.dataGridView.Columns[2].DisplayIndex = 2;
            this.dataGridView.Columns[3].DisplayIndex = 3;
            this.dataGridView.Columns[4].DisplayIndex = 4;

            CorrectFormSize();
        }
        private void відмінитиТренуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Workout workout = null;
            try
            {
                workout = (Workout)this.dataGridView.CurrentRow.DataBoundItem;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ви намагаєтесь відмінити тренування, проте обрали об'єкт даних іншого типу.",
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
                DisplayWorkoutsOnDataGridView();
            }
        }

        private void розкладТренуваньГрупиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Group group = (Group)this.dataGridView.CurrentRow.DataBoundItem;

                using (GroupScheduleWindow groupScheduleWindow = new GroupScheduleWindow(group))
                {
                    groupScheduleWindow.ShowDialog();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ви намагаєтесь відкрити розклад тренувань групи, проте обрали об'єкт даних іншого типу.",
                    "Помилка відкриття розкладу групи", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void умовиВикористанняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (TermsOfUseWindow termsOfUseWindow = new TermsOfUseWindow())
            {
                termsOfUseWindow.ShowDialog();
            }
        }

        private void clientsButton_Click(object sender, EventArgs e)
        {
            списокКлієнтівToolStripMenuItem_Click(sender, e);
            clientsButton.Visible = false;
            subsButton.Visible = false;
            workoutsButton.Visible = false;
            groupsButton.Visible = false;
            trainersButton.Visible = false;
            quitButton.Visible = false;
        }

        private void subsButton_Click(object sender, EventArgs e)
        {
            списокАбонементівToolStripMenuItem_Click(sender, e);
            clientsButton.Visible = false;
            subsButton.Visible = false;
            workoutsButton.Visible = false;
            groupsButton.Visible = false;
            trainersButton.Visible = false;
            quitButton.Visible = false;
        }

        private void workoutsButton_Click(object sender, EventArgs e)
        {
            списокТренуваньToolStripMenuItem_Click(sender, e);
            clientsButton.Visible = false;
            subsButton.Visible = false;
            workoutsButton.Visible = false;
            groupsButton.Visible = false;
            trainersButton.Visible = false;
            quitButton.Visible = false;
        }

        private void groupsButton_Click(object sender, EventArgs e)
        {
            списокГрупToolStripMenuItem_Click(sender, e);
            clientsButton.Visible = false;
            subsButton.Visible = false;
            workoutsButton.Visible = false;
            groupsButton.Visible = false;
            trainersButton.Visible = false;
            quitButton.Visible = false;
        }

        private void trainersButton_Click(object sender, EventArgs e)
        {
            списокТренерівToolStripMenuItem_Click(sender, e);
            clientsButton.Visible = false;
            subsButton.Visible = false;
            workoutsButton.Visible = false;
            groupsButton.Visible = false;
            trainersButton.Visible = false;
            quitButton.Visible = false;
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
