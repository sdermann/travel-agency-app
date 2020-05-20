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
    public partial class EditAgency : Form
    {
        public Agency Agency { set; get; }
        public EditAgency()
        {
            InitializeComponent();
        }
        public EditAgency(Agency agency)
        {
            Agency = agency;//Product = product;
            NameBox.Text = agency.Name;//nameBox.Text = product.Name;
            DescriptionBox.Text = agency.Description;//unitBox.Text = product.Unit;
            //priceBox.Value = product.Price;
            //pictureBox.Image = product.Image;
        }
    }
}
