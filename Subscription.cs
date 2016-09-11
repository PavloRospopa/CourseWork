using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymLife
{
    [Serializable]
    public class Subscription : Base<Subscription>
    {
        public Client Owner { get; set; }
        public Spec Specialization { get; private set; }
        public int Price { get; private set; }
        public TimeSpan Validity { get; private set; }
        public DateTime ActivationDate { get; set; }     
        public DateTime ExpirationDate
        {
            get
            {
                var expDate = ActivationDate + Validity;
                return expDate;
            }
        }
        public Subscription()
        {
            Specialization = Spec.Fitness;
            ActivationDate = DateTime.Now;
            Validity = new TimeSpan(365, 0, 0, 0);
            Price = 5000;
            Owner = null;
        }
        public Subscription(Spec spec, TimeSpan validity, Client owner, DateTime activationDate)
        {
            Specialization = spec;
            Validity = validity;
            Owner = owner;
            ActivationDate = activationDate;

            if (validity.Days < 90) Price = 750;
            else if (validity.Days < 180) Price = 2000;
            else if (validity.Days < 365) Price = 3000;
            else Price = 5000;
        }
        public Subscription(Spec spec, TimeSpan validity, Client owner)
        {
            Specialization = spec;
            Validity = validity;
            Owner = owner;
            ActivationDate = DateTime.Now;

            if (validity.Days < 90) Price = 750;
            else if (validity.Days < 180) Price = 2000;
            else if (validity.Days < 365) Price = 3000;
            else Price = 5000;
        }
    }
}
