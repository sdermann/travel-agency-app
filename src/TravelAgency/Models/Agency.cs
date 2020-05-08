using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models
{
    //Турагентство - это коллекция порций
    [Serializable]
    public class Agency
    {

        public Agency(List<Portion> portions, string name, int amountOfTrips, int amountOflikes)
        {
            Portions = portions;
            Name = name;
            AmountOfTrips = amountOfTrips;
            AmountOfLikes = amountOflikes;
        }
        public string Name { private set; get; }
        public int AmountOfTrips { private set; get; }
        public int AmountOfLikes { private set; get; }
        public List<Portion> Portions { private set; get; }
    }
}
