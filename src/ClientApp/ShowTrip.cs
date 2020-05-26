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
    public partial class ShowTrip : Form
    {
        Portion Portion;
        Client Client;
        Order Order;
        VisitEasy Store;
        public bool SomethingOrdered;
        public ShowTrip(Portion portion,Client client,VisitEasy store)
        {
            InitializeComponent();
            Portion = portion;
            Client = client;
            Store = store;
            HowMany.Maximum = Portion.Amount;
            HowMany.Minimum = 0;
        }

        private void ShowTrip_Load(object sender, EventArgs e)
        {
            LocationText.Text = Portion.Trip.Location;
            PriceText.Text = Convert.ToString(Portion.Trip.Price);
            AddServText.Text = Portion.Trip.AdditionalService;
            AccomodationText.Text = Portion.Trip.Accomodation;
            HostText.Text = Portion.Trip.Host;
            //HostBox.Image = Portion.HostImage.Image;
            tripPic.Image = Portion.Trip.Image;
            liiiikes.Text = Convert.ToString(Portion.Trip.Counter);
            heartUnlike.Hide();
        }

        private void ShowTrip_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("Exit from trip?", "", MessageBoxButtons.OKCancel);
            switch (res)
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.OK:
                    break;
            }
        }

        private void hearLike_Click(object sender, EventArgs e)
        {
            Portion.Trip.Counter += 1;
            hearLike.Hide();
            heartUnlike.Show();
            liiiikes.Text = Convert.ToString(Portion.Trip.Counter);
        }

        private void heartUnlike_Click(object sender, EventArgs e)
        {
            Portion.Trip.Counter -= 1;
            hearLike.Show();
            heartUnlike.Hide();
            liiiikes.Text = Convert.ToString(Portion.Trip.Counter);
        }

  

        private void OrderButt_Click(object sender, EventArgs e)
        {
            if (SomethingOrdered == true)
            {
                //TODO почему не добавляет 
                Portion.Amount -= Convert.ToInt32(HowMany.Value);
                List<Portion> portions = new List<Portion>();
                Portion LastHope = new Portion(Portion.Trip,(int)HowMany.Value,Portion.OnSaleOrInFuture);
                // MessageBox.Show(Convert.ToString(Portion.AgencyName));
                
                portions.Add(LastHope);
                foreach(Portion p in portions)
                {
                    p.AgencyName = Portion.AgencyName;
                }
                int counter = 0;
                bool ToBreak = false;
                if (Store.Orders.Count > 0)
                {
                    
                    for (int i = 0; i < Store.Orders.Count; i++)
                    {
                        if (Store.Orders[i].Client.Name == Client.Name)
                        {
                             foreach (Portion p in Store.Orders[i].Portions)
                             {
                                  if (p.AgencyName == LastHope.AgencyName && p.Trip.Location == LastHope.Trip.Location && p.Trip.Price == LastHope.Trip.Price)
                                  {
                                        p.Amount += LastHope.Amount;
                                        ToBreak = true;
                                        break;
                                  }
                                  else
                                  {
                                        Store.Orders[i].Portions.Add(LastHope);
                                        MessageBox.Show(Convert.ToString(Store.Orders[i].Portions[0].AgencyName));
                                       ToBreak = true;
                                        break;
                                        
                                  }
                             }
                             counter += 1;
                        }
                        if(ToBreak == true)
                        {
                            break;
                        }
                        if ((counter + 1) == Store.Orders.Count)
                        {
                            Order = new Order(portions, Client);
                            MessageBox.Show(Convert.ToString(Order.Portions[0].AgencyName));
                            Store.Orders.Add(Order);

                        }
                    }
                    
                }
                else
                {   
                    Order = new Order(portions, Client);
                    Store.Orders.Add(Order);
                }
               

                
                MessageBox.Show($"You ordered this trip x {HowMany.Value}:)\nEnjoy your time!\nThank you");
                if (Portion.Amount == 0)
                {

                    foreach (Agency a in Store.Agencies)
                    {
                        if (a.Name == Portion.AgencyName)
                        {
                            foreach (Portion p in a.Portions)
                            {
                                if (p.LocationOfTrip == Portion.LocationOfTrip && p.OnSaleOrInFuture == Portion.OnSaleOrInFuture && p.PriceOfEachTrip == Portion.PriceOfEachTrip && p.Trip.Host == Portion.Trip.Host)
                                {
                                    a.Portions.Remove(p);
                                }
                            }
                        }
                    }
                }
                
                Store.Save();
                if (DialogResult != DialogResult.OK)
                    return;
            }
            else
            {
                MessageBox.Show("Sorry,you didn`t pick even one trip :( Try again");
            }
        }

        private void HowMany_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(HowMany.Value) >= 1)
            {
                SomethingOrdered = true;
            }
            else
            {
                SomethingOrdered = false;
            }
        }
    }
}
