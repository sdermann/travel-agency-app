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
        private List<Admin> Admins;

        public LetAdminIn()
        {
            InitializeComponent();
        }

        private void LetAdminIn_Load(object sender, EventArgs e)
        {
            List<Admin> tmp = DeserializeUsers();
            // Если считать данные не удалось, то создаем пустой список
            if (tmp == null)
                Admins = new List<Admin>();
            // А если удалось, то присваиваем полю users
            else
                Admins = tmp;


        }
        private List<Admin> DeserializeUsers()
        {
            // Изначально список равен null
            List<Admin> tmp = null;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("store.bin", FileMode.OpenOrCreate))
            {
                // Если файл не пустой, то считываем
                if (fs.Length > 0)
                    tmp = (List<Admin>)formatter.Deserialize(fs);
            }
            // Иначе возвращаем null
            return tmp;
        }

        private void SerializeUsers()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("store.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Admins);
            }
        }

        private void Sign_in_Click(object sender, EventArgs e)
        {
            // Данные с полей
            string nickname = AdminName.Text;
            string password = AdminPassword.Text;

            // Проверяем, нет ли уже такого пользователя
            if (Admins.FirstOrDefault(u => u.Name == nickname && u.Password == password) != null)
                MessageBox.Show("Hello, Dear Admin! We wish you to have a nice day)");
            else
                MessageBox.Show("Sorry, such Admin doesn`t exist...Try again or sign up !");
        }

        private void Sign_up_Click(object sender, EventArgs e)
        {
            Form frm2 = new Sign_Up_Form();
            frm2.Show();
            this.Hide();
        }
    }
}

