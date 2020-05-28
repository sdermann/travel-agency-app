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
    /*TODO: 10
     * 
     * 1валидация ввода для форм редактирования + краш колонки 
     * 2дизайн  
     * 3Тесты
    */
    public partial class MainForm : Form
    {

        static List<Portion> Trips = new List<Portion> { new Portion(new Trip("Spain", 500, "Rive", "TwoRooms", "Maria"), 2), new Portion(new Trip("USA", 5000, "Uni", "Room", "Gorge"), 9) };
        Agency CoralTravel = new Agency("CoralTravel", "Cool", Trips.Count, 0, Trips);
        VisitEasy store;
        Client client;

        public MainForm(ref VisitEasy easy)
        {
            InitializeComponent();
            store = easy;
            //MessageBox.Show(Convert.ToString(store.Orders[0].Portions.Count));
           
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
            List<Order> CompletedOrders = new List<Order>();
            foreach (Order order in store.Orders)
            {
    
                if (order.CheckedByAdmin == true && order.IsOrdered == true)
                {
                    CompletedOrders.Add(order);
                }
     

            }
            orderBindingSource1.DataSource = CompletedOrders;
            portionBindingSource1.DataSource = port;
            portionBindingSource2.DataSource = portHot;
            portionBindingSource1.ResetBindings(false);
            portionBindingSource2.ResetBindings(false);
            orderBindingSource1.ResetBindings(false);

        }


        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            store.Load();
            HotAndFuture();
            agencyBindingSource.ResetBindings(false);
            clientBindingSource.ResetBindings(false);
        }

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
                    break;
            }

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pf = new EditAgency();
            if (pf.ShowDialog() == DialogResult.OK)
            {
                store.AddAgency(pf.Agency);
                agencyBindingSource.ResetBindings(false);
                HotAndFuture();
                store.IsDirty = true;

                // select and scroll to the last row
                var lastIdx = agencyGridView1.Rows.Count - 1;
                agencyGridView1.Rows[lastIdx].Selected = true;
                agencyGridView1.FirstDisplayedScrollingRowIndex = lastIdx;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var toEdit = agencyGridView1.SelectedRows[0].DataBoundItem as Agency;
            var pf = new EditAgency(toEdit);

            if (pf.ShowDialog() == DialogResult.OK)
            {
                agencyBindingSource.ResetBindings(false);
                HotAndFuture();
                store.IsDirty = true;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
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
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            agencyBindingSource.DataSource = store.Agencies;
            clientBindingSource.DataSource = store.Clients;
            //orderBindingSource.DataSource = store.Orders;
            agencyBindingSource.ResetBindings(false);
            clientBindingSource.ResetBindings(false);
            portionBindingSource.ResetBindings(false);
            agencyGridView1.Rows[0].Selected = true;
            ClientsGridView.Rows[0].Selected = true;
        }

        private void ClientsGridView_SelectionChanged(object sender, EventArgs e)
        {
            {
                client = (Client)clientBindingSource.Current;
                //portions
                List<Order> orders = new List<Order>();
                //

                if (store.Orders.Count > 0)
                {
                    
                    for(int i = 0;i < store.Orders.Count; i++)
                    {
                        if (store.Orders[i].Client.Name == client.Name)
                        {
                            orders.Add(store.Orders[i]);
                        }
                    }
                    //MessageBox.Show(Convert.ToString());
                    orderBindingSource.DataSource = orders;
                    orderBindingSource.ResetBindings(false);
                }
            }
        }

        private void OrdersGridView_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void portionGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BanButt_Click(object sender, EventArgs e)
        {

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

        private void OperateOrder_Click(object sender, EventArgs e)
        {
            //TODO: Statistics
            var toProcess = OrdersGridView.SelectedRows[0].DataBoundItem as Order;
            var res = MessageBox.Show($"Process {toProcess.Client}`s order ?", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                store.Orders.Remove(toProcess);
                List<Order> orders = new List<Order>();
                if (store.Orders.Count > 1)
                {
                    for (int i = 1; i < store.Orders.Count; i++)
                    {
                        if (store.Orders[i].Client.Name == client.Name)
                        {
                            orders.Add(store.Orders[i]);
                        }
                    }
                    //MessageBox.Show(Convert.ToString());
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

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ViewOrder_Click(object sender, EventArgs e)
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
    }
}
