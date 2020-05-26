using System;
using TravelAgency.Models;
using TravelAgency.DAl;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ClientApp
{
    public partial class LetClientIn : Form
    {
        internal VisitEasy store;
        Client Client;
        public LetClientIn()
        {
            InitializeComponent();
            store = new VisitEasy();
        }

        private void LetClientIn_Load(object sender, EventArgs e)
        {
            store.Load();
        }

        private void SignInButt_Click(object sender, EventArgs e)
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            if (string.IsNullOrWhiteSpace(ClientName.Text) || string.IsNullOrWhiteSpace(ClientPassword.Text) || string.IsNullOrWhiteSpace(ClientEmail.Text))
            {
                if (string.IsNullOrWhiteSpace(ClientName.Text))
                {
                    ClientName.BackColor = Color.MediumSeaGreen;
                }
                if (string.IsNullOrWhiteSpace(ClientPassword.Text))
                {

                    ClientPassword.BackColor = Color.MediumSeaGreen;
                }
                if (string.IsNullOrWhiteSpace(ClientEmail.Text))
                {

                    ClientEmail.BackColor = Color.MediumSeaGreen;
                }
                MessageBox.Show("Fill in the blank space, please");
                ClientName.BackColor = Color.White;
                ClientPassword.BackColor = Color.White;
                ClientEmail.BackColor = Color.White;
            }
            else if (ClientName.Text.Length <= 4 || ClientName.Text.Length >= 10)
            {
                ClientName.BackColor = Color.MediumSeaGreen;
                MessageBox.Show("Name has inappropriate length, try again");
                ClientName.BackColor = Color.White;
                ClientName.Text = string.Empty;
            }
            else if (ClientPassword.Text.Length <= 4 || ClientPassword.Text.Length >= 10)
            {
                ClientPassword.BackColor = Color.MediumSeaGreen;
                MessageBox.Show("Password has inappropriate length, try again");
                ClientPassword.BackColor = Color.White;
                ClientPassword.Text = string.Empty;
            }
            else if (!Regex.IsMatch(ClientEmail.Text, pattern, RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Email has inappropriate format, try again");
                ClientEmail.BackColor = Color.White;
                ClientEmail.Text = string.Empty;
            }
            else
            {

                string nickname;
                int number;
                int password;
                string email;
                bool isInt = int.TryParse(ClientPassword.Text, out number);
                bool isIntName = int.TryParse(ClientName.Text, out number);
                // Данные с полей
                if (isIntName == true || isInt == false)
                {
                    if (isIntName == true)
                    {

                        ClientName.BackColor = Color.MediumSeaGreen;
                        MessageBox.Show("Name consists only of numbers, try again");
                        ClientName.Text = string.Empty;
                        ClientName.BackColor = Color.White;
                    }
                    else
                    {
                        nickname = ClientName.Text;
                    }
                    if (isInt == false)
                    {

                        ClientPassword.BackColor = Color.MediumSeaGreen;
                        MessageBox.Show("Password consists not only of numbers, try again");
                        ClientPassword.Text = string.Empty;
                        ClientPassword.BackColor = Color.White;
                    }
                    else
                    {
                        password = Convert.ToInt32(ClientPassword.Text);
                    }
                }
                else
                {
                    nickname = ClientName.Text;
                    password = Convert.ToInt32(ClientPassword.Text);
                    email = ClientEmail.Text;
                  
                    // Проверяем, нет ли уже такого пользователя
                    if (store.Clients.FirstOrDefault(u => u.Name == nickname && u.Password == password) != null)
                    {
                        foreach (Client c in store.Clients)
                        {
                            if (c.Name == nickname && c.Password == password && c.Email == email)
                            {
                                Client = c;
                            }
                        }
                        MessageBox.Show($"Hello, Dear {nickname}! We wish you to have a nice day)");
                        Form frm2 = new MainClientForm(store,Client);
                        frm2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sorry, such Client doesn`t exist...Try again or sign up !");
                        ClientName.Text = string.Empty;
                        ClientPassword.Text = string.Empty;
                        ClientEmail.Text = string.Empty;
                    }
                }

            }

        }


        private void AdminName_TextChanged(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.White;
        }

        private void AdminPassword_TextChanged(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.White;
        }

        private void SignUpButt_Click(object sender, EventArgs e)
        {
            Form frm2 = new Sign_up(store);
            frm2.Show();
            this.Hide();
        }

        private void ClientName_TextChanged(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.White;
        }

        private void ClientEmail_TextChanged(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.White;
        }

        private void ClientPassword_TextChanged(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.White;
        }

        private void LetClientIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("Do you want to exit?", "", MessageBoxButtons.OKCancel);
            switch (res)
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.OK:
                    break;

            }
        }











        //private void Help_MouseHover(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Hello! \n Name can consist of any letters (more than 4 less than 10) \n Password has to consist ONLY of numbers (more than 4 less than 10)");
        //}



    }
}
