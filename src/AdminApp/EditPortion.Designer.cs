﻿namespace AdminApp
{
    partial class EditPortion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPortion));
            this.AmountOfTrips = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tripPicBox = new System.Windows.Forms.PictureBox();
            this.LocationOfTrip = new System.Windows.Forms.DomainUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.ServiceBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AccomodationBox = new System.Windows.Forms.TextBox();
            this.HostBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.OnSaleOrFutureUpDown = new System.Windows.Forms.DomainUpDown();
            this.SavePortion = new System.Windows.Forms.Button();
            this.HostPic = new System.Windows.Forms.PictureBox();
            this.CheckButt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfTrips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HostPic)).BeginInit();
            this.SuspendLayout();
            // 
            // AmountOfTrips
            // 
            this.AmountOfTrips.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountOfTrips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.AmountOfTrips.Location = new System.Drawing.Point(50, 168);
            this.AmountOfTrips.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.AmountOfTrips.Name = "AmountOfTrips";
            this.AmountOfTrips.ReadOnly = true;
            this.AmountOfTrips.Size = new System.Drawing.Size(120, 22);
            this.AmountOfTrips.TabIndex = 0;
            this.AmountOfTrips.ValueChanged += new System.EventHandler(this.AmountOfTrips_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(48, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welcome";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(60, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "To the Portion-editor! Be creative - be first)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(46, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount Of available Trips";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tripPicBox
            // 
            this.tripPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tripPicBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.tripPicBox.Location = new System.Drawing.Point(40, 254);
            this.tripPicBox.Name = "tripPicBox";
            this.tripPicBox.Size = new System.Drawing.Size(188, 171);
            this.tripPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tripPicBox.TabIndex = 7;
            this.tripPicBox.TabStop = false;
            this.tripPicBox.Click += new System.EventHandler(this.tripPicBox_Click);
            // 
            // LocationOfTrip
            // 
            this.LocationOfTrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LocationOfTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.LocationOfTrip.Location = new System.Drawing.Point(334, 122);
            this.LocationOfTrip.Name = "LocationOfTrip";
            this.LocationOfTrip.Size = new System.Drawing.Size(178, 22);
            this.LocationOfTrip.TabIndex = 8;
            this.LocationOfTrip.Text = "Location";
            this.LocationOfTrip.Wrap = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(330, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price for one person, $";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(330, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Additional Service:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(330, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Choose location:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PriceBox
            // 
            this.PriceBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.PriceBox.Location = new System.Drawing.Point(334, 190);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(178, 22);
            this.PriceBox.TabIndex = 12;
            // 
            // ServiceBox
            // 
            this.ServiceBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ServiceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.ServiceBox.Location = new System.Drawing.Point(334, 337);
            this.ServiceBox.Multiline = true;
            this.ServiceBox.Name = "ServiceBox";
            this.ServiceBox.Size = new System.Drawing.Size(178, 88);
            this.ServiceBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(330, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Choose accomodation :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(609, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Choose Host:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AccomodationBox
            // 
            this.AccomodationBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AccomodationBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.AccomodationBox.Location = new System.Drawing.Point(334, 255);
            this.AccomodationBox.Name = "AccomodationBox";
            this.AccomodationBox.Size = new System.Drawing.Size(178, 22);
            this.AccomodationBox.TabIndex = 16;
            // 
            // HostBox
            // 
            this.HostBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HostBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.HostBox.Location = new System.Drawing.Point(613, 115);
            this.HostBox.Name = "HostBox";
            this.HostBox.Size = new System.Drawing.Size(206, 22);
            this.HostBox.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(538, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Location = new System.Drawing.Point(46, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 24);
            this.label9.TabIndex = 26;
            this.label9.Text = "Choose image:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Image files  (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfi" +
    "f; *.png";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(783, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Location = new System.Drawing.Point(620, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(235, 24);
            this.label10.TabIndex = 28;
            this.label10.Text = "Is it OnSale or Future Trip?";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OnSaleOrFutureUpDown
            // 
            this.OnSaleOrFutureUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OnSaleOrFutureUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.OnSaleOrFutureUpDown.Location = new System.Drawing.Point(650, 338);
            this.OnSaleOrFutureUpDown.Name = "OnSaleOrFutureUpDown";
            this.OnSaleOrFutureUpDown.Size = new System.Drawing.Size(169, 22);
            this.OnSaleOrFutureUpDown.TabIndex = 29;
            this.OnSaleOrFutureUpDown.Text = "None";
            this.OnSaleOrFutureUpDown.Wrap = true;
            // 
            // SavePortion
            // 
            this.SavePortion.AccessibleName = "";
            this.SavePortion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SavePortion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.SavePortion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SavePortion.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SavePortion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavePortion.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold);
            this.SavePortion.ForeColor = System.Drawing.Color.Olive;
            this.SavePortion.Location = new System.Drawing.Point(722, 382);
            this.SavePortion.Margin = new System.Windows.Forms.Padding(4);
            this.SavePortion.Name = "SavePortion";
            this.SavePortion.Size = new System.Drawing.Size(97, 44);
            this.SavePortion.TabIndex = 24;
            this.SavePortion.Text = "Finish";
            this.SavePortion.UseVisualStyleBackColor = false;
            this.SavePortion.Click += new System.EventHandler(this.SavePortion_Click);
            // 
            // HostPic
            // 
            this.HostPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HostPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.HostPic.Location = new System.Drawing.Point(613, 143);
            this.HostPic.Name = "HostPic";
            this.HostPic.Size = new System.Drawing.Size(206, 124);
            this.HostPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HostPic.TabIndex = 30;
            this.HostPic.TabStop = false;
            this.HostPic.Click += new System.EventHandler(this.HostPic_Click);
            // 
            // CheckButt
            // 
            this.CheckButt.AccessibleName = "";
            this.CheckButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.CheckButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckButt.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold);
            this.CheckButt.ForeColor = System.Drawing.Color.Olive;
            this.CheckButt.Location = new System.Drawing.Point(588, 382);
            this.CheckButt.Margin = new System.Windows.Forms.Padding(4);
            this.CheckButt.Name = "CheckButt";
            this.CheckButt.Size = new System.Drawing.Size(122, 44);
            this.CheckButt.TabIndex = 31;
            this.CheckButt.Text = "Check";
            this.CheckButt.UseVisualStyleBackColor = false;
            this.CheckButt.Click += new System.EventHandler(this.CheckButt_Click);
            // 
            // EditPortion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.CheckButt);
            this.Controls.Add(this.HostPic);
            this.Controls.Add(this.OnSaleOrFutureUpDown);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SavePortion);
            this.Controls.Add(this.HostBox);
            this.Controls.Add(this.AccomodationBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ServiceBox);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LocationOfTrip);
            this.Controls.Add(this.tripPicBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AmountOfTrips);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "EditPortion";
            this.Text = "Edit Portion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditPortion_FormClosing);
            this.Load += new System.EventHandler(this.EditPortion_Load);
            this.TextChanged += new System.EventHandler(this.EditPortion_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfTrips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HostPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown AmountOfTrips;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox tripPicBox;
        private System.Windows.Forms.DomainUpDown LocationOfTrip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.TextBox ServiceBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AccomodationBox;
        private System.Windows.Forms.TextBox HostBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DomainUpDown OnSaleOrFutureUpDown;
        private System.Windows.Forms.Button SavePortion;
        private System.Windows.Forms.PictureBox HostPic;
        private System.Windows.Forms.Button CheckButt;
    }
}