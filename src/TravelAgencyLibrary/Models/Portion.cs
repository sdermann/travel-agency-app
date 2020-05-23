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
        public string OnSaleOrInFuture { set; get; }

        public string AgencyName { set; get;}
        public string Location { set; get; }
        public Portion(Trip trip = null, int amount = 0,string onSaleOrInFuture = "None")
        {
            Trip = trip;
            Amount = amount;
            OnSaleOrInFuture = onSaleOrInFuture;
            if (trip != null)
            {
                Location = trip.Location;
            }
        }
    }
}
