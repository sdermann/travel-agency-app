using TravelAgency.Models;
using TravelAgency.DAl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class Form1 : Form
    {
        VisitEasy store;

        public Form1()
        {
            InitializeComponent();
            store = new VisitEasy();
            store.FillTestData(100);
            Text = store.Agencies[0].Portions[0].Trip.Location;
        }
    }
}
