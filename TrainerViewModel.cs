using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymLife
{
    class TrainerViewModel
    {
        public string FirstName { get;  set; }
        public string LastName { get; set; }
        public Spec Specialization { get; set; }
        public int WorkExperience { get; set; }
        private Trainer _obj;

        public TrainerViewModel(Trainer obj)
        {
            _obj = obj;
        }

        public Trainer GetModel()
        {
            return _obj;
        }
    }
}
