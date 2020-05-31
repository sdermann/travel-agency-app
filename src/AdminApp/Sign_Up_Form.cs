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
        const string PasswordX = "8965";
        public Sign_Up_Form(ref VisitEasy store)
        {
            this.store = store;
            InitializeComponent();
        }


        private void Sign_up_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(NameAdmin.Text) || string.IsNullOrWhiteSpace(Password.Text))
            {
                if (string.IsNullOrWhiteSpace(NameAdmin.Text))
                {
                    NameAdmin.BackColor = Color.MediumSeaGreen;
                }
                if (string.IsNullOrWhiteSpace(Password.Text))
                {

                    Password.BackColor = Color.MediumSeaGreen;
                }
                MessageBox.Show("Fill in the blank space, please");
                NameAdmin.BackColor = Color.White;
                Password.BackColor = Color.White;
            }
            else if (NameAdmin.Text.Length <= 4 || NameAdmin.Text.Length >= 10)
            {
                NameAdmin.BackColor = Color.MediumSeaGreen;
                MessageBox.Show("Name has inappropriate length, try again");
                NameAdmin.BackColor = Color.White;
                NameAdmin.Text = string.Empty;
            }
            else if (Password.Text.Length <= 4 || Password.Text.Length >= 10)
            {
                Password.BackColor = Color.MediumSeaGreen;
                MessageBox.Show("Password has inappropriate length, try again");
                Password.BackColor = Color.White;
                Password.Text = string.Empty;
            }
            else
            {

                string nickname;
                int number;
                int password;
                bool isInt = int.TryParse(Password.Text, out number);
                bool isIntName = int.TryParse(NameAdmin.Text, out number);
                // Data
                if (isIntName == true || isInt == false)
                {
                    if (isIntName == true)
                    {

                        NameAdmin.BackColor = Color.MediumSeaGreen;
                        MessageBox.Show("Name consists only of numbers, try again");
                        NameAdmin.Text = string.Empty;
                        NameAdmin.BackColor = Color.White;
                    }
                    else
                    {
                        nickname = NameAdmin.Text;
                    }
                    if (isInt == false)
                    {

                        Password.BackColor = Color.MediumSeaGreen;
                        MessageBox.Show("Password consists not only of numbers, try again");
                        Password.Text = string.Empty;
                        Password.BackColor = Color.White;
                    }
                    else
                    {
                        password = Convert.ToInt32(Password.Text);
                    }
                }
                else
                {
                    nickname = NameAdmin.Text;
                    password = Convert.ToInt32(Password.Text);
                    string pass = SicretCode.Text;
                    // Check if user exists
                    if (store.Admins.FirstOrDefault(u => u.Name == nickname ) != null)
                    {
                        MessageBox.Show("Sorry, such Admin-name already exists in our team..");
                        NameAdmin.Text = string.Empty;
                        Password.Text = string.Empty;
                       
                    }
                    else
                    {
                        if (pass == PasswordX)
                        {
                            Admin user = new Admin(nickname, password);
                            store.Admins.Add(user);
                            MessageBox.Show("We are glad to hear you joined us!");
                            store.Save();
                            Form CustomerAutor = Application.OpenForms[0];
                            CustomerAutor.Left = this.Left;
                            CustomerAutor.Top = this.Top;
                            CustomerAutor.Show();
                            this.Close();
                        }
                        else
                        {
                            SicretCode.BackColor = Color.MediumSeaGreen;
                            MessageBox.Show("Check your Admin password!)");
                            SicretCode.BackColor = Color.White;
                            SicretCode.Text = string.Empty;

                        }
                    }
                }
            }
        }

        private void Sign_Up_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("Do you want to exit from the singing up?", "", MessageBoxButtons.OKCancel);
            switch (res)
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.OK:
                    Form CustomerAutor = Application.OpenForms[0];
                    CustomerAutor.Left = this.Left;
                    CustomerAutor.Top = this.Top;
                    CustomerAutor.Show();
                    break;
            }
        }

    }
}
