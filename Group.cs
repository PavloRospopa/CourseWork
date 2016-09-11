using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymLife
{
    [Serializable]
    public class Group: Base<Group>
    {
        static int nameId = 0;
        public Spec Specialization { get; private set; }
        public DateTime DateOfCreation { get; private set; }
        public string Name { get; set; }
        public Trainer Trainer { get; set; }
        public Group()
        {
            nameId++;
            Specialization = Spec.Fitness;
            Name = Specialization.ToString() + nameId;
            DateOfCreation = DateTime.Now;
            Trainer = null;
        }
        public Group(Spec spec, Trainer trainer, DateTime creationDate, string name)
        {
            nameId++;
            Trainer = trainer;
            Specialization = spec;
            DateOfCreation = creationDate;
            Name = (name!=string.Empty) ? name : Specialization.ToString() + nameId;
        }
        public Group(Spec spec, Trainer trainer, DateTime creationDate)
        {
            nameId++;
            Specialization = spec;
            Trainer = trainer;
            DateOfCreation = creationDate;
            Name = Specialization.ToString() + nameId;
        }
        public Group(Spec spec, Trainer trainer)
        {
            nameId++;
            Specialization = spec;
            Trainer = trainer;
            DateOfCreation = DateTime.Now;
            Name = Specialization.ToString() + nameId;
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
