namespace AdminApp
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
            this.SavePortion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfTrips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AmountOfTrips
            // 
            this.AmountOfTrips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.AmountOfTrips.Location = new System.Drawing.Point(19, 167);
            this.AmountOfTrips.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.AmountOfTrips.Name = "AmountOfTrips";
            this.AmountOfTrips.Size = new System.Drawing.Size(120, 22);
            this.AmountOfTrips.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welcome";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(14, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "To the Portion-editor! Be creative - be first)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(15, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount Of available Trips";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tripPicBox
            // 
            this.tripPicBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.tripPicBox.Location = new System.Drawing.Point(12, 255);
            this.tripPicBox.Name = "tripPicBox";
            this.tripPicBox.Size = new System.Drawing.Size(188, 171);
            this.tripPicBox.TabIndex = 7;
            this.tripPicBox.TabStop = false;
            this.tripPicBox.Click += new System.EventHandler(this.tripPicBox_Click);
            // 
            // LocationOfTrip
            // 
            this.LocationOfTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.LocationOfTrip.Location = new System.Drawing.Point(313, 167);
            this.LocationOfTrip.Name = "LocationOfTrip";
            this.LocationOfTrip.Size = new System.Drawing.Size(169, 22);
            this.LocationOfTrip.TabIndex = 8;
            this.LocationOfTrip.Text = "Location";
            this.LocationOfTrip.Wrap = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(309, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price for one person, $";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(309, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Additional Service:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(309, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Choose location:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PriceBox
            // 
            this.PriceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.PriceBox.Location = new System.Drawing.Point(313, 246);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(169, 22);
            this.PriceBox.TabIndex = 12;
            // 
            // ServiceBox
            // 
            this.ServiceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.ServiceBox.Location = new System.Drawing.Point(313, 338);
            this.ServiceBox.Multiline = true;
            this.ServiceBox.Name = "ServiceBox";
            this.ServiceBox.Size = new System.Drawing.Size(169, 88);
            this.ServiceBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(568, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Choose accomodation :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(568, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Choose Host:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AccomodationBox
            // 
            this.AccomodationBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.AccomodationBox.Location = new System.Drawing.Point(572, 108);
            this.AccomodationBox.Name = "AccomodationBox";
            this.AccomodationBox.Size = new System.Drawing.Size(206, 22);
            this.AccomodationBox.TabIndex = 16;
            // 
            // HostBox
            // 
            this.HostBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.HostBox.Location = new System.Drawing.Point(572, 211);
            this.HostBox.Name = "HostBox";
            this.HostBox.Size = new System.Drawing.Size(206, 22);
            this.HostBox.TabIndex = 17;
            // 
            // SavePortion
            // 
            this.SavePortion.AccessibleName = "";
            this.SavePortion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SavePortion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.SavePortion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SavePortion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavePortion.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold);
            this.SavePortion.ForeColor = System.Drawing.Color.Olive;
            this.SavePortion.Location = new System.Drawing.Point(647, 382);
            this.SavePortion.Margin = new System.Windows.Forms.Padding(4);
            this.SavePortion.Name = "SavePortion";
            this.SavePortion.Size = new System.Drawing.Size(131, 44);
            this.SavePortion.TabIndex = 24;
            this.SavePortion.Text = "Save";
            this.SavePortion.UseVisualStyleBackColor = false;
            this.SavePortion.Click += new System.EventHandler(this.SavePortion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(572, 255);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Location = new System.Drawing.Point(15, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 24);
            this.label9.TabIndex = 26;
            this.label9.Text = "Choose image:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EditPortion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "EditPortion";
            this.Text = "Edit Portion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditPortion_FormClosing);
            this.Load += new System.EventHandler(this.EditPortion_Load);
            this.TextChanged += new System.EventHandler(this.EditPortion_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfTrips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button SavePortion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}