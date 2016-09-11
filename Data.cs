using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymLife
{
    [Serializable]
    public class Data
    {
        public Dictionary<Guid, Client> ClientDictionary { get; set; }
        public Dictionary<Guid, Trainer> TrainerDictionary { get; set; }
        public Dictionary<Guid, Group> GroupDictionary { get; set; }
        public Dictionary<Guid, Client_Group> Client_GroupDictionary { get; set; }   
        public Dictionary<Guid, Workout> WorkoutDictionary { get; set; }
        public Dictionary<Guid, Subscription> SubscriptionDictionary { get; set; }
    }
}
