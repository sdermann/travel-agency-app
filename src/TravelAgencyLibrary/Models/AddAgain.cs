using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models;

namespace TravelAgencyLibrary.Models
{
    // Порция - это путевки + количество.
    [Serializable]
    public class AddAgain
    {
   
            public Trip Trip { set; get; }
            public int Amount { set; get; }
            public string OnSaleOrInFuture { set; get; }

            public string AgencyName { set; get; }
            public string LocationOfTrip { set; get; }
            public decimal PriceOfEachTrip { set; get; }
            public AddAgain(Trip trip = null, int amount = 0, string onSaleOrInFuture = "None")
            {

                Trip = trip == null ? new Trip() : trip;

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
