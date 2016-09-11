using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymLife
{
    [Serializable]
    public class Workout : Base<Workout>
    {
        public Group Group { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Duration { get; set; }
        public Trainer ActualTrainer { get; set; }
        public string Description { get; set; }
        
        public Workout()
        {
            Group = null;
            Date = DateTime.Now;
            Duration = new TimeSpan(1, 0, 0);
            Description = "Another workout of " + Group.Name;
            ActualTrainer = null;
        }
        public Workout(Group group, DateTime date, TimeSpan duration, string description, Trainer actualTrainer)
        {
            Group = group;
            Date = date;
            Duration = duration;
            Description = (description!=String.Empty) ? description : 
                String.Format("Тренування групи {0}, яке відбудеться {1} о {2}",Group.ToString(),
                Date.ToShortDateString(), Date.ToShortTimeString());
            ActualTrainer = actualTrainer;
        }
        public Workout(Group group, DateTime date, TimeSpan duration, string description)
        {
            Group = group;
            Date = date;
            Duration = duration;
            Description = description;
            ActualTrainer = group.Trainer;
        }
        public Workout(Group group, DateTime date, TimeSpan duration)
        {
            Group = group;
            Date = date;
            Duration = duration;
            Description = "Another workout of " + Group.Name;
            ActualTrainer = group.Trainer;
        }
        public Workout(Group group, DateTime date)
        {
            Group = group;
            Date = date;
            Duration = new TimeSpan(1, 0, 0);
            Description = "Another workout of " + Group.Name;
            ActualTrainer = group.Trainer;
        }
        public void Cancel()
        {
            Items.Remove(this.Id);
        }
    }
}
