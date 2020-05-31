using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models
{
    // Аdmin = name + password.
    [Serializable]
    public class Admin : User
    {
        public Admin(string name, int password)
        {
            Name = name;
            Password = password;
        }
    }
}
