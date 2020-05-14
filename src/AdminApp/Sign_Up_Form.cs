using System;
using TravelAgency.DAl;
using TravelAgency.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class Sign_Up_Form : Form
    {
        VisitEasy store;
        const string AdminPassword = "8965";
        public Sign_Up_Form(ref VisitEasy store)
        {
            this.store = store;
            InitializeComponent();  
        }
        private void Sign_Up_Form_Load(object sender, EventArgs e)
        {
           
        }

        private void Sign_up_Click(object sender, EventArgs e)
        {

            // Берем введенные данные с полей
            string nickname = NameAdmin.Text;
            string password = Password.Text;
            string code = SicretCode.Text;
            //User user = new User(nickname, password);

            // Проверяем, есть ли в считанном ранее списке пользователь с таким ником и паролем
            // Это LINQ выражение, которое сверяет данные каждого из элементов списка (u) с введенными данными
            if (store.Admins.FirstOrDefault(u => u.Name == nickname && u.Password == password) == null)
            {
                if (code == AdminPassword)
                {
                    Admin user = new Admin(nickname, password);
                    store.Admins.Add(user);
                    MessageBox.Show("We are glad to hear you joined us!");
                    store.Save();
                    Form CustomerAutor = Application.OpenForms[0];
                    CustomerAutor.Left = this.Left;
                    CustomerAutor.Top = this.Top;
                    CustomerAutor.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show(" Check your admin pass");
                }
            }
            else
                MessageBox.Show("Sorry, such admin already exists in our team(");

            // Делаем поля пустыми
            NameAdmin.Text = string.Empty;
            Password.Text = string.Empty;
            SicretCode.Text = string.Empty;
        }
    }
}
