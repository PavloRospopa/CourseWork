using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymLife
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Data savedData = BinarySerialization.ReadFromBinaryFile<Data>("data.bin");
            Client.Items = savedData.ClientDictionary;
            Trainer.Items = savedData.TrainerDictionary;
            Group.Items = savedData.GroupDictionary;
            Client_Group.Items = savedData.Client_GroupDictionary;
            Workout.Items = savedData.WorkoutDictionary;
            Subscription.Items = savedData.SubscriptionDictionary;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());

            Data data = new Data()
            {
                ClientDictionary = Client.Items,
                TrainerDictionary = Trainer.Items,
                GroupDictionary = Group.Items,
                Client_GroupDictionary = Client_Group.Items,
                WorkoutDictionary = Workout.Items,
                SubscriptionDictionary = Subscription.Items
            };
            BinarySerialization.WriteToBinaryFile("data.bin", data);
        }
    }
}
