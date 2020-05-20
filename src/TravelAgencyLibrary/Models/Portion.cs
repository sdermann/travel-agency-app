using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models
{
    // Порция - это путевки + количество.
    [Serializable]

    public class Portion
    {
        public Trip Trip { set; get; }
        public int Amount { set; get; }

        public Portion(Trip trip = null, int amount = 0)
        {
            Trip = trip;
            Amount = amount;
        }
    }
}
