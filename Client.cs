using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymLife
{
    [Serializable]
    public class Client : Base<Client>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age
        {
            get
            {
                var age = DateTime.Now.Year - DateOfBirth.Year;
                return age;
            }
        }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public Client()
        {
            FirstName = "unknown";
            LastName = "unknown";
            DateOfBirth = new DateTime(1970, 1, 1);
            Address = "unknown";
            PhoneNumber = "unknown";
        }
        public Client(string firstName, string lastName, DateTime dateOfBirth, string address, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Address = address;
            PhoneNumber = phoneNumber;
        }
        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
