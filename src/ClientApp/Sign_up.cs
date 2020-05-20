using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Models;

namespace ClientApp
{
    public partial class Sign_up : Form
    {
        VisitEasy store;

       
        public Sign_up(ref VisitEasy store)
        {
            InitializeComponent();
            this.store = store;
        }

        private void SignButt_Click(object sender, EventArgs e)
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            if (string.IsNullOrWhiteSpace(ClientName.Text) || string.IsNullOrWhiteSpace(ClientPassword.Text))
            {
                if (string.IsNullOrWhiteSpace(ClientName.Text))
                {
                    ClientName.BackColor = Color.MediumSeaGreen;
                }
                if (string.IsNullOrWhiteSpace(ClientPassword.Text))
                {

                    ClientPassword.BackColor = Color.MediumSeaGreen;
                }
                MessageBox.Show("Fill in the blank space, please");
                ClientName.BackColor = Color.White;
                ClientPassword.BackColor = Color.White;
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
                MessageBox.Show("ClientPassword has inappropriate length, try again");
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
                    if (store.Admins.FirstOrDefault(u => u.Name == nickname) != null)
                    {
                        MessageBox.Show("Sorry, such Admin-name already exists in our team..");
                        ClientName.Text = string.Empty;
                        ClientPassword.Text = string.Empty;

                    }
                    else
                    {

                        Client user = new Client(nickname, password,email);
                        store.Clients.Add(user);
                        MessageBox.Show("We are glad to hear you joined us!");
                        store.Save();
                        Form CustomerAutor = Application.OpenForms[0];
                        CustomerAutor.Left = this.Left;
                        CustomerAutor.Top = this.Top;
                        CustomerAutor.Show();
                        this.Close();
                    }        
                }
            }
        }
    }
}
