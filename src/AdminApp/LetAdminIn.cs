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
        }

        private void LetAdminIn_Load(object sender, EventArgs e)
        {
            store.Load();
        }

        private void Sign_in_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AdminName.Text) || string.IsNullOrWhiteSpace(AdminPassword.Text))
            {
                if (string.IsNullOrWhiteSpace(AdminName.Text))
                {
                    AdminName.BackColor = Color.MediumSeaGreen;
                }
                if (string.IsNullOrWhiteSpace(AdminPassword.Text))
                {

                    AdminPassword.BackColor = Color.MediumSeaGreen;
                }
                MessageBox.Show("Fill in the blank space, please");
                AdminName.BackColor = Color.White;
                AdminPassword.BackColor = Color.White;
            }
            else if (AdminName.Text.Length <= 4 || AdminName.Text.Length >= 10)
            {
                AdminName.BackColor = Color.MediumSeaGreen;
                MessageBox.Show("Name has inappropriate length, try again");
                AdminName.BackColor = Color.White;
                AdminName.Text = string.Empty;
            }
            else if (AdminPassword.Text.Length <= 4 || AdminPassword.Text.Length >= 10)
            {
                AdminPassword.BackColor = Color.MediumSeaGreen;
                MessageBox.Show("Password has inappropriate length, try again");
                AdminPassword.BackColor = Color.White;
                AdminPassword.Text = string.Empty;
            }
            else
            {

                string nickname;
                int number;
                int password;
                bool isInt = int.TryParse(AdminPassword.Text, out number);
                bool isIntName = int.TryParse(AdminName.Text, out number);
                //Data.
                if (isIntName == true || isInt == false)
                {
                    if (isIntName == true)
                    {

                        AdminName.BackColor = Color.MediumSeaGreen;
                        MessageBox.Show("Name consists only of numbers, try again");
                        AdminName.Text = string.Empty;
                        AdminName.BackColor = Color.White;
                    }
                    else
                    {
                        nickname = AdminName.Text;
                    }
                    if (isInt == false)
                    {

                        AdminPassword.BackColor = Color.MediumSeaGreen;
                        MessageBox.Show("Password consists not only of numbers, try again");
                        AdminPassword.Text = string.Empty;
                        AdminPassword.BackColor = Color.White;
                    }
                    else
                    {
                        password = Convert.ToInt32(AdminPassword.Text);
                    }
                }
                else
                {
                    nickname = AdminName.Text;
                    password = Convert.ToInt32(AdminPassword.Text);
                    // Check if user exists.
                    if (store.Admins.FirstOrDefault(u => u.Name == nickname && u.Password == password) != null)
                    {
                        MessageBox.Show($"Hello, Dear {nickname}! We wish you to have a nice day)");
                        Form frm2 = new MainForm(ref store);
                        frm2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sorry, such Admin doesn`t exist...Try again or sign up !");
                        AdminName.Text = string.Empty;
                        AdminPassword.Text = string.Empty;
                    }
                }

            }

        }

        private void Sign_up_Click(object sender, EventArgs e)
            {
                Form frm2 = new Sign_Up_Form(ref store);
                frm2.Show();
                this.Hide();

            }
        private void AdminName_TextChanged(object sender, EventArgs e)
            {
                (sender as Control).BackColor = Color.White;
            }

        private void AdminPassword_TextChanged(object sender, EventArgs e)
            {
                (sender as Control).BackColor = Color.White;
            }

        private void Help_MouseHover(object sender, EventArgs e)
            {
                MessageBox.Show("Hello! \n Name can consist of any letters (more than 4 less than 10) \n Password has to consist ONLY of numbers (more than 4 less than 10)");
            }

        private void LetAdminIn_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}

