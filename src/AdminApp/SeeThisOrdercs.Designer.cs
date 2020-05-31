namespace AdminApp
{
    partial class SeeThisOrdercs
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeeThisOrdercs));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameOfClient = new System.Windows.Forms.TextBox();
            this.EmailOfClient = new System.Windows.Forms.TextBox();
            this.ViewTrip = new System.Windows.Forms.DataGridView();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onSaleOrInFutureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agencyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationOfTripDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceOfEachTripDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceOfOrder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewTrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(270, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NameOfClient
            // 
            this.NameOfClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.NameOfClient.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NameOfClient.Location = new System.Drawing.Point(33, 99);
            this.NameOfClient.Name = "NameOfClient";
            this.NameOfClient.ReadOnly = true;
            this.NameOfClient.Size = new System.Drawing.Size(206, 22);
            this.NameOfClient.TabIndex = 18;
            // 
            // EmailOfClient
            // 
            this.EmailOfClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.EmailOfClient.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.EmailOfClient.Location = new System.Drawing.Point(33, 239);
            this.EmailOfClient.Name = "EmailOfClient";
            this.EmailOfClient.ReadOnly = true;
            this.EmailOfClient.Size = new System.Drawing.Size(206, 22);
            this.EmailOfClient.TabIndex = 19;
            // 
            // ViewTrip
            // 
            this.ViewTrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewTrip.AutoGenerateColumns = false;
            this.ViewTrip.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.ViewTrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewTrip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.amountDataGridViewTextBoxColumn,
            this.onSaleOrInFutureDataGridViewTextBoxColumn,
            this.agencyNameDataGridViewTextBoxColumn,
            this.locationOfTripDataGridViewTextBoxColumn,
            this.priceOfEachTripDataGridViewTextBoxColumn});
            this.ViewTrip.DataSource = this.portionBindingSource;
            this.ViewTrip.Location = new System.Drawing.Point(467, 64);
            this.ViewTrip.Name = "ViewTrip";
            this.ViewTrip.ReadOnly = true;
            this.ViewTrip.RowHeadersWidth = 51;
            this.ViewTrip.RowTemplate.Height = 24;
            this.ViewTrip.Size = new System.Drawing.Size(321, 363);
            this.ViewTrip.TabIndex = 20;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // onSaleOrInFutureDataGridViewTextBoxColumn
            // 
            this.onSaleOrInFutureDataGridViewTextBoxColumn.DataPropertyName = "OnSaleOrInFuture";
            this.onSaleOrInFutureDataGridViewTextBoxColumn.HeaderText = "OnSaleOrInFuture";
            this.onSaleOrInFutureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.onSaleOrInFutureDataGridViewTextBoxColumn.Name = "onSaleOrInFutureDataGridViewTextBoxColumn";
            this.onSaleOrInFutureDataGridViewTextBoxColumn.ReadOnly = true;
            this.onSaleOrInFutureDataGridViewTextBoxColumn.Width = 125;
            // 
            // agencyNameDataGridViewTextBoxColumn
            // 
            this.agencyNameDataGridViewTextBoxColumn.DataPropertyName = "AgencyName";
            this.agencyNameDataGridViewTextBoxColumn.HeaderText = "AgencyName";
            this.agencyNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.agencyNameDataGridViewTextBoxColumn.Name = "agencyNameDataGridViewTextBoxColumn";
            this.agencyNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.agencyNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // locationOfTripDataGridViewTextBoxColumn
            // 
            this.locationOfTripDataGridViewTextBoxColumn.DataPropertyName = "LocationOfTrip";
            this.locationOfTripDataGridViewTextBoxColumn.HeaderText = "LocationOfTrip";
            this.locationOfTripDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationOfTripDataGridViewTextBoxColumn.Name = "locationOfTripDataGridViewTextBoxColumn";
            this.locationOfTripDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationOfTripDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceOfEachTripDataGridViewTextBoxColumn
            // 
            this.priceOfEachTripDataGridViewTextBoxColumn.DataPropertyName = "PriceOfEachTrip";
            this.priceOfEachTripDataGridViewTextBoxColumn.HeaderText = "PriceOfEachTrip";
            this.priceOfEachTripDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceOfEachTripDataGridViewTextBoxColumn.Name = "priceOfEachTripDataGridViewTextBoxColumn";
            this.priceOfEachTripDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceOfEachTripDataGridViewTextBoxColumn.Width = 125;
            // 
            // portionBindingSource
            // 
            this.portionBindingSource.DataSource = typeof(TravelAgency.Models.Portion);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(270, 212);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(164, 194);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(70, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "Name:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(70, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "E-mail:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(70, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Total Price:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PriceOfOrder
            // 
            this.PriceOfOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.PriceOfOrder.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PriceOfOrder.Location = new System.Drawing.Point(33, 384);
            this.PriceOfOrder.Name = "PriceOfOrder";
            this.PriceOfOrder.ReadOnly = true;
            this.PriceOfOrder.Size = new System.Drawing.Size(206, 22);
            this.PriceOfOrder.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(504, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Portions of trips:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SeeThisOrdercs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PriceOfOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ViewTrip);
            this.Controls.Add(this.EmailOfClient);
            this.Controls.Add(this.NameOfClient);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "SeeThisOrdercs";
            this.Text = "SeeThisOrdercs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SeeThisOrdercs_FormClosing);
            this.Load += new System.EventHandler(this.SeeThisOrdercs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewTrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox NameOfClient;
        private System.Windows.Forms.TextBox EmailOfClient;
        private System.Windows.Forms.DataGridView ViewTrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn onSaleOrInFutureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agencyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationOfTripDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceOfEachTripDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource portionBindingSource;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PriceOfOrder;
        private System.Windows.Forms.Label label3;
    }
}