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
    public partial class ShowAgency : Form
    {
        Agency Agency;
        Client Client;
        VisitEasy Store;

        //To process needed items.
        public ShowAgency(Agency agency,Client client,VisitEasy store)
        {
            InitializeComponent();
            Agency = agency;
            Client = client;
            Store = store;
            portionBindingSource.DataSource = Agency.Portions;
        }

        private void ShowAgency_Load(object sender, EventArgs e)
        {
            PicOfAgency.Image = Agency.Image;
            ShowAgencyName.Text = Agency.Name;
            ShowDescription.Text = Agency.Description;
            ShowAmountOfLikes.Text = Convert.ToString(Agency.AmountOfLikes);
            ShowAmountOdTrips.Text = Convert.ToString(Agency.AmountOfTrips);
            portionBindingSource.ResetBindings(false);
        }

        private void ShowAgency_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("Exit from agency?", "", MessageBoxButtons.OKCancel);
            switch (res)
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.OK:
                    break;
            }
        }

        private void LastTripsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Portion a = (Portion)LastTripsGridView.CurrentRow.DataBoundItem;
            var openAgency = new ShowTrip(a,Client,Store);
            
            if (openAgency.ShowDialog() == DialogResult.OK)
            {
              
                portionBindingSource.ResetBindings(false);
                

            }
        }
    }
}
