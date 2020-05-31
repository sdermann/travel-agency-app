namespace AdminApp
{
    partial class EditAgency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAgency));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SaveAgency = new System.Windows.Forms.Button();
            this.tripGridView = new System.Windows.Forms.DataGridView();
            this.LocationOfTrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceOfEachTrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.addTrip = new System.Windows.Forms.Button();
            this.editTrip = new System.Windows.Forms.Button();
            this.DeleteTrip = new System.Windows.Forms.Button();
            this.SendButt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(27, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "To the Agency-editor! Be creative - be first)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(25, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(455, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(455, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(465, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Image:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(28, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Trips` portions:";
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.NameBox.Location = new System.Drawing.Point(604, 114);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(230, 22);
            this.NameBox.TabIndex = 8;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.DescriptionBox.Location = new System.Drawing.Point(604, 161);
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(230, 108);
            this.DescriptionBox.TabIndex = 9;
            this.DescriptionBox.Text = "\r\n\r\n\r\n";
            // 
            // imageBox
            // 
            this.imageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.imageBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageBox.Location = new System.Drawing.Point(604, 337);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(230, 203);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 10;
            this.imageBox.TabStop = false;
            this.imageBox.Click += new System.EventHandler(this.imageBox_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(556, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(206, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // SaveAgency
            // 
            this.SaveAgency.AccessibleName = "";
            this.SaveAgency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveAgency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.SaveAgency.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveAgency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAgency.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold);
            this.SaveAgency.ForeColor = System.Drawing.Color.Olive;
            this.SaveAgency.Location = new System.Drawing.Point(197, 496);
            this.SaveAgency.Margin = new System.Windows.Forms.Padding(4);
            this.SaveAgency.Name = "SaveAgency";
            this.SaveAgency.Size = new System.Drawing.Size(157, 44);
            this.SaveAgency.TabIndex = 23;
            this.SaveAgency.Text = "Check";
            this.SaveAgency.UseVisualStyleBackColor = false;
            this.SaveAgency.Click += new System.EventHandler(this.SaveAgency_Click);
            // 
            // tripGridView
            // 
            this.tripGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tripGridView.AutoGenerateColumns = false;
            this.tripGridView.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.tripGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tripGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LocationOfTrip,
            this.amountDataGridViewTextBoxColumn,
            this.PriceOfEachTrip});
            this.tripGridView.DataSource = this.portionBindingSource;
            this.tripGridView.Location = new System.Drawing.Point(32, 186);
            this.tripGridView.Name = "tripGridView";
            this.tripGridView.RowHeadersWidth = 51;
            this.tripGridView.RowTemplate.Height = 24;
            this.tripGridView.Size = new System.Drawing.Size(390, 288);
            this.tripGridView.TabIndex = 25;
            this.tripGridView.SelectionChanged += new System.EventHandler(this.tripGridView_SelectionChanged);
            // 
            // LocationOfTrip
            // 
            this.LocationOfTrip.DataPropertyName = "LocationOfTrip";
            this.LocationOfTrip.HeaderText = "LocationOfTrip";
            this.LocationOfTrip.MinimumWidth = 6;
            this.LocationOfTrip.Name = "LocationOfTrip";
            this.LocationOfTrip.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // PriceOfEachTrip
            // 
            this.PriceOfEachTrip.DataPropertyName = "PriceOfEachTrip";
            this.PriceOfEachTrip.HeaderText = "PriceOfEachTrip";
            this.PriceOfEachTrip.MinimumWidth = 6;
            this.PriceOfEachTrip.Name = "PriceOfEachTrip";
            this.PriceOfEachTrip.Width = 125;
            // 
            // portionBindingSource
            // 
            this.portionBindingSource.AllowNew = false;
            this.portionBindingSource.DataSource = typeof(TravelAgency.Models.Portion);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Image files  (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfi" +
    "f; *.png";
            // 
            // addTrip
            // 
            this.addTrip.AccessibleName = "";
            this.addTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.addTrip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTrip.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold);
            this.addTrip.ForeColor = System.Drawing.Color.Olive;
            this.addTrip.Location = new System.Drawing.Point(28, 142);
            this.addTrip.Margin = new System.Windows.Forms.Padding(4);
            this.addTrip.Name = "addTrip";
            this.addTrip.Size = new System.Drawing.Size(66, 41);
            this.addTrip.TabIndex = 26;
            this.addTrip.Text = "Add";
            this.addTrip.UseVisualStyleBackColor = false;
            this.addTrip.Click += new System.EventHandler(this.addTrip_Click);
            // 
            // editTrip
            // 
            this.editTrip.AccessibleName = "";
            this.editTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.editTrip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTrip.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold);
            this.editTrip.ForeColor = System.Drawing.Color.Olive;
            this.editTrip.Location = new System.Drawing.Point(139, 142);
            this.editTrip.Margin = new System.Windows.Forms.Padding(4);
            this.editTrip.Name = "editTrip";
            this.editTrip.Size = new System.Drawing.Size(93, 41);
            this.editTrip.TabIndex = 27;
            this.editTrip.Text = "Edit";
            this.editTrip.UseVisualStyleBackColor = false;
            this.editTrip.Click += new System.EventHandler(this.editTrip_Click);
            // 
            // DeleteTrip
            // 
            this.DeleteTrip.AccessibleName = "";
            this.DeleteTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.DeleteTrip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteTrip.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold);
            this.DeleteTrip.ForeColor = System.Drawing.Color.Olive;
            this.DeleteTrip.Location = new System.Drawing.Point(253, 142);
            this.DeleteTrip.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteTrip.Name = "DeleteTrip";
            this.DeleteTrip.Size = new System.Drawing.Size(67, 41);
            this.DeleteTrip.TabIndex = 28;
            this.DeleteTrip.Text = "Del";
            this.DeleteTrip.UseVisualStyleBackColor = false;
            this.DeleteTrip.Click += new System.EventHandler(this.DeleteTrip_Click);
            // 
            // SendButt
            // 
            this.SendButt.AccessibleName = "";
            this.SendButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SendButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.SendButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendButt.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SendButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButt.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold);
            this.SendButt.ForeColor = System.Drawing.Color.Olive;
            this.SendButt.Location = new System.Drawing.Point(28, 496);
            this.SendButt.Margin = new System.Windows.Forms.Padding(4);
            this.SendButt.Name = "SendButt";
            this.SendButt.Size = new System.Drawing.Size(131, 44);
            this.SendButt.TabIndex = 29;
            this.SendButt.Text = "Finish";
            this.SendButt.UseVisualStyleBackColor = false;
            this.SendButt.Click += new System.EventHandler(this.SendButt_Click);
            // 
            // EditAgency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.SendButt);
            this.Controls.Add(this.DeleteTrip);
            this.Controls.Add(this.editTrip);
            this.Controls.Add(this.addTrip);
            this.Controls.Add(this.tripGridView);
            this.Controls.Add(this.SaveAgency);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "EditAgency";
            this.Text = "EditAgency";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditAgency_FormClosing);
            this.Load += new System.EventHandler(this.EditAgency_Load);
            this.TextChanged += new System.EventHandler(this.EditAgency_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button SaveAgency;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button addTrip;
        private System.Windows.Forms.Button editTrip;
        private System.Windows.Forms.Button DeleteTrip;
        private System.Windows.Forms.BindingSource portionBindingSource;
        private System.Windows.Forms.DataGridView tripGridView;
        private System.Windows.Forms.Button SendButt;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationOfTrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceOfEachTrip;
    }
}