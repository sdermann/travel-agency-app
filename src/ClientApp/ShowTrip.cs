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
            Portion = new Portion();
            Portion = portion;
            Client = client;
            Store = store;
            HowMany.Maximum = Portion.Amount;
            HowMany.Minimum = 0;
            liiiikes.Text = Convert.ToString(Portion.Trip.Counter);
        }

        private void ShowTrip_Load(object sender, EventArgs e)
        {
  
            Store.Save();
            LocationText.Text = Portion.Trip.Location;
            PriceText.Text = Convert.ToString(Portion.Trip.Price);
            AddServText.Text = Portion.Trip.AdditionalService;
            AccomodationText.Text = Portion.Trip.Accomodation;
            HostText.Text = Portion.Trip.Host;
            HostBox.Image = Portion.Trip.ImageOfHost;
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
            liiiikes.Text = Convert.ToString(Portion.Trip.Counter);
            Portion.Trip.Counter++;
            
            hearLike.Hide();
            heartUnlike.Show();
            liiiikes.Text = Convert.ToString(Portion.Trip.Counter);
            bool breaky = false;
            foreach(Agency a in Store.Agencies)
            {
                
                foreach(Portion p in a.Portions)
                {
                    if (p.AgencyName == Portion.AgencyName && p.Trip.Location == Portion.Trip.Location && p.Trip.Price == Portion.Trip.Price || p.Amount ==  Portion.Amount)
                    {
                        
                        a.AmountOfLikes++;
                     
                        if (p.AgencyName == Portion.AgencyName && p.Trip.Location == Portion.Trip.Location && p.Trip.Price == Portion.Trip.Price || p.Amount == Portion.Amount)
                        {
                            p.Trip.Counter = Portion.Trip.Counter;
                        }
                        breaky = true;
                        break;
                    }
                }
                if(breaky == true)
                {
                    break;
                }
               
            }
            Store.Save();
        }

        private void heartUnlike_Click(object sender, EventArgs e)
        {
            liiiikes.Text = Convert.ToString(Portion.Trip.Counter);
            Portion.Trip.Counter -= 1;
            hearLike.Show();
            heartUnlike.Hide();
            bool breaky = false;
            liiiikes.Text = Convert.ToString(Portion.Trip.Counter);
            foreach (Agency a in Store.Agencies)
            {

                foreach (Portion p in a.Portions)
                {
                    if (p.AgencyName == Portion.AgencyName && p.Trip.Location == Portion.Trip.Location && p.Trip.Price == Portion.Trip.Price || p.Amount == Portion.Amount)
                    {
                        a.AmountOfLikes --;
                        if (p.AgencyName == Portion.AgencyName && p.Trip.Location == Portion.Trip.Location && p.Trip.Price == Portion.Trip.Price || p.Amount == Portion.Amount)
                        {
                            p.Trip.Counter = Portion.Trip.Counter;
                        }
                        breaky = true;
                        break;
                    }
                }
                if (breaky == true)
                {
                    break;
                }
            }
            Store.Save();
        }

  

        private void OrderButt_Click(object sender, EventArgs e)
        {

            if (SomethingOrdered == true)
            {
                bool OrderAllowed = true;
                foreach (Order o in Store.Orders)
                {
                    if (o.ClientName == Client.Name)
                    {
                        if (o.IsOrdered == true)
                        {
                            MessageBox.Show("Please, wait before the admin accept your order) And then you can choose other trips!");
                            OrderAllowed = false;
                            break;
                        }

                    }
                }
                if (OrderAllowed == true)
                {
                    List<Portion> portions = new List<Portion>();
                    //I was very tired of adding this product (LastHope is just new portion for the order)It was Last hope.

                    Portion LastHope = new Portion(Portion.Trip, (int)HowMany.Value, Portion.OnSaleOrInFuture);
                    LastHope.AgencyName = Portion.AgencyName;
                    LastHope.LocationOfTrip = Portion.LocationOfTrip;
                    LastHope.PriceOfEachTrip = Portion.PriceOfEachTrip;


                    portions.Add(LastHope);
                    foreach (Portion p in portions)
                    {
                        p.AgencyName = Portion.AgencyName;
                    }
                    //int counter = 0;
                    bool ToBreak = false;

                    if (Store.Orders.Count > 0)
                    {

                        for (int i = 0; i < Store.Orders.Count; i++)
                        {
                            if (Store.Orders[i].Client.Name == Client.Name)
                            {
                                for (int j = 0;i < Store.Orders[i].Portions.Count;j++)
                                {
                                    if (Store.Orders[i].Portions[j].AgencyName == LastHope.AgencyName && 
                                        Store.Orders[i].Portions[j].Trip.Location == LastHope.Trip.Location &&
                                        Store.Orders[i].Portions[j].Trip.Price == LastHope.Trip.Price)
                                    {
                                        Store.Orders[i].Portions[j].Amount += LastHope.Amount;
                                        ToBreak = true;

                                        break;
                                    }
                                    else if(j + 1 == Store.Orders[i].Portions.Count)
                                    {
                                        Store.Orders[i].Portions.Add(LastHope);
                                        ToBreak = true;
                                        break;

                                    }
                                }
                               
                            }
                            //counter += 1;
                            if (ToBreak == true)
                            {
                                break;
                            }
                            //if ((counter) == Store.Orders.Count)
                            //{
                            //    Order = new Order(portions, Client);
                            //    Store.Orders.Add(Order);
                            //    break;

                            //}
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
                    else
                    {
                        //TODO почему не добавляет 
                        //MessageBox.Show(Convert.ToString(Portion.Amount));
                        //int x = 
                        //Portion helpful = new Portion(Portion.Trip,x,Portion.OnSaleOrInFuture); 
                        //Portion = helpful;
                        Portion.Amount = Portion.Amount - Convert.ToInt32(HowMany.Value);


                    }
                    //MessageBox.Show(Convert.ToString(Portion.Amount));
                    foreach (Agency a in Store.Agencies)
                    {
                        if (a.Name == Portion.AgencyName)
                        {
                            foreach (Portion p in a.Portions)
                            {
                                if (p.LocationOfTrip == Portion.LocationOfTrip && p.OnSaleOrInFuture == Portion.OnSaleOrInFuture && p.PriceOfEachTrip == Portion.PriceOfEachTrip && p.Trip.Host == Portion.Trip.Host)
                                {
                                    p.Amount = Portion.Amount;
                                }
                            }
                        }
                    }
                    Store.Save();


                    if (DialogResult != DialogResult.OK)
                        return;


                }
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
            else if (Convert.ToInt32(HowMany.Value) == Portion.Amount)
            {
                MessageBox.Show("This is the maximum amount of trips available");
            }
            else
            {
                SomethingOrdered = false;
            }
        }
    }
}
