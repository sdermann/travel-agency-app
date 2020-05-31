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
    // To create or update an Agency .
   
    public partial class EditAgency : Form
    {
        public Agency Agency { set; get; }
        public VisitEasy Store;
        bool OldAgency;
        // To create a new Agency.
        
        public EditAgency(VisitEasy store)
        {
            InitializeComponent();
            Agency = new Agency();
            Store = store;
            OldAgency = false;
        }
        //To update an old agency.
        public EditAgency(Agency agency, VisitEasy store) :this(store)
        {
            OldAgency = true ;
            Store = store;
            Agency = agency;
            NameBox.Text = agency.Name;
            DescriptionBox.Text = agency.Description;
            Agency a = agency;
            List<Portion> port = a.Portions;
            //if(port == null)
            //{
            //     port = new List<Portion> { new Portion(new Trip("Unknown", 0, "Unknown", "Unknown", "Unknown"), 0) };
            //}

            imageBox.Image = agency.Image;
        }
        private void EditAgency_Load(object sender, EventArgs e)
        {
            portionBindingSource.DataSource = Agency.Portions;
            portionBindingSource.ResetBindings(false);
            if (tripGridView.Rows.Count > 0)
            {
                tripGridView.Rows[0].Selected = true;
            }
            SendButt.Hide();
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

        private void EditAgency_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Agency != null)
            {
                if (DialogResult != DialogResult.OK)
                    return;
            }
         
          
        }

        private void SaveAgency_Click(object sender, EventArgs e)
        {
            if (Agency == null)
            {
                Agency = new Agency();
            }
            //Validation.
            bool flag = true;

            ValidateItems(DescriptionBox);
            if (DescriptionBox.Text.Length > 50 || DescriptionBox.Text.Length < 11)
            {
                MessageBox.Show("Inappropriate length for the Description. Description should be longer than 10 less than 50 (letters)");
                DescriptionBox.BackColor = Color.MediumSeaGreen;
                MessageBox.Show("Fill in the blank space,please!");
                DescriptionBox.Text = string.Empty;
                DescriptionBox.BackColor = Color.FromArgb(253, 236, 138);
                flag = false;
            }
            
            Agency.Description = DescriptionBox.Text;



            ValidateItems(NameBox);
            if (NameBox.Text.Length > 20 || NameBox.Text.Length < 4)
            {
                MessageBox.Show("Inappropriate length for the name. Name should be longer than 4 less than 20 (letters)");
                NameBox.BackColor = Color.MediumSeaGreen;
                NameBox.Text = string.Empty;
                NameBox.BackColor = Color.FromArgb(253, 236, 138);
                flag = false;
            }
            
            else
            {
                for (int i = 0; i < NameBox.Text.Length; i++)
                {
                    if (NameBox.Text[i] >= '0' && NameBox.Text[i] <= '9')
                    {

                        NameBox.BackColor = Color.MediumSeaGreen;
                        MessageBox.Show("Name contains numbers");                       
                        NameBox.Text = string.Empty;
                        NameBox.BackColor = Color.FromArgb(253, 236, 138);
                        flag = false;
                        break;
                    }
                }
            }


            Agency.Name = NameBox.Text;


            Agency.Image = imageBox.Image;
            bool SuchAgencyExists = false;
            if (Agency.Image == null)
            {
                imageBox.BackColor = Color.MediumSeaGreen;
                MessageBox.Show("You didn`t choose the picture!");
                imageBox.BackColor = Color.FromArgb(253, 236, 138);
                flag = false;

            }
            foreach(Agency  a in Store.Agencies)
            {
                if (a.Name == Agency.Name && OldAgency == false)
                {
                    SuchAgencyExists = true;
                    break;
                }
                else
                {
                    SuchAgencyExists = false;
                }
            }

            if(SuchAgencyExists == true)
            {
                MessageBox.Show("Agency with such name already exists!"); NameBox.BackColor = Color.MediumSeaGreen;
                NameBox.Text = string.Empty;
                NameBox.BackColor = Color.FromArgb(253, 236, 138);
                flag = false;
            }
            
            if(Agency.Portions.Count == 0)
            {
                MessageBox.Show("Add some trips! It`s impossible to send agency without any trips to the client!");
                flag = false;
            }
            else
            {
                Agency.Portions = new List<Portion>();
                Agency.Portions = (List<Portion>)portionBindingSource.DataSource;
                foreach (Portion p in Agency.Portions)
                {
                    p.AgencyName = Agency.Name;
                }
                Agency.AmountOfTrips = Agency.Portions.Count;
                portionBindingSource.DataSource = Agency.Portions;
                portionBindingSource.ResetBindings(false);
            }
            if (Agency.Name == "Hello" || Agency.Description == "I`m going to hell" || Agency.Image == null ||
                Agency.Portions.Count == 0 || SuchAgencyExists == true)
            {
                flag = false;
            }
          


            if (flag == true)
            {
                SendButt.Show();
                SaveAgency.Hide();
            }
            else
            {
                MessageBox.Show("You missed something!");
                SaveAgency.Show();
                SendButt.Hide();
            }


        }
        private void ValidateItems(Control c)
        {
            if (string.IsNullOrWhiteSpace(c.Text))
            {
                c.BackColor = Color.MediumSeaGreen;
                MessageBox.Show("Fill in the blank space,please!");
                c.Text = string.Empty;
                c.BackColor = Color.FromArgb(253, 236, 138);

            }
        }
        private void CancelSaving_Click(object sender, EventArgs e)
        {
            if (DialogResult != DialogResult.OK)
                return;
        }

        private void addTrip_Click(object sender, EventArgs e)
        {
            var pf = new EditPortion();
            if (pf.ShowDialog() == DialogResult.OK)
            { 
                Agency.Portions.Add(pf.Portion);
               
                portionBindingSource.ResetBindings(false);

                // select and scroll to the last row
                if (tripGridView.Rows.Count > 1)
                {
                    var lastIdx = tripGridView.Rows.Count - 1;
                    tripGridView.Rows[lastIdx].Selected = true;
                    tripGridView.FirstDisplayedScrollingRowIndex = lastIdx;
                }
            }
        }

        private void editTrip_Click(object sender, EventArgs e)
        {
            if (tripGridView.Rows.Count > 0)
            {
                var toEdit = tripGridView.SelectedRows[0].DataBoundItem as Portion;
                var pf = new EditPortion(toEdit);

                if (pf.ShowDialog() == DialogResult.OK)
                {
                    portionBindingSource.ResetBindings(false);
                }
            }
            else
            {
                MessageBox.Show("Sorry,there is nothing to edit.By the way, add some potions or delete the agency..");
            }
        }

        private void DeleteTrip_Click(object sender, EventArgs e)
        {
            if (tripGridView.Rows.Count > 0)
            {
                
                var toDel = tripGridView.SelectedRows[0].DataBoundItem as Portion;
                var res = MessageBox.Show($"Delete {toDel.Trip.Location} ?", "", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    Agency.Portions.Remove(toDel);
                    portionBindingSource.ResetBindings(false);
                }
            }
            else
            {
                MessageBox.Show("Sorry,there is nothing to delete.By the way, add some potions or delete the agency..");
            }
        }

        private void tripGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (tripGridView.Rows.Count > 0)
            {
                for (int i = 0; i < tripGridView.Rows.Count; i++)
                {
                    if (tripGridView.Rows[i].Selected == true)
                    {
                        break;
                    }
                    else if (i + 1 == tripGridView.Rows.Count)
                    {
                        tripGridView.Rows[0].Selected = true;
                    }
                }
            }
        }

        private void SendButt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added!");
        }
    }
}
