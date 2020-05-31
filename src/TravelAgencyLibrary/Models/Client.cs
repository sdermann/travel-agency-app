using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TravelAgency.Models
{
    //Client = name + email + password.
    [Serializable]
    public class Client : User
    {
        public string Email { set; get; }
        public Client(string name, int password, string e_mail)
        {
            Name = name;
            Password = password;
            Email = e_mail;
        }
    }
}
