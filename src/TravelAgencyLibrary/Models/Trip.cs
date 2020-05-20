using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models
{
    [Serializable]
    public class Trip
    {
        //Путевка –  локация + цена + доп.услуги +  условия проживания и проезда + сервис принимающей стороны;
        public string Location { set; get; }
        public decimal Price { set; get; }
        public string AdditionalService { set; get; }
        public string Accomodation { set; get; }
        public string Host { set; get; }
        
       


        public Trip(string location = "unknown", decimal price = 0, string additionalservise = "unlnown", string accomodation = "unlnown", string host = "unlnown")
        {
            Location = location;
            Price = price;
            AdditionalService = additionalservise;
            Accomodation = accomodation;
            Host = host;
        }
    }
}
