﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency.Models
{
    //Клиент -  имя + пароль + адрес.
    [Serializable]
    public class Client : User
    {
        public string Email { set; get; }
    }
}
