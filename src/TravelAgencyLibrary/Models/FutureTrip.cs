using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models
{
    [Serializable]
    public class FutureTrip
    {
        //Будущие поездки - это порции + дата
            public FutureTrip(List<Portion> portions)
            {
                Portions = portions;
                DateTime = DateTime.Now;
            }

            public List<Portion> Portions { private set; get; }
            public DateTime DateTime { private set; get; }      
    }
}
