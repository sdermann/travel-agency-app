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
    public partial class EditPortion : Form
    {
        public Portion Portion { set; get; }
        public EditPortion()
        {
            InitializeComponent();

            List<string> states = new List<string>
            {

                "Cairo", "Bangkok","New York","Budapest","London", "Paris",
                "Berlin", "Gdansk", "Talin", "Beijing", "Rio de Janeiro", 
                "Affins", "Larnaca", "Sharm El Sheikh", "Vienna", "Amsterdam",
                "Odessa", "St. Petersburg", "Moscow", "Lviv", "Sydney"
            };

            List<string> on = new List<string>
            {
                "OnSale", "FutureTrip","None"
            };

            // add lists
            LocationOfTrip.Items.AddRange(states);
            OnSaleOrFutureUpDown.Items.AddRange(on);
            AmountOfTrips.Maximum = 30;
            AmountOfTrips.Minimum = 0;

   
        }
        public EditPortion(Portion port) :this()
        {
          
            Portion = port;
            AmountOfTrips.Value = port.Amount;
            LocationOfTrip.Text = port.Trip.Location;
            OnSaleOrFutureUpDown.Text = port.OnSaleOrInFuture;
            PriceBox.Text = Convert.ToString(port.Trip.Price);
            ServiceBox.Text = port.Trip.AdditionalService;
            AccomodationBox.Text = port.Trip.Accomodation;
            HostBox.Text = port.Trip.Host;
            tripPicBox.Image = port.Trip.Image;
            HostPic.Image = port.Trip.ImageOfHost;
        }

        private void tripPicBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               
                tripPicBox.Image = new Bitmap(openFileDialog1.FileName);
            }
        }
        private void HostPic_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                HostPic.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void EditPortion_TextChanged(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.White;
        }


        private void RequiredValidate(Control c, FormClosingEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(c.Text))
            {
                c.BackColor = Color.MediumSeaGreen;
                e.Cancel = true;
            }
        }

        private void EditPortion_FormClosing(object sender, FormClosingEventArgs e)
        {
           if (DialogResult != DialogResult.OK)
                 return;
            RequiredValidate(LocationOfTrip, e);
            RequiredValidate(PriceBox, e);
            RequiredValidate(ServiceBox, e);
            RequiredValidate(AccomodationBox, e);
        }







        private void CheckButt_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (Portion == null)
            {
                Portion = new Portion();
            }

            //Portion.Amount = (int)AmountOfTrips.Value;
            if (LocationOfTrip.Text != "Location")
            {
                Portion.Trip.Location = LocationOfTrip.Text;
                Portion.LocationOfTrip = Portion.Trip.Location;
            }
            else
            {
                MessageBox.Show("You didn`t choose the location");
                flag = false;
            }
            //Portion.Trip.Location = LocationOfTrip.Text;


            int number;
            bool isInt = int.TryParse(PriceBox.Text, out number);
            if (isInt == true)
            {
                Portion.Trip.Price = Convert.ToInt32(PriceBox.Text);
                Portion.PriceOfEachTrip = Portion.Trip.Price;
            }
            else
            {
                PriceBox.BackColor = Color.MediumSeaGreen;
                MessageBox.Show("Price always consists of numbers!");
                PriceBox.BackColor = Color.FromArgb(253, 236, 138);
                flag = false;
            }
            // Portion.Trip.Price = Convert.ToInt32(PriceBox.Text);
            //Portion.PriceOfEachTrip = Portion.Trip.Price;




            ValidateItems(HostBox);
            if (HostBox.Text.Length < 5 || HostBox.Text.Length > 15)
            {
                MessageBox.Show("Inappropriate length for the name. Name should be longer than 4 less than 15 (letters)");
                HostBox.BackColor = Color.MediumSeaGreen;
                HostBox.Text = string.Empty;
                HostBox.BackColor = Color.FromArgb(253, 236, 138);
                flag = false;
            }
            else
            {
                for (int i = 0; i < HostBox.Text.Length; i++)
                {
                    if (HostBox.Text[i] >= '0' && HostBox.Text[i] <= '9')
                    {

                        HostBox.BackColor = Color.MediumSeaGreen;
                        MessageBox.Show("Name contains numbers");
                        HostBox.Text = string.Empty;
                        HostBox.BackColor = Color.FromArgb(253, 236, 138);
                        flag = false;
                        break;
                    }
                }
            }
            Portion.Trip.Host = HostBox.Text;




            ValidateItems(ServiceBox);
            if (ServiceBox.Text.Length > 50 || ServiceBox.Text.Length < 10)
            {
                MessageBox.Show("Inappropriate length for the service. Name should be longer than 10 less than 50 (letters)");
                ServiceBox.BackColor = Color.MediumSeaGreen;
                ServiceBox.Text = string.Empty;
                ServiceBox.BackColor = Color.FromArgb(253, 236, 138);
                flag = false;
            }
            Portion.Trip.AdditionalService = ServiceBox.Text;


            ValidateItems(AccomodationBox);
            if (AccomodationBox.Text.Length > 20 || AccomodationBox.Text.Length < 6)
            {
                MessageBox.Show("Inappropriate length for the Accomodation. Accomodation should be longer than 5 less than 20 (letters)");
                AccomodationBox.BackColor = Color.MediumSeaGreen;
                AccomodationBox.Text = string.Empty;
                AccomodationBox.BackColor = Color.FromArgb(253, 236, 138);
                flag = false;
            }
            Portion.Trip.Accomodation = AccomodationBox.Text;

            Portion.Trip.Image = tripPicBox.Image;
            if (Portion.Trip.Image == null)
            {
                tripPicBox.BackColor = Color.MediumSeaGreen;
                MessageBox.Show("You didn`t choose the picture!");
                tripPicBox.BackColor = Color.FromArgb(253, 236, 138);
                flag = false;

            }
            //Portion.Trip.Image = tripPicBox.Image;
            Portion.Trip.ImageOfHost = HostPic.Image;
            if (Portion.Trip.ImageOfHost == null)
            {
                HostPic.BackColor = Color.MediumSeaGreen;
                MessageBox.Show("You didn`t choose the picture!");
                HostPic.BackColor = Color.FromArgb(253, 236, 138);
                flag = false;

            }
            if(AmountOfTrips.Value == 0)
            {
                MessageBox.Show("Trips with 0 amount of trips can`t be send to the client!");
            }
          

            Portion.OnSaleOrInFuture = OnSaleOrFutureUpDown.Text;
           
            if ( Portion.Amount == 0 || Portion.LocationOfTrip == null
                || Portion.PriceOfEachTrip == 0 || Portion.Trip.Image == null || Portion.Trip.ImageOfHost == null
                || Portion.Trip.Location == "unknown"|| Portion.Trip.Price == 0 || Portion.Trip.AdditionalService == "unknown"||
                Portion.Trip.Accomodation == "unknown"|| Portion.Trip.Host == "unknown")
            {
                flag = false;
            }

            if (flag == true)
            {
                SavePortion.Show();
                CheckButt.Hide();
            }
            else
            {
                MessageBox.Show("You missed something.Check again!");
                SavePortion.Hide();
                CheckButt.Show();
            }
            
        }

        private void ValidateItems(Control c)
        {
            if (string.IsNullOrWhiteSpace(c.Text))
            {
                c.BackColor = Color.MediumSeaGreen;
                MessageBox.Show("Fill in the blank space,please!");
                c.BackColor = Color.FromArgb(253, 236, 138);
            }
        }
        private void AmountOfTrips_ValueChanged(object sender, EventArgs e)
        {
            if(Portion == null)
            {
                Portion = new Portion();
            }
            if (AmountOfTrips.Value == 0)
            {
                MessageBox.Show("Trips with 0 amount of trips can`t be send to the client!");
            }
            else if (Convert.ToInt32(AmountOfTrips.Value) == 30)
            {
                MessageBox.Show("This is the maximum possible amount of trips ");
            }
            else
            {
                Portion.Amount = (int)AmountOfTrips.Value;
            }
        }

        private void EditPortion_Load(object sender, EventArgs e)
        {
            SavePortion.Hide();
        }

        private void SavePortion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added!");
        }

    }
}
