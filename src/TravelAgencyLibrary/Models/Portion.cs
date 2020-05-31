using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency.Models
{
    // Portions is a trip and its amount.
    [Serializable]

    public class Portion
    {
        public Trip Trip { set; get; }
        public int Amount { set; get; }
        public string OnSaleOrInFuture { set; get; }

        public string AgencyName { set; get;}
        public string LocationOfTrip { set; get; }
        public decimal PriceOfEachTrip { set; get; }
      
       //Constructor.
        public Portion(Trip trip = null, int amount = 0,string onSaleOrInFuture = "None")
        {

            Trip = trip==null? new Trip(): trip;
            Amount = amount;
            OnSaleOrInFuture = onSaleOrInFuture;
            if (trip != null)
            {
                LocationOfTrip = trip.Location;
                PriceOfEachTrip = trip.Price;
            }
           
        }
    }
}
