using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Models;

namespace ClientApp
{
    public partial class MainClientForm : Form
    {
        VisitEasy Store;
        public MainClientForm(VisitEasy store)
        {
            InitializeComponent();
            Store = store;
            agencyBindingSource.DataSource = Store.Agencies;
        }

        private void MainClientForm_Load(object sender, EventArgs e)
        {
            Store.Load();
            agencyBindingSource.ResetBindings(false);
           
        }

     
        private void Unrate_Click(object sender, EventArgs e)
        {

        }

        private void Rate_Click(object sender, EventArgs e)
        {

        }

      

        private void Question_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Hello! \nYou can search for your favourite agency just by filling in its name (only letters) \nRate hearts will rate agencies by popularity(likes)");
        }

        private void SearchButt_Click(object sender, EventArgs e)
        {

        }
    }
}
