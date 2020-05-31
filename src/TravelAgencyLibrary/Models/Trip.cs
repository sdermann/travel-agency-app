using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models
{
    [Serializable]
    // Trip = location + price + additional service + accomodation + host(and his\her image) + image of trip + counter of likes.
    public class Trip
    {
        
        public string Location { set; get; }
        public decimal Price { set; get; }
        public string AdditionalService { set; get; }
        public string Accomodation { set; get; }
        public string Host { set; get; }
        public Image Image { set; get; }
        public Image ImageOfHost {set;get;}

        public int Counter { set; get; }
        
       


        public Trip(string location = "unknown", decimal price = 0, string additionalservice = "unknown", string accomodation = "unknown", string host = "unknown",Image image = null, Image imageOfHost = null)
        {
            Location = location;
            Price = price;
            AdditionalService = additionalservice;
            Accomodation = accomodation;
            Host = host;
            Image = image;
            ImageOfHost = imageOfHost;
            Counter = 0;
        }
    }
}
