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
            Agency = new Agency();
        }
        public EditAgency(Agency agency) :this()
        {
            Agency = agency;
            NameBox.Text = agency.Name;
            DescriptionBox.Text = agency.Description;
            Agency a = agency;
            List<Portion> port = a.Portions;
            if(port == null)
            {
                 port = new List<Portion> { new Portion(new Trip("Unknown", 0, "Unknown", "Unknown", "Unknown"), 0) };
            }

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
            Agency.Portions = new List<Portion>();
            Agency.Portions = (List<Portion>)portionBindingSource.DataSource;
            foreach(Portion p in Agency.Portions)
            {
                p.AgencyName = Agency.Name;
            }
            Agency.AmountOfTrips = Agency.Portions.Count;
            Agency.Image = imageBox.Image;
            portionBindingSource.DataSource = Agency.Portions;
            portionBindingSource.ResetBindings(false);
        }

        private void CancelSaving_Click(object sender, EventArgs e)
        {
            
        }

        private void addTrip_Click(object sender, EventArgs e)
        {
            var pf = new EditPortion();
            if (pf.ShowDialog() == DialogResult.OK)
            { 
                Agency.Portions.Add(pf.Portion);
               
                portionBindingSource.ResetBindings(false);

                // select and scroll to the last row
                var lastIdx = tripGridView.Rows.Count - 1;
               // tripGridView.Rows[lastIdx].Selected = true;
                //tripGridView.FirstDisplayedScrollingRowIndex = lastIdx;
            }
        }

        private void editTrip_Click(object sender, EventArgs e)
        {
            var toEdit = tripGridView.SelectedRows[0].DataBoundItem as Portion;
            var pf = new EditPortion(toEdit);

            if (pf.ShowDialog() == DialogResult.OK)
            {
                portionBindingSource.ResetBindings(false);
            }
        }

        private void DeleteTrip_Click(object sender, EventArgs e)
        {

            var toDel = tripGridView.SelectedRows[0].DataBoundItem as Portion;
            var res = MessageBox.Show($"Delete {toDel.Trip.Location} ?", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Agency.Portions.Remove(toDel);
                portionBindingSource.ResetBindings(false);
            }
        }

        private void EditAgency_Load(object sender, EventArgs e)
        {
            portionBindingSource.DataSource = Agency.Portions;
            portionBindingSource.ResetBindings(false);

            //tripGridView.Rows[0].Selected = true;
        }
    }
}
