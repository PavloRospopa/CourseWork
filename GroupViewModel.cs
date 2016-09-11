using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymLife
{
    class GroupViewModel
    {
        public string Name { get; set; }
        public Spec Specialization { get; set; }
        public Trainer Trainer { get; set; }
        private Group _obj;
        public GroupViewModel(Group obj)
        {
            _obj = obj;
        }
        public Group GetModel()
        {
            return _obj;
        }
    }
}
