using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models
{
    // Заказ – это коллекция порций + покупатель + дата
    [Serializable]
    public class Order
    {
        public Order(List<Portion> portions, Client client, DateTime? t = null)
        {
            Portions = portions;
            Client = client;
            if (t == null)
            {
                DateTime = DateTime.Now;
            }
            else
            {
                DateTime = (DateTime)t;
            }
        }

        public List<Portion> Portions { private set; get; }
        public Client Client { private set; get; }
        public DateTime DateTime { private set; get; }
    }
}
