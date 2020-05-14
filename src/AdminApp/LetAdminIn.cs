using TravelAgency.Models;
using TravelAgency.DAl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace AdminApp
{
    
    public partial class LetAdminIn : Form
    {
        internal VisitEasy store;
        public LetAdminIn()
        {
            InitializeComponent();
            store = new VisitEasy();
            store.Load();

        }

        private void LetAdminIn_Load(object sender, EventArgs e)
        {
            
        }
   

        private void Sign_in_Click(object sender, EventArgs e)
        {
            // Данные с полей
            string nickname = AdminName.Text;
            string password = AdminPassword.Text;

            // Проверяем, нет ли уже такого пользователя
            if (store.Admins.FirstOrDefault(u => u.Name == nickname && u.Password == password) != null)
                MessageBox.Show("Hello, Dear Admin! We wish you to have a nice day)");
            else
                MessageBox.Show("Sorry, such Admin doesn`t exist...Try again or sign up !");
        }

        private void Sign_up_Click(object sender, EventArgs e)
        {
            Form frm2 = new Sign_Up_Form(ref store);
            frm2.Show();
            this.Hide();
            
        }
    }
}

