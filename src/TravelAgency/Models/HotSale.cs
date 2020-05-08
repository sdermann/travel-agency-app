using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models

{
    //Скидки – это порции  +  дата действия
    [Serializable]
    public class HotSale
    {
            public HotSale(List<Portion> portions, DateTime x)
            {
                Portions = portions;
                DateTime = x; //(2020, 5, 1, 8, 30, 52)
        }

            public List<Portion> Portions { private set; get; }
            public DateTime DateTime { set; get; }     
    }
}
