using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models
{
    //Турагентство - это коллекция порций
    [Serializable]
    public class Agency
    {
        public Agency(string name = "Hello", string description =  "I`m going to hell", int amountOfTrips = 0, int amountOflikes = 0, List<Portion> portions = null, Image image = null)
        {
            Name = name;
            Description = description;
            Portions = portions == null ? new List<Portion>():portions ;
            AmountOfTrips = amountOfTrips;
            AmountOfLikes = amountOflikes;
            Image = image;
            if (portions != null)
            {
                foreach (Portion p in Portions)
                {
                    p.AgencyName = name;
                    AmountOfLikes += p.Trip.Counter;
                }
            }

        }
        public string Name { set; get; }
        public string Description { set; get; }
        public int AmountOfTrips { set; get; }
        public int AmountOfLikes  {set; get; }
        public List<Portion> Portions {set; get; }
        
        public Image Image { set; get; }
        
    }
}
