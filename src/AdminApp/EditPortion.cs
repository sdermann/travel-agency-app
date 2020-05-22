﻿using System;
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
    public partial class EditPortion : Form
    {
        public Portion Portion { set; get; }
        public EditPortion()
        {
            InitializeComponent();
        }
        public EditPortion(Portion port) :this()
        {
            Portion = port;
            AmountOfTrips.Value = port.Amount;
            LocationOfTrip.Text = port.Trip.Location;
            PriceBox.Text = Convert.ToString(port.Trip.Price);
            ServiceBox.Text = port.Trip.AdditionalService;
            AccomodationBox.Text = port.Trip.Accomodation;
            HostBox.Text = port.Trip.Host;
            tripPicBox.Image = port.Trip.Image;
        }

        private void tripPicBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tripPicBox.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void EditPortion_TextChanged(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.White;
        }


        private void RequiredValidate(Control c, FormClosingEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(c.Text))
            {
                c.BackColor = Color.MediumSeaGreen;
                e.Cancel = true;
            }
        }

        private void EditPortion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
                return;
            RequiredValidate(LocationOfTrip, e);
            RequiredValidate(PriceBox, e);
            RequiredValidate(ServiceBox, e);
            RequiredValidate(AccomodationBox, e);
        }

        private void EditPortion_Load(object sender, EventArgs e)
        {

        }

        private void SavePortion_Click(object sender, EventArgs e)
        {
            if (Portion == null)
            {
                Portion = new Portion();
            }
            Portion.Amount = (int)AmountOfTrips.Value;
            Portion.Trip.Location = LocationOfTrip.Text;
            Portion.Trip.Price = Convert.ToInt32(PriceBox.Text);
            Portion.Trip.AdditionalService = ServiceBox.Text;
            Portion.Trip.Accomodation = AccomodationBox.Text;
            Portion.Trip.Host = HostBox.Text;
            Portion.Trip.Image = tripPicBox.Image; 
   
        }

        //        private void EditAgency_Load(object sender, EventArgs e)
        //        {
        //            tripGridView.Rows[0].Selected = true;
        //        }
        //    }
        //}

    }
}