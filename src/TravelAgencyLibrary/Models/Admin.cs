using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models
{
    // Администратор -  имя + пароль.
    [Serializable]
    public class Admin : User
    {
       public Admin(string name,string password)
        {
            Name = name;
            Password = password;
        }
    }
}
