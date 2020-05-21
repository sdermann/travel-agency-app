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

namespace AdminApp
{
    // For create or update a product.
    //
    public partial class EditAgency : Form
    {
        public Agency Agency { set; get; }

        // To create a new product.
        
        public EditAgency()
        {
            InitializeComponent();
        }
        public EditAgency(Agency agency) :this()
        {
            Agency = agency;
            NameBox.Text = agency.Name;
            DescriptionBox.Text = agency.Description;
            Agency a = agency;
            List<Portion> port = a.Portions;
            portionsBindingSource.DataSource = port;
            portionsBindingSource.ResetBindings(false);
            imageBox.Image = agency.Image;
        }

        private void imageBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imageBox.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void EditAgency_TextChanged(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.White;
        }


        private void RequiredValidate(Control c, FormClosingEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(c.Text))
            {
                c.BackColor = Color.Pink;
                e.Cancel = true;
            }
        }

        private void EditAgency_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
                return;
            RequiredValidate(NameBox, e);
            RequiredValidate(DescriptionBox, e);
        }

        private void SaveAgency_Click(object sender, EventArgs e)
        {
            if (Agency == null)
            {
                Agency = new Agency();
            }
            Agency.Name = NameBox.Text;
            Agency.Description = DescriptionBox.Text;
            Agency.Portions = (List<Portion>)portionsBindingSource.DataSource;
            Agency.AmountOfTrips = Agency.Portions.Count;
            Agency.Image = imageBox.Image;
           
        }

        private void CancelSaving_Click(object sender, EventArgs e)
        {
            
        }
    }
}
