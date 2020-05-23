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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FutureTrips = new System.Windows.Forms.TabPage();
            this.FutureTripGridView = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.portionGridView = new System.Windows.Forms.DataGridView();
            this.agencyGridView1 = new System.Windows.Forms.DataGridView();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.HotSales = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Orders = new System.Windows.Forms.TabPage();
            this.ViewOrder = new System.Windows.Forms.Button();
            this.OperateOrder = new System.Windows.Forms.Button();
            this.OrdersGridView = new System.Windows.Forms.DataGridView();
            this.ClientsGridView = new System.Windows.Forms.DataGridView();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgencyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountOfTripsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.portionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.agencyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FutureTrips.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FutureTripGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencyGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.AgencyGridView.SuspendLayout();
            this.HotSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portionBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // FutureTrips
            // 
            this.FutureTrips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.FutureTrips.Controls.Add(this.FutureTripGridView);
            this.FutureTrips.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FutureTrips.Location = new System.Drawing.Point(4, 25);
            this.FutureTrips.Name = "FutureTrips";
            this.FutureTrips.Padding = new System.Windows.Forms.Padding(3);
            this.FutureTrips.Size = new System.Drawing.Size(768, 389);
            this.FutureTrips.TabIndex = 1;
            this.FutureTrips.Text = "FutureTrips";
            // 
            // FutureTripGridView
            // 
            this.FutureTripGridView.AutoGenerateColumns = false;
            this.FutureTripGridView.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.FutureTripGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FutureTripGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AgencyName,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.FutureTripGridView.DataSource = this.portionBindingSource1;
            this.FutureTripGridView.Location = new System.Drawing.Point(28, 25);
            this.FutureTripGridView.Name = "FutureTripGridView";
            this.FutureTripGridView.RowHeadersWidth = 51;
            this.FutureTripGridView.RowTemplate.Height = 24;
            this.FutureTripGridView.Size = new System.Drawing.Size(422, 336);
            this.FutureTripGridView.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.tabPage1.Controls.Add(this.portionGridView);
            this.tabPage1.Controls.Add(this.agencyGridView1);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 389);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agencies";
            // 
            // portionGridView
            // 
            this.portionGridView.AutoGenerateColumns = false;
            this.portionGridView.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.portionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.portionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Location,
            this.amountDataGridViewTextBoxColumn});
            this.portionGridView.DataSource = this.portionBindingSource;
            this.portionGridView.Location = new System.Drawing.Point(486, 47);
            this.portionGridView.Name = "portionGridView";
            this.portionGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.portionGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.portionGridView.RowTemplate.Height = 24;
            this.portionGridView.Size = new System.Drawing.Size(276, 336);
            this.portionGridView.TabIndex = 2;
            this.portionGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.portionGridView_CellContentClick);
            // 
            // agencyGridView1
            // 
            this.agencyGridView1.AllowUserToOrderColumns = true;
            this.agencyGridView1.AutoGenerateColumns = false;
            this.agencyGridView1.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.agencyGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agencyGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.Description,
            this.amountOfTripsDataGridViewTextBoxColumn});
            this.agencyGridView1.DataSource = this.agencyBindingSource;
            this.agencyGridView1.GridColor = System.Drawing.Color.Yellow;
            this.agencyGridView1.Location = new System.Drawing.Point(6, 47);
            this.agencyGridView1.Name = "agencyGridView1";
            this.agencyGridView1.RowHeadersWidth = 51;
            this.agencyGridView1.RowTemplate.Height = 24;
            this.agencyGridView1.Size = new System.Drawing.Size(444, 336);
            this.agencyGridView1.TabIndex = 0;
            this.agencyGridView1.SelectionChanged += new System.EventHandler(this.agencyGridView1_SelectionChanged);
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
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SandyBrown;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.agencyToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(762, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 28);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(133, 28);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(133, 28);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 28);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // agencyToolStripMenuItem
            // 
            this.agencyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.agencyToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agencyToolStripMenuItem.Name = "agencyToolStripMenuItem";
            this.agencyToolStripMenuItem.Size = new System.Drawing.Size(82, 28);
            this.agencyToolStripMenuItem.Text = "Agency";
            this.agencyToolStripMenuItem.Click += new System.EventHandler(this.agencyToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(149, 28);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(149, 28);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(149, 28);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 28);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // AgencyGridView
            // 
            this.AgencyGridView.Controls.Add(this.tabPage1);
            this.AgencyGridView.Controls.Add(this.FutureTrips);
            this.AgencyGridView.Controls.Add(this.HotSales);
            this.AgencyGridView.Controls.Add(this.Orders);
            this.AgencyGridView.Location = new System.Drawing.Point(12, 3);
            this.AgencyGridView.Name = "AgencyGridView";
            this.AgencyGridView.SelectedIndex = 0;
            this.AgencyGridView.Size = new System.Drawing.Size(776, 418);
            this.AgencyGridView.TabIndex = 0;
            // 
            // HotSales
            // 
            this.HotSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.HotSales.Controls.Add(this.dataGridView2);
            this.HotSales.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HotSales.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HotSales.Location = new System.Drawing.Point(4, 25);
            this.HotSales.Name = "HotSales";
            this.HotSales.Padding = new System.Windows.Forms.Padding(3);
            this.HotSales.Size = new System.Drawing.Size(768, 389);
            this.HotSales.TabIndex = 2;
            this.HotSales.Text = "HotSales";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agencyNameDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.portionBindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(18, 52);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(428, 308);
            this.dataGridView2.TabIndex = 0;
            // 
            // Orders
            // 
            this.Orders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.Orders.Controls.Add(this.ViewOrder);
            this.Orders.Controls.Add(this.OperateOrder);
            this.Orders.Controls.Add(this.OrdersGridView);
            this.Orders.Controls.Add(this.ClientsGridView);
            this.Orders.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Orders.ForeColor = System.Drawing.Color.Maroon;
            this.Orders.Location = new System.Drawing.Point(4, 25);
            this.Orders.Name = "Orders";
            this.Orders.Padding = new System.Windows.Forms.Padding(3);
            this.Orders.Size = new System.Drawing.Size(768, 389);
            this.Orders.TabIndex = 3;
            this.Orders.Text = "Orders";
            // 
            // ViewOrder
            // 
            this.ViewOrder.AccessibleName = "";
            this.ViewOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ViewOrder.BackColor = System.Drawing.Color.Peru;
            this.ViewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewOrder.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold);
            this.ViewOrder.ForeColor = System.Drawing.Color.Wheat;
            this.ViewOrder.Location = new System.Drawing.Point(576, 11);
            this.ViewOrder.Margin = new System.Windows.Forms.Padding(4);
            this.ViewOrder.Name = "ViewOrder";
            this.ViewOrder.Size = new System.Drawing.Size(133, 41);
            this.ViewOrder.TabIndex = 30;
            this.ViewOrder.Text = "View";
            this.ViewOrder.UseVisualStyleBackColor = false;
            // 
            // OperateOrder
            // 
            this.OperateOrder.AccessibleName = "";
            this.OperateOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OperateOrder.BackColor = System.Drawing.Color.Peru;
            this.OperateOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OperateOrder.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold);
            this.OperateOrder.ForeColor = System.Drawing.Color.Wheat;
            this.OperateOrder.Location = new System.Drawing.Point(409, 11);
            this.OperateOrder.Margin = new System.Windows.Forms.Padding(4);
            this.OperateOrder.Name = "OperateOrder";
            this.OperateOrder.Size = new System.Drawing.Size(136, 41);
            this.OperateOrder.TabIndex = 29;
            this.OperateOrder.Text = "Operate";
            this.OperateOrder.UseVisualStyleBackColor = false;
            this.OperateOrder.Click += new System.EventHandler(this.addTrip_Click);
            // 
            // OrdersGridView
            // 
            this.OrdersGridView.AutoGenerateColumns = false;
            this.OrdersGridView.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.OrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientDataGridViewTextBoxColumn,
            this.dateTimeDataGridViewTextBoxColumn2});
            this.OrdersGridView.DataSource = this.orderBindingSource;
            this.OrdersGridView.Location = new System.Drawing.Point(408, 59);
            this.OrdersGridView.Name = "OrdersGridView";
            this.OrdersGridView.RowHeadersWidth = 51;
            this.OrdersGridView.RowTemplate.Height = 24;
            this.OrdersGridView.Size = new System.Drawing.Size(301, 296);
            this.OrdersGridView.TabIndex = 1;
            // 
            // ClientsGridView
            // 
            this.ClientsGridView.AutoGenerateColumns = false;
            this.ClientsGridView.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emailDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1});
            this.ClientsGridView.DataSource = this.clientBindingSource;
            this.ClientsGridView.Location = new System.Drawing.Point(22, 20);
            this.ClientsGridView.Name = "ClientsGridView";
            this.ClientsGridView.RowHeadersWidth = 51;
            this.ClientsGridView.RowTemplate.Height = 24;
            this.ClientsGridView.Size = new System.Drawing.Size(314, 335);
            this.ClientsGridView.TabIndex = 0;
            this.ClientsGridView.SelectionChanged += new System.EventHandler(this.ClientsGridView_SelectionChanged);
            // 
            // Location
            // 
            this.Location.DataPropertyName = "Location";
            this.Location.HeaderText = "Location";
            this.Location.MinimumWidth = 6;
            this.Location.Name = "Location";
            this.Location.Width = 125;
            // 
            // AgencyName
            // 
            this.AgencyName.DataPropertyName = "AgencyName";
            this.AgencyName.HeaderText = "AgencyName";
            this.AgencyName.MinimumWidth = 6;
            this.AgencyName.Name = "AgencyName";
            this.AgencyName.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "LocationOfTrip";
            this.dataGridViewTextBoxColumn1.HeaderText = "Location";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 120;
            // 
            // portionBindingSource
            // 
            this.portionBindingSource.DataSource = typeof(TravelAgency.Models.Portion);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 80F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountOfTripsDataGridViewTextBoxColumn
            // 
            this.amountOfTripsDataGridViewTextBoxColumn.DataPropertyName = "AmountOfTrips";
            this.amountOfTripsDataGridViewTextBoxColumn.HeaderText = "AmountOfTrips";
            this.amountOfTripsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountOfTripsDataGridViewTextBoxColumn.Name = "amountOfTripsDataGridViewTextBoxColumn";
            this.amountOfTripsDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountOfTripsDataGridViewTextBoxColumn.Width = 140;
            // 
            // agencyBindingSource
            // 
            this.agencyBindingSource.DataSource = typeof(TravelAgency.Models.Agency);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn2.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // portionBindingSource1
            // 
            this.portionBindingSource1.DataSource = typeof(TravelAgency.Models.Portion);
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateTimeDataGridViewTextBoxColumn2
            // 
            this.dateTimeDataGridViewTextBoxColumn2.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn2.HeaderText = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dateTimeDataGridViewTextBoxColumn2.Name = "dateTimeDataGridViewTextBoxColumn2";
            this.dateTimeDataGridViewTextBoxColumn2.ReadOnly = true;
            this.dateTimeDataGridViewTextBoxColumn2.Width = 125;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(TravelAgency.Models.Order);
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 160;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(TravelAgency.Models.Client);
            // 
            // portionBindingSource2
            // 
            this.portionBindingSource2.DataSource = typeof(TravelAgency.Models.Portion);
            // 
            // agencyNameDataGridViewTextBoxColumn
            // 
            this.agencyNameDataGridViewTextBoxColumn.DataPropertyName = "AgencyName";
            this.agencyNameDataGridViewTextBoxColumn.HeaderText = "AgencyName";
            this.agencyNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.agencyNameDataGridViewTextBoxColumn.Name = "agencyNameDataGridViewTextBoxColumn";
            this.agencyNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn1
            // 
            this.amountDataGridViewTextBoxColumn1.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn1.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn1.Name = "amountDataGridViewTextBoxColumn1";
            this.amountDataGridViewTextBoxColumn1.Width = 125;
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
            this.FutureTrips.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FutureTripGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencyGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.AgencyGridView.ResumeLayout(false);
            this.HotSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Orders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portionBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage FutureTrips;
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
        private System.Windows.Forms.TabPage HotSales;
        private System.Windows.Forms.DataGridView portionGridView;
        private System.Windows.Forms.BindingSource portionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tripDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage Orders;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView ClientsGridView;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.DataGridView OrdersGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountOfTripsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button ViewOrder;
        private System.Windows.Forms.Button OperateOrder;
        private System.Windows.Forms.DataGridView FutureTripGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource portionBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgencyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn agencyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource portionBindingSource2;
    }
}