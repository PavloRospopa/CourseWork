using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymLife
{
    [Serializable]
    public class Client_Group: Base<Client_Group>
    {
        private Guid groupId;
        private Guid clientId;

        public Group Group
        {
            get { return Group.Items[groupId]; }
            set { groupId = value.Id; }
        }
        public Client Client
        {
            get { return Client.Items[clientId]; }
            set { clientId = value.Id; }
        }

        public Client_Group(Client client, Group group)
        {
            Client = client;
            Group = group;
        }
        public void ExcludeGroupMember()
        {
            Items.Remove(this.Id);
        }
    }
}
