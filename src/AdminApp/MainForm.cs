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
    public partial class MainForm : Form
    {

        static List<Portion> Trips = new List<Portion> { new Portion(new Trip("Spain", 500, "Rive", "TwoRooms", "Maria"), 2), new Portion(new Trip("USA", 5000, "Uni", "Room", "Gorge"), 9) };
        Agency CoralTravel = new Agency("CoralTravel", "Cool", Trips.Count, 0, Trips);
        VisitEasy store;
       
        public MainForm(ref VisitEasy easy)
        {
            InitializeComponent();
            store = easy;
          
            //store.FillTestData(5);
            agencyBindingSource.DataSource = store.Agencies;
            clientBindingSource.DataSource = store.Clients;
            orderBindingSource.DataSource = store.Orders;
            List<Portion> port = new List<Portion>();
            foreach(Agency agency  in store.Agencies)
            {
                foreach(Portion p in agency.Portions)
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
                    if (p.OnSaleOrInFuture == "HotSale")
                    {
                        portHot.Add(p);
                    }
                }

            }
            portionBindingSource1.DataSource = port;
            portionBindingSource2.DataSource = portHot;

            
        }


        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            store.Load();
            agencyBindingSource.ResetBindings(false);
            clientBindingSource.ResetBindings(false);
    
            portionBindingSource.ResetBindings(false);
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

            Agency b = (Agency)agencyGridView1.CurrentRow.DataBoundItem;
            List<Portion> port = b.Portions;
            portionBindingSource.DataSource = port;
            portionBindingSource.ResetBindings(false);
            foreach (DataGridViewRow row in portionGridView.Rows)
                for (int i = 0; i <  port.Count;i++)
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            agencyGridView1.Rows[0].Selected = true;
            ClientsGridView.Rows[0].Selected = true;
        }

        private void ClientsGridView_SelectionChanged(object sender, EventArgs e)
        {
            {
                var client = (Client)clientBindingSource.Current;
                var orders = store.Orders.Where(o => o.Client == client);
                orderBindingSource.DataSource = orders;
                orderBindingSource.ResetBindings(false);
            }
        }
        private void addTrip_Click(object sender, EventArgs e)
        {
            var toProcess = OrdersGridView.SelectedRows[0].DataBoundItem as Order;
            var res = MessageBox.Show($"Process {toProcess.Client}`s order ?", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                store.Orders.Remove(toProcess);
                orderBindingSource.ResetBindings(false);
                store.IsDirty = true;
            }
        }

        private void OrdersGridView_SelectionChanged(object sender, EventArgs e)
        {
          
        }

        private void portionGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
