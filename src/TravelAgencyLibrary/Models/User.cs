using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models
{
    [Serializable]
    //Abstract user - parent for Admin and Client.
    //Name + password.
    public abstract class User
    {
        
        
        public string Name { set; get; }
        public int Password { set; get; }
    }
}
