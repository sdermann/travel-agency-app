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
            this.CancelSaving = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tripDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.label3.Location = new System.Drawing.Point(405, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(405, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(403, 295);
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
            this.NameBox.Location = new System.Drawing.Point(532, 116);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(230, 22);
            this.NameBox.TabIndex = 8;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.DescriptionBox.Location = new System.Drawing.Point(532, 159);
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
            this.imageBox.Location = new System.Drawing.Point(532, 295);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(230, 122);
            this.imageBox.TabIndex = 10;
            this.imageBox.TabStop = false;
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
            this.SaveAgency.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SaveAgency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.SaveAgency.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveAgency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAgency.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold);
            this.SaveAgency.ForeColor = System.Drawing.Color.Olive;
            this.SaveAgency.Location = new System.Drawing.Point(31, 373);
            this.SaveAgency.Margin = new System.Windows.Forms.Padding(4);
            this.SaveAgency.Name = "SaveAgency";
            this.SaveAgency.Size = new System.Drawing.Size(131, 44);
            this.SaveAgency.TabIndex = 23;
            this.SaveAgency.Text = "Save";
            this.SaveAgency.UseVisualStyleBackColor = false;
            // 
            // CancelSaving
            // 
            this.CancelSaving.AccessibleName = "";
            this.CancelSaving.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CancelSaving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.CancelSaving.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelSaving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelSaving.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold);
            this.CancelSaving.ForeColor = System.Drawing.Color.Olive;
            this.CancelSaving.Location = new System.Drawing.Point(201, 373);
            this.CancelSaving.Margin = new System.Windows.Forms.Padding(4);
            this.CancelSaving.Name = "CancelSaving";
            this.CancelSaving.Size = new System.Drawing.Size(131, 44);
            this.CancelSaving.TabIndex = 24;
            this.CancelSaving.Text = "Cancel";
            this.CancelSaving.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tripDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.portionsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(300, 185);
            this.dataGridView1.TabIndex = 25;
            // 
            // tripDataGridViewTextBoxColumn
            // 
            this.tripDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tripDataGridViewTextBoxColumn.DataPropertyName = "Trip";
            this.tripDataGridViewTextBoxColumn.HeaderText = "Trip";
            this.tripDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tripDataGridViewTextBoxColumn.Name = "tripDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // portionsBindingSource
            // 
            this.portionsBindingSource.DataMember = "Portions";
            this.portionsBindingSource.DataSource = this.agencyBindingSource;
            // 
            // agencyBindingSource
            // 
            this.agencyBindingSource.DataSource = typeof(TravelAgency.Models.Agency);
            // 
            // EditAgency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CancelSaving);
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
            this.Name = "EditAgency";
            this.Text = "EditAgency";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencyBindingSource)).EndInit();
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
        private System.Windows.Forms.Button CancelSaving;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tripDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource portionsBindingSource;
        private System.Windows.Forms.BindingSource agencyBindingSource;
    }
}