using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymLife
{
    [Serializable]
    public enum Spec
    {
        Fitness, Boxing, StepAerobic
    }
    [Serializable]
    public class Trainer : Base<Trainer>
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
        public Spec Specialization { get; set; }
        DateTime entryDate;
        public int WorkExperience
        {
            get
            {
                var exp = DateTime.Now.Year - entryDate.Year;
                return exp;
            }
        }
        int salary;
        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value > 0) salary = value;
            }
        }
        public Trainer()
        {
            FirstName = "unknown";
            LastName = "unknown";
            DateOfBirth = new DateTime(1970, 1, 1);
            Address = "unknown";
            PhoneNumber = "unknown";
            Specialization = Spec.Fitness;
            entryDate = DateTime.Now;
            salary = 1000;
        }
        public Trainer(string firstName, string lastName, DateTime dateOfBirth, string address, string phoneNumber,
            Spec spec, DateTime _entryDate, int _salary)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Address = address;
            PhoneNumber = phoneNumber;
            Specialization = spec;
            entryDate = _entryDate;
            salary = _salary;
        }
        public DateTime getEntryDate()
        {
            return entryDate;
        }
        public void setEntryDate(DateTime _entryDate)
        {
            entryDate = _entryDate;
        }
        public void Retire()
        {
            Items.Remove(this.Id);
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
