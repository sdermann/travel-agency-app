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

        public Agency(string name, string description, int amountOfTrips, int amountOflikes, List<Portion> portions = null, Image image = null)
        {
            Name = name;
            Description = description;
            Portions = portions;
            AmountOfTrips = amountOfTrips;
            AmountOfLikes = amountOflikes;
            Image = image;
        }
        public string Name { private set; get; }
        public string Description { private set; get; }
        public int AmountOfTrips { private set; get; }
        public int AmountOfLikes { private set; get; }
        public List<Portion> Portions { private set; get; }
        public Image Image { set; get; }
    }
}
