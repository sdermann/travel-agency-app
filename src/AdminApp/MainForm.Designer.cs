namespace AdminApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.changes = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.agencyGridView1 = new System.Windows.Forms.DataGridView();
            this.agencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AgencyGridView = new System.Windows.Forms.TabControl();
            this.Orders = new System.Windows.Forms.TabPage();
            this.portionGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountOfTripsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tripDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agencyGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencyBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.AgencyGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // changes
            // 
            this.changes.Controls.Add(this.dataGridView2);
            this.changes.Controls.Add(this.dataGridView1);
            this.changes.Location = new System.Drawing.Point(4, 25);
            this.changes.Name = "changes";
            this.changes.Padding = new System.Windows.Forms.Padding(3);
            this.changes.Size = new System.Drawing.Size(768, 389);
            this.changes.TabIndex = 1;
            this.changes.Text = "Changes";
            this.changes.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(44, 208);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(643, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(643, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.portionGridView);
            this.tabPage1.Controls.Add(this.agencyGridView1);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 389);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agencies";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // agencyGridView1
            // 
            this.agencyGridView1.AllowUserToOrderColumns = true;
            this.agencyGridView1.AutoGenerateColumns = false;
            this.agencyGridView1.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.agencyGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agencyGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.Description,
            this.amountOfTripsDataGridViewTextBoxColumn});
            this.agencyGridView1.DataSource = this.agencyBindingSource;
            this.agencyGridView1.GridColor = System.Drawing.Color.Yellow;
            this.agencyGridView1.Location = new System.Drawing.Point(15, 47);
            this.agencyGridView1.Name = "agencyGridView1";
            this.agencyGridView1.RowHeadersWidth = 51;
            this.agencyGridView1.RowTemplate.Height = 24;
            this.agencyGridView1.Size = new System.Drawing.Size(401, 336);
            this.agencyGridView1.TabIndex = 0;
            this.agencyGridView1.SelectionChanged += new System.EventHandler(this.agencyGridView1_SelectionChanged);
            // 
            // agencyBindingSource
            // 
            this.agencyBindingSource.DataSource = typeof(TravelAgency.Models.Agency);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.agencyToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(762, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // agencyToolStripMenuItem
            // 
            this.agencyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.agencyToolStripMenuItem.Name = "agencyToolStripMenuItem";
            this.agencyToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.agencyToolStripMenuItem.Text = "Agency";
            this.agencyToolStripMenuItem.Click += new System.EventHandler(this.agencyToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // AgencyGridView
            // 
            this.AgencyGridView.Controls.Add(this.tabPage1);
            this.AgencyGridView.Controls.Add(this.changes);
            this.AgencyGridView.Controls.Add(this.Orders);
            this.AgencyGridView.Location = new System.Drawing.Point(12, 3);
            this.AgencyGridView.Name = "AgencyGridView";
            this.AgencyGridView.SelectedIndex = 0;
            this.AgencyGridView.Size = new System.Drawing.Size(776, 418);
            this.AgencyGridView.TabIndex = 0;
            // 
            // Orders
            // 
            this.Orders.Location = new System.Drawing.Point(4, 25);
            this.Orders.Name = "Orders";
            this.Orders.Padding = new System.Windows.Forms.Padding(3);
            this.Orders.Size = new System.Drawing.Size(768, 389);
            this.Orders.TabIndex = 2;
            this.Orders.Text = "Orders";
            this.Orders.UseVisualStyleBackColor = true;
            // 
            // portionGridView
            // 
            this.portionGridView.AutoGenerateColumns = false;
            this.portionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.portionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tripDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.portionGridView.DataSource = this.portionBindingSource;
            this.portionGridView.Location = new System.Drawing.Point(456, 47);
            this.portionGridView.Name = "portionGridView";
            this.portionGridView.RowHeadersWidth = 51;
            this.portionGridView.RowTemplate.Height = 24;
            this.portionGridView.Size = new System.Drawing.Size(287, 336);
            this.portionGridView.TabIndex = 2;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 80F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 125;
            // 
            // amountOfTripsDataGridViewTextBoxColumn
            // 
            this.amountOfTripsDataGridViewTextBoxColumn.DataPropertyName = "AmountOfTrips";
            this.amountOfTripsDataGridViewTextBoxColumn.HeaderText = "AmountOfTrips";
            this.amountOfTripsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountOfTripsDataGridViewTextBoxColumn.Name = "amountOfTripsDataGridViewTextBoxColumn";
            this.amountOfTripsDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountOfTripsDataGridViewTextBoxColumn.Width = 125;
            // 
            // portionBindingSource
            // 
            this.portionBindingSource.DataSource = typeof(TravelAgency.Models.Portion);
            // 
            // tripDataGridViewTextBoxColumn
            // 
            this.tripDataGridViewTextBoxColumn.DataPropertyName = "Trip.Location";
            this.tripDataGridViewTextBoxColumn.HeaderText = "Trip";
            this.tripDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tripDataGridViewTextBoxColumn.Name = "tripDataGridViewTextBoxColumn";
            this.tripDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AgencyGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.changes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agencyGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencyBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.AgencyGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.portionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage changes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView agencyGridView1;
        private System.Windows.Forms.TabControl AgencyGridView;
        private System.Windows.Forms.BindingSource agencyBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage Orders;
        private System.Windows.Forms.DataGridView portionGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountOfTripsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource portionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tripDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
    }
}