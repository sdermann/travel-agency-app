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
        List<Portion> port = new List<Portion>();
        List<Agency> GoodAgency = new List<Agency>();
        List<Portion> RightPortion = new List<Portion>();
        List<Portion> AllOrders = new List<Portion>();
        Client Client;
        Order Order;
        decimal Cost;
       

        public MainClientForm(VisitEasy store, Client client)
        {
            InitializeComponent();
            Store = store;
            Client = client;
            List<string> states = new List<string>
            {
                "Аргентина", "Бразилия", "Венесуэла", "Колумбия", "Чили"
            };
           Order = new Order(null, Client);


            // добавляем список элементовItems
            LocationsForClient.Items.AddRange(states);
            
            agencyBindingSource.DataSource = Store.Agencies;
            
            foreach (Agency agency in store.Agencies)
            {
                foreach (Portion p in agency.Portions)
                {
                   
                        port.Add(p);
                    
                }
                
            }
            foreach (Agency a in Store.Agencies)
            {
                foreach (Portion An in a.Portions)
                {
                    RightPortion.Add(An);
                }
            }
            foreach(Agency a in Store.Agencies)
            {
                GoodAgency.Add(a);
            }
            portionBindingSource.DataSource = port;

            if (store.Orders.Count > 0)
            {
                for(int i = 0; i < Store.Orders.Count;i++)
                {
                    if (Store.Orders[i].Client.Name == Client.Name)
                    {
                        foreach (Portion por in Store.Orders[i].Portions)
                        {
                            Order.Portions.Add(por);
                            Cost += (por.Trip.Price * por.Amount);
                        }
                    }
                }

                portionBindingSource1.DataSource = Order.Portions;
                portionBindingSource1.ResetBindings(false);
                TotalPrice.Text = Convert.ToString(Cost);
            }
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
                    if (GoodAgency[i].AmountOfLikes > GoodAgency[j].AmountOfLikes)
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
                        if (GoodAgency[i].AmountOfLikes < GoodAgency[j].AmountOfLikes)
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
            MessageBox.Show("Hello! \nYou can search for your favourite agency just by filling in its name (only letters) \nRate hearts will rate agencies by popularity(likes)");
        }

    

        private void nameOfagency_TextChanged(object sender, EventArgs e)
        {

            string str = nameOfagency.Text;
            GoodAgency = new List<Agency>();
            foreach( Agency a in Store.Agencies)
            {
                if (a.Name.IndexOf(str) > -1)
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello! \nYou can search for your favourite agency just by filling in its name (only letters) \nRate hearts will rate agencies by popularity(likes)");
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
            var openAgency = new ShowTrip(a,Client,Store);
            openAgency.Show();
            portionBindingSource1.ResetBindings(false);
        }

        private void DeleteButt_Click(object sender, EventArgs e)
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
                    //MessageBox.Show(Convert.ToString(n == Store.Orders[0].Portions.Count));
                    foreach(Order o in Store.Orders)
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
                                                        Store.Save();

                                                    }
                                                    else
                                                    {
                                                        po.Amount = PortionsComeBack.Amount;
                                                        PleaseBreakIt = true;
                                                        portionBindingSource1.DataSource = Order.Portions;
                                                        portionBindingSource1.ResetBindings(false);
                                                        o.Portions = Order.Portions;
                                                        Store.Save();
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

                    //HotAndFuture();
                }
            }
        }
        //send to admin

        private void Compilation_Click(object sender, EventArgs e)
        {
            //ordered = true;

        }
    }

 
}

