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
    public partial class SeeThisOrdercs : Form
    {
        List<Portion> OrderedPortions;
        Order Order;

        public SeeThisOrdercs(Order order)
        {
            InitializeComponent();
            Order = order;
        }

        private void SeeThisOrdercs_Load(object sender, EventArgs e)
        {
            int count = 0;
            OrderedPortions = new List<Portion>();
            foreach(Portion p in Order.Portions)
            {
                OrderedPortions.Add(p);
                count += (int)(p.Amount * p.Trip.Price);
            }
            portionBindingSource.DataSource = OrderedPortions;
            portionBindingSource.ResetBindings(false);

            NameOfClient.Text = Order.Client.Name;
            EmailOfClient.Text = Order.Client.Email;
            PriceOfOrder.Text = Convert.ToString(count);

        }

        private void SeeThisOrdercs_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("Exit from order?", "", MessageBoxButtons.OKCancel);
            switch (res)
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.OK:
                    break;
            }
        }
    }
}
