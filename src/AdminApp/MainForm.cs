using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Models;

namespace AdminApp
{
 


    public partial class MainForm : Form
    {

        VisitEasy store;
        Client client;

        public MainForm(ref VisitEasy easy)
        {
            InitializeComponent();
            store = easy;

           
            //store.FillTestData(5);

            List<Portion> port = new List<Portion>();
            foreach (Agency agency in store.Agencies)
            {
                foreach (Portion p in agency.Portions)
                {
                    if (p.OnSaleOrInFuture == "FutureTrip")
                    {
                        port.Add(p);
                    }
                }

            }
            List<Portion> portHot = new List<Portion>();
            foreach (Agency agency in store.Agencies)
            {
                foreach (Portion p in agency.Portions)
                {
                    if (p.OnSaleOrInFuture == "OnSale")
                    {
                        portHot.Add(p);
                    }
                }

            }
         
           
            portionBindingSource1.DataSource = port;
            portionBindingSource2.DataSource = portHot;
            portionBindingSource1.ResetBindings(false);
            portionBindingSource2.ResetBindings(false);

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            agencyBindingSource.DataSource = store.Agencies;
            clientBindingSource.DataSource = store.Clients;
            //orderBindingSource.DataSource = store.Orders;
          
            agencyBindingSource.ResetBindings(false);
            clientBindingSource.ResetBindings(false);
            portionBindingSource.ResetBindings(false);
            if (agencyGridView1.Rows.Count > 0)
            {
                agencyGridView1.Rows[0].Selected = true;
            }
            if (ClientsGridView.Rows.Count > 0)
            {
                ClientsGridView.Rows[0].Selected = true;
            }

        }


        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            store.Load();
            HotAndFuture();
            agencyBindingSource.ResetBindings(false);
            clientBindingSource.ResetBindings(false);
        }
        //To reset types OnSale and future trips.

        public void HotAndFuture()
        {
            List<Portion> port = new List<Portion>();
            foreach (Agency agency in store.Agencies)
            {
                foreach (Portion p in agency.Portions)
                {
                    if (p.OnSaleOrInFuture == "FutureTrip")
                    {
                        port.Add(p);
                    }
                }

            }
            List<Portion> portHot = new List<Portion>();
            foreach (Agency agency in store.Agencies)
            {
                foreach (Portion p in agency.Portions)
                {
                    if (p.OnSaleOrInFuture == "OnSale")
                    {
                        portHot.Add(p);
                    }
                }

            }
            portionBindingSource1.DataSource = port;
            portionBindingSource2.DataSource = portHot;
            portionBindingSource1.ResetBindings(false);
            portionBindingSource2.ResetBindings(false);
            
           
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!store.IsDirty)
            {
                Form CustomerAutor = Application.OpenForms[0];
                CustomerAutor.Left = this.Left;
                CustomerAutor.Top = this.Top;
                CustomerAutor.Show();
                return;
            }
            var res = MessageBox.Show("Save data before exit?", "", MessageBoxButtons.YesNoCancel);
            switch (res)
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    store.Save();
                    Form CustomerAutor = Application.OpenForms[0];
                    CustomerAutor.Left = this.Left;
                    CustomerAutor.Top = this.Top;
                    CustomerAutor.Show();
                    break;
                case DialogResult.No:
                    Form Customer = Application.OpenForms[0];
                    Customer.Left = this.Left;
                    Customer.Top = this.Top;
                    Customer.Show();
                    break;
            }

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pf = new EditAgency(store);
            if (pf.ShowDialog() == DialogResult.OK)
            {
                if (pf.Agency != null)
                {
                    foreach(Portion p in pf.Agency.Portions)
                    {
                        p.AgencyName = pf.Agency.Name;
                        pf.Agency.AmountOfTrips = pf.Agency.Portions.Count;
                    }
                    store.AddAgency(pf.Agency);
                    
                    agencyBindingSource.ResetBindings(false);
                    HotAndFuture();
                    store.IsDirty = true;
                    var lastIdx = agencyGridView1.Rows.Count - 1;
                    agencyGridView1.Rows[lastIdx].Selected = true;
                    agencyGridView1.FirstDisplayedScrollingRowIndex = lastIdx;
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (agencyGridView1.Rows.Count > 0)
            {
               
                var toEdit = agencyGridView1.SelectedRows[0].DataBoundItem as Agency;
                var pf = new EditAgency(toEdit, store);

                if (pf.ShowDialog() == DialogResult.OK)
                {
                    agencyBindingSource.ResetBindings(false);
                    HotAndFuture();
                    store.IsDirty = true;
                }
            }
            else
            {
                MessageBox.Show("Sorry, but there is no agencies to edit");
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (agencyGridView1.Rows.Count > 0)
            {
                var toDel = agencyGridView1.SelectedRows[0].DataBoundItem as Agency;
                var res = MessageBox.Show($"Delete {toDel.Name} ?", "", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    store.Agencies.Remove(toDel);
                    agencyBindingSource.ResetBindings(false);
                    HotAndFuture();
                    store.IsDirty = true;
                }
            }
            else
            {
                MessageBox.Show("Sorry, but there is no agencies to edit");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            store.Save();
        }

        private void agencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editToolStripMenuItem.Enabled =
            deleteToolStripMenuItem.Enabled =
            agencyGridView1.SelectedRows.Count > 0;
        }

        private void agencyGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (agencyGridView1.Rows.Count > 0)
            {
                Agency b = (Agency)agencyGridView1.CurrentRow.DataBoundItem;
                List<Portion> port = b.Portions;
                portionBindingSource.DataSource = port;
                portionBindingSource.ResetBindings(false);
                foreach (DataGridViewRow row in portionGridView.Rows)
                    for (int i = 0; i < port.Count; i++)
                    {
                        if (port[i].OnSaleOrInFuture == "OnSale")
                        {
                            portionGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 97, 97);

                        }
                        else if (port[i].OnSaleOrInFuture == "FutureTrip")
                        {
                            portionGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(125, 160, 255);
                        }
                        else
                        {
                            portionGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 250, 110);
                        }
                    }
            }
            else
            {
                MessageBox.Show("Be carefull! List of agencies is empty");
                List<Portion> port = new List<Portion>();
                portionBindingSource.DataSource = port;
                portionBindingSource.ResetBindings(false);
            }
        }

       
        private void ClientsGridView_SelectionChanged(object sender, EventArgs e)
        { 
            if (ClientsGridView.Rows.Count > 0)
            {

                client = (Client)clientBindingSource.Current;
                List<Order> orders = new List<Order>();
                if (client != null)
                {
                    if (store.Orders.Count > 0)
                    {

                        for (int i = 0; i < store.Orders.Count; i++)
                        {
                            if (store.Orders[i].Client.Name == client.Name && store.Orders[i].IsOrdered == true)
                            {
                                orders.Add(store.Orders[i]);
                            }
                            
                        }
                        if (orders.Count > 0)
                        {
                            orderBindingSource.DataSource = orders;
                            orderBindingSource.ResetBindings(false);
                            OrdersGridView.Rows[0].Selected = true;
                        }
                        else
                        {
                            orderBindingSource.DataSource = orders;
                            orderBindingSource.ResetBindings(false);
                        }

                    }
                }
                else
                {
                    orderBindingSource.DataSource = orders;
                    orderBindingSource.ResetBindings(false);
                }
            }
            else
            {
                MessageBox.Show("Be carefull! List of clients is empty(");
                List<Portion> port = new List<Portion>();
                clientBindingSource.DataSource = port;
                clientBindingSource.ResetBindings(false);
            }
        
        } 

        private void BanButt_Click(object sender, EventArgs e)
        {
           
            if (ClientsGridView.Rows.Count > 0)
            {
                for(int i = 0; i <  ClientsGridView.Rows.Count;i++)
                {
                    if(ClientsGridView.Rows[i].Selected == true)
                    {
                        break;
                    }
                    else if(i + 1 == ClientsGridView.Rows.Count)
                    {
                        ClientsGridView.Rows[0].Selected = true;
                    }
                }
             
                var toDel = ClientsGridView.SelectedRows[0].DataBoundItem as Client;
                var res = MessageBox.Show($"Delete {toDel.Name} ?", "", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    store.Clients.Remove(toDel);
                    clientBindingSource.ResetBindings(false);
                    //HotAndFuture();
                    store.IsDirty = true;
                }
            }
            else
            {
                MessageBox.Show("The list of clients is empty( Banning from app is impossible");
            }
        }

        private void OperateOrder_Click(object sender, EventArgs e)
        {
            if (OrdersGridView.Rows.Count > 0)
            {
               
                var toProcess = OrdersGridView.SelectedRows[0].DataBoundItem as Order;
                var res = MessageBox.Show($"Process {toProcess.Client}`s order ?", "", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    toProcess.CheckedByAdmin = true;
                    SaveCompletedOrders(toProcess);
                    foreach (Order o in store.Orders)
                    {
                        if (o.Client.Name == client.Name)
                        {
                            o.IsOrdered = false;
                        }
                    }
                    store.Orders.Remove(toProcess);
                    List<Order> orders = new List<Order>();
                    if (store.Orders.Count > 1)
                    {
                        for (int i = 1; i < store.Orders.Count; i++)
                        {
                            if (store.Orders[i].Client.Name == client.Name)
                            {
                                store.Orders[i].IsOrdered = false;
                                orders.Add(store.Orders[i]);
                            }
                        }

                        orderBindingSource.DataSource = orders;
                        orderBindingSource.ResetBindings(false);

                        store.IsDirty = true;
                    }
                    else
                    {
                        orderBindingSource.DataSource = orders;
                        orderBindingSource.ResetBindings(false);

                        store.IsDirty = true;
                    }
                }

            }
            else
            {
                MessageBox.Show("Sorry,there is nothing to operate(");
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dear, Admin!\nWe hope that you are willing to do your job" +
                "\nSo,you have to edit agencies and trips as soon as clients need it." +
                "\nBe careful and complete it fully!" +
                "\nYou can delete or add it too." +
                "\nFor your comfort you can see trips of the future(Future trips) and trips on sale(Hot Sale) on the following pages." +
                "\nYou can ban from this app those users,who don`t honor our policy." +
                "\nYou have to operate orders(Also you can see them)." +
                "\nGood luck!");
        }

        private void ViewOrder_Click(object sender, EventArgs e)
        {
            if (OrdersGridView.Rows.Count > 0)
            {
              
                var toSee = OrdersGridView.SelectedRows[0].DataBoundItem as Order;
                var pf = new SeeThisOrdercs(toSee);

                if (pf.ShowDialog() == DialogResult.OK)
                {
                    agencyBindingSource.ResetBindings(false);
                    HotAndFuture();
                    store.IsDirty = true;
                }
            }
            else
            {
                MessageBox.Show("There is nothing to see(");
            }
        }
        public void SaveCompletedOrders(Order order)
        {
            using (var wr = new StreamWriter("CompletedOrders.txt"))
            {
                wr.WriteLine("-------------------------------------------");
                wr.WriteLine();

                if (order.IsOrdered == true && order.CheckedByAdmin == true)
                    {
                        wr.WriteLine("Name: " + order.Client.Name);
                        wr.WriteLine("Date: " + order.DateTime);
                        wr.WriteLine(order.Portions.Count);
                        foreach (var p in order.Portions)
                        {
                            wr.WriteLine("Agency: " + p.AgencyName);
                            wr.WriteLine("Location: " + p.Trip.Location);
                            wr.WriteLine("Host: " + p.Trip.Host);
                            wr.WriteLine("Amount of Trips: " + p.Amount);
                            wr.WriteLine("Total price: " + p.Trip.Price * p.Amount);
                        wr.WriteLine("-------------------------------------------");
                        }
                    }
                wr.WriteLine("-------------------------------------------");
                wr.WriteLine();

            }
        }

      
    }
}
