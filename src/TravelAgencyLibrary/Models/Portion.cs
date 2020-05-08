using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models
{
    // Порция - это путевки + количество.
    [Serializable]

    public class Portion
    {
        public Trip Trip { set; get; }
        public double Amount { set; get; }
    }
}
