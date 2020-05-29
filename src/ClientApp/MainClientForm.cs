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
    /*TODO: 6


     * 3цвета по скидкам



     * 1колонки 
     * 2дизайн
  
 
     */
    public partial class MainClientForm : Form
    {
        VisitEasy Store;
        List<Portion> port = new List<Portion>();
        List<Agency> GoodAgency = new List<Agency>();
        List<Portion> RightPortion = new List<Portion>();
        Client Client;
        Order Order;
        decimal Cost;
       

        public MainClientForm(VisitEasy store, Client client)
        {
            InitializeComponent();
            Store = store;
            Client = client;
            Cost = 0;
            List<string> states = new List<string>
            {
                "Аргентина", "Бразилия", "Венесуэла", "Колумбия", "Чили"
            };


            // добавляем список элементовItems
            LocationsForClient.Items.AddRange(states);
            



            foreach (Agency a in Store.Agencies)
            {
                foreach (Portion An in a.Portions)
                {
                    if(An.Amount > 0)
                         RightPortion.Add(An);
                }
            }
            foreach(Agency a in Store.Agencies)
            {
                if(a.Portions.Count > 0)
                    GoodAgency.Add(a);
            }
            ResetAgencies();
            ResetOrder();
            ResetTrips();
            

        }


        private void MainClientForm_Load(object sender, EventArgs e)
        {
            Store.Load();

            agencyBindingSource.ResetBindings(false);
            portionBindingSource.ResetBindings(false);
            portionBindingSource1.ResetBindings(false);
            if (OrdersGridView.Rows.Count > 0)
            {
                OrdersGridView.Rows[0].Selected = true;
            }
            if (TripsForClientGridView.Rows.Count > 0)
            {
                TripsForClientGridView.Rows[0].Selected = true;
            }
            if (AgencyView.Rows.Count > 0)
            {
                AgencyView.Rows[0].Selected = true;
            }
        }

     
        private void Unrate_Click(object sender, EventArgs e)
        {
            Agency temp;
            for (int i = 0; i < GoodAgency.Count - 1; i++)
            {
                for (int j = i + 1; j < GoodAgency.Count; j++)
                {
                    if (GoodAgency[i].AmountOfLikes > GoodAgency[j].AmountOfLikes && GoodAgency[i].Portions.Count > 0 && GoodAgency[j].Portions.Count > 0)
                    {
                        temp = GoodAgency[i];
                        GoodAgency[i] = GoodAgency[j];
                        GoodAgency[j] = temp;
                    }
                }
            }
            agencyBindingSource.DataSource = GoodAgency;
            agencyBindingSource.ResetBindings(false);
        }

        private void Rate_Click(object sender, EventArgs e)
        {
                Agency temp;
                for (int i = 0; i < GoodAgency.Count - 1; i++)
                {
                    for (int j = i + 1; j < GoodAgency.Count; j++)
                    {
                        if (GoodAgency[i].AmountOfLikes < GoodAgency[j].AmountOfLikes && GoodAgency[i].Portions.Count > 0 && GoodAgency[j].Portions.Count > 0)
                    {
                            temp = GoodAgency[i];
                            GoodAgency[i] = GoodAgency[j];
                            GoodAgency[j] = temp;
                        }
                    }
                }
                agencyBindingSource.DataSource = GoodAgency;
                agencyBindingSource.ResetBindings(false);
        }

      

        private void Question_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Hello! \nYou can search for your favourite agency just by filling in its name (only letters) \nRate hearts will rate agencies by popularity(likes)\nUndo to start again");
        }

    

        private void nameOfagency_TextChanged(object sender, EventArgs e)
        {

                if(nameOfagency.Text.Length > 15)
                {
                    nameOfagency.BackColor = Color.MediumSeaGreen;
                    MessageBox.Show("Too long name");
                    nameOfagency.BackColor = Color.Wheat;
                    nameOfagency.Text = string.Empty;
                }
                else
                {
                    for (int i = 0; i < nameOfagency.Text.Length; i++)
                    {
                        if (nameOfagency.Text[i] >= '0' && nameOfagency.Text[i] <= '9')
                        {
                            
                            nameOfagency.BackColor = Color.MediumSeaGreen;
                            MessageBox.Show("Name contains numbers");
                            nameOfagency.BackColor = Color.Wheat;
                            nameOfagency.Text = string.Empty;
                            break;
                        }
                    }
                }
            
            string str = nameOfagency.Text;
            GoodAgency = new List<Agency>();
            foreach( Agency a in Store.Agencies)
            {
                if (a.Name.IndexOf(str) > -1 && a.Portions.Count > 0)
                {
                    // Вхождения найдены
                    GoodAgency.Add(a);
                }
                else
                {
                    // Вхождения не найдены
                }
            }
            agencyBindingSource.DataSource = GoodAgency;
            if(GoodAgency.Count == 0)
            {
                MessageBox.Show("Sorry,there is no agency with such a name");
            }
            agencyBindingSource.ResetBindings(false);
         
        }

     

        private void Undo_Butt_Click(object sender, EventArgs e)
        {
            nameOfagency.Text = string.Empty;
            agencyBindingSource.DataSource = Store.Agencies;
            agencyBindingSource.ResetBindings(false);
        }

        private void LessPrice_Click(object sender, EventArgs e)
        {     
                // сортировка

                Portion  temp;
                for (int i = 0; i < RightPortion.Count - 1; i++)
                {
                    for (int j = i + 1; j < RightPortion.Count; j++)
                    {
                        if (RightPortion[i].Trip.Price > RightPortion[j].Trip.Price)
                        {
                            temp = RightPortion[i];
                            RightPortion[i] = RightPortion[j];
                            RightPortion[j] = temp;
                        }
                    }
                }
                portionBindingSource.DataSource = RightPortion;
                portionBindingSource.ResetBindings(false);
        }

        private void BiggerPrice_Click(object sender, EventArgs e)
        {
            Portion temp;
            for (int i = 0; i < RightPortion.Count - 1; i++)
            {
                for (int j = i + 1; j < RightPortion.Count; j++)
                {
                    if (RightPortion[i].Trip.Price < RightPortion[j].Trip.Price)
                    {
                        temp = RightPortion[i];
                        RightPortion[i] = RightPortion[j];
                        RightPortion[j] = temp;
                    }
                }
            }
            portionBindingSource.DataSource = RightPortion;
            portionBindingSource.ResetBindings(false);
        }



        private void More_Butt_Click(object sender, EventArgs e)
        {
            // сортировка

            Portion temp;
            for (int i = 0; i < RightPortion.Count - 1; i++)
            {
                for (int j = i + 1; j < RightPortion.Count; j++)
                {
                    if (RightPortion[i].Amount < RightPortion[j].Amount)
                    {
                        temp = RightPortion[i];
                        RightPortion[i] = RightPortion[j];
                        RightPortion[j] = temp;
                    }
                }
            }
            portionBindingSource.DataSource = RightPortion;
            portionBindingSource.ResetBindings(false);
        }

        private void Less_Butt_Click(object sender, EventArgs e)
        {
            // сортировка

            Portion temp;
            for (int i = 0; i < RightPortion.Count - 1; i++)
            {
                for (int j = i + 1; j < RightPortion.Count; j++)
                {
                    if (RightPortion[i].Amount > RightPortion[j].Amount)
                    {
                        temp = RightPortion[i];
                        RightPortion[i] = RightPortion[j];
                        RightPortion[j] = temp;
                    }
                }
            }
            portionBindingSource.DataSource = RightPortion;
            portionBindingSource.ResetBindings(false);
        }

        private void UndoButtForTrips_Click(object sender, EventArgs e)
        {
            RightPortion = new List<Portion>();
            foreach (Agency a in Store.Agencies)
            {
                foreach (Portion An in a.Portions)
                {
                    RightPortion.Add(An);
                }
            }
            portionBindingSource.DataSource = RightPortion;
            portionBindingSource.ResetBindings(false);
        }


        private void LocationsForClient_SelectedItemChanged(object sender, EventArgs e)
        {
            RightPortion = new List<Portion>();
            foreach (Agency a in Store.Agencies)
            {
                foreach (Portion p in a.Portions)
                {
                    if (p.LocationOfTrip == LocationsForClient.Text)
                    {
                        RightPortion.Add(p);
                    }
                }
            }
            portionBindingSource.DataSource = RightPortion;
            portionBindingSource.ResetBindings(false);
        }


        private void AgencyView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Agency a = (Agency)AgencyView.CurrentRow.DataBoundItem;
            var openAgency = new ShowAgency(a,Client,Store);
            openAgency.Show();
        }

        private void TripsForClientGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Portion a = (Portion)TripsForClientGridView.CurrentRow.DataBoundItem;
            var openAgency = new ShowTrip(a, Client,Store);
            if (openAgency.ShowDialog() == DialogResult.OK)
            {
   
                portionBindingSource.ResetBindings(false);
               
 

            }
            ResetOrder();
            ResetAgencies();

           
        }

      

        private void Compilation_Click(object sender, EventArgs e)
        {
            foreach (Order o in Store.Orders)
            {
                if(Order.Client.Name == Client.Name)
                {
                    Order.IsOrdered = true;
                }
            }

        }

        private void MainClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("Do you want to exit from the app?", "", MessageBoxButtons.OKCancel);
            switch (res)
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.OK:
                    Form CustomerAutor = Application.OpenForms[0];
                    CustomerAutor.Left = this.Left;
                    CustomerAutor.Top = this.Top;
                    CustomerAutor.Show();
                    break;
            }
        }
        private void ResetOrder()
        {
            Order = new Order(null,Client);
            Cost = 0;
            if (Store.Orders.Count > 0)
            {
               
                for (int i = 0; i < Store.Orders.Count; i++)
                {
                    if (Store.Orders[i].Client.Name == Client.Name)
                    {
                        
                        Order = new Order(Store.Orders[i].Portions,Client, Store.Orders[i].DateTime);
                        foreach(Portion p in Store.Orders[i].Portions)
                        {
                            Cost += p.Amount * p.Trip.Price;
                        }
                        TotalPrice.Text = Convert.ToString(Cost);
                    }
                }
                
            }
            else
            {
                TotalPrice.Text = Convert.ToString(Cost);
            }

            portionBindingSource1.DataSource = Order.Portions;
            portionBindingSource1.ResetBindings(false);
            
          
        }
        private void ResetTrips()
        {
            port = new List<Portion>();
            foreach (Agency agency in Store.Agencies)
            {
                foreach (Portion p in agency.Portions)
                {
                    if (p.Amount > 0)
                        port.Add(p);

                }

            }
           
            portionBindingSource.DataSource = port;
            portionBindingSource.ResetBindings(false);
            
            foreach (DataGridViewRow row in TripsForClientGridView.Rows)
            {
                for (int i = 0; i < port.Count; i++)
                {
                    if (port[i].OnSaleOrInFuture == "OnSale")
                    {
                        TripsForClientGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 97, 97);

                    }
                    else if (port[i].OnSaleOrInFuture == "FutureTrip")
                    {
                        TripsForClientGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(125, 160, 255);
                    }
                    else
                    {
                        TripsForClientGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 250, 110);
                    }
                }
            }
           

        }
        private void ResetAgencies()
        {
           
            List <Agency> agencies= new List<Agency>();
            foreach(Agency a in Store.Agencies)
            {
                if(a.Portions.Count != 0)
                {
                    agencies.Add(a);
                }
            }

            agencyBindingSource.DataSource = agencies;
            agencyBindingSource.ResetBindings(false);
        }

     

        private void DeletePortFromOrder_Click(object sender, EventArgs e)
        {
            if (OrdersGridView.Rows.Count != 0)
            {
                bool PleaseBreakIt = false;
                var toDel = OrdersGridView.SelectedRows[0].DataBoundItem as Portion;
                int count = 0;
                //int n = 2;
                var res = MessageBox.Show($"Delete selected trip to the {toDel.Trip.Location} from your Basket ?(", "", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    Portion PortionsComeBack = new Portion();
                    Order.Portions = new List<Portion>();

                    foreach (Order o in Store.Orders)
                    {
                        if (o.Client.Name == Client.Name) // needed order of exact client
                        {
                            foreach (Portion p in o.Portions) //to delete only one
                            {
                                if (p.AgencyName != toDel.AgencyName || p.Trip.Location != toDel.Trip.Location || p.Trip.Price != toDel.Trip.Price || p.Amount != toDel.Amount)
                                {
                                    Order.Portions.Add(p);  //save all except one toDel
                                    count += 1;
                                }
                                else
                                {
                                    PortionsComeBack = p; //returned one
                                    count += 1;
                                }
                                if (count == o.Portions.Count)
                                {
                                    foreach (Agency a in Store.Agencies) //agency
                                    {
                                        if (a.Name == PortionsComeBack.AgencyName) //neededone
                                        {
                                            foreach (Portion po in a.Portions)
                                            {
                                                if (po.LocationOfTrip == PortionsComeBack.LocationOfTrip && po.PriceOfEachTrip == PortionsComeBack.PriceOfEachTrip)//needed portion
                                                {
                                                    if (po.Amount > 0)
                                                    {
                                                        po.Amount += PortionsComeBack.Amount;
                                                        PleaseBreakIt = true;
                                                        portionBindingSource1.DataSource = Order.Portions;
                                                        portionBindingSource1.ResetBindings(false);
                                                        o.Portions = Order.Portions;


                                                    }
                                                    else
                                                    {
                                                        po.Amount = PortionsComeBack.Amount;
                                                        PleaseBreakIt = true;
                                                        portionBindingSource1.DataSource = Order.Portions;
                                                        portionBindingSource1.ResetBindings(false);
                                                        o.Portions = Order.Portions;

                                                    }
                                                }
                                                if (PleaseBreakIt == true)
                                                {
                                                    break;
                                                }
                                            }
                                        }
                                        if (PleaseBreakIt == true)
                                        {
                                            break;
                                        }
                                    }
                                }

                            }
                            if (PleaseBreakIt == true)
                            {
                                break;
                            }



                        }
                        if (PleaseBreakIt == true)
                        {
                            break;
                        }
                    }
                    if (Store.Orders.Count != 0)
                    {
                        int x = Store.Orders.Count - 1;

                        for (int i = x; i >= 0; i--)
                        {
                            if (Store.Orders[i].Portions.Count == 0)
                            {
                                Store.Orders.Remove(Store.Orders[i]);
                            }

                        }
                    }

                    Store.Save();
                    ResetOrder();
                    ResetTrips();
                    //HotAndFuture();
                }
            }
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Hello! \nPress wallet for trips with lower price\nPress money for trips with higher price\nChoose location by scrolling up and down\nSearch by available amount of trips\nUndo to start again");
        }

        private void pictureBox14_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Hello! \nThis is your personal basket)\nPress Delete to remove one selected portion of trip\nPress Complete to send request to the Admin\nWe wish you to have the best trip ever with VisitEasy");
        }

        private void TripsForClientGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in TripsForClientGridView.Rows)
            {
                for (int i = 0; i < port.Count; i++)
                {
                    if (port[i].OnSaleOrInFuture == "OnSale")
                    {
                        TripsForClientGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 97, 97);

                    }
                    else if (port[i].OnSaleOrInFuture == "FutureTrip")
                    {
                        TripsForClientGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(125, 160, 255);
                    }
                    else
                    {
                        TripsForClientGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 250, 110);
                    }
                }
            }
        }

        private void OrdersGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in OrdersGridView.Rows)
            {
                for (int i = 0; i < Order.Portions.Count; i++)
                {
                    if (Order.Portions[i].OnSaleOrInFuture == "OnSale")
                    {
                        OrdersGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 97, 97);

                    }
                    else if (Order.Portions[i].OnSaleOrInFuture == "FutureTrip")
                    {
                        OrdersGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(125, 160, 255);
                    }
                    else
                    {
                        OrdersGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 250, 110);
                    }
                }
            }
        }
    }

 
}

