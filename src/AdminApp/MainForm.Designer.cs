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
            this.portionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.portionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.portionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Orders = new System.Windows.Forms.TabPage();
            this.BanButt = new System.Windows.Forms.Button();
            this.ViewOrder = new System.Windows.Forms.Button();
            this.OperateOrder = new System.Windows.Forms.Button();
            this.OrdersGridView = new System.Windows.Forms.DataGridView();
            this.ClientsGridView = new System.Windows.Forms.DataGridView();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotSales = new System.Windows.Forms.TabPage();
            this.HotSalesGridView = new System.Windows.Forms.DataGridView();
            this.FutureTrips = new System.Windows.Forms.TabPage();
            this.FutureTripGridView = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.portionGridView = new System.Windows.Forms.DataGridView();
            this.AgencyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationOfTripAgency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agencyGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountOfTripsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agencyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationOfTripDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agencyNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationOfTripDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.portionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portionBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).BeginInit();
            this.Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGridView)).BeginInit();
            this.HotSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotSalesGridView)).BeginInit();
            this.FutureTrips.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FutureTripGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencyGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.AgencyGridView.SuspendLayout();
            this.SuspendLayout();
            // 
            // portionBindingSource
            // 
            this.portionBindingSource.DataSource = typeof(TravelAgency.Models.Portion);
            // 
            // agencyBindingSource
            // 
            this.agencyBindingSource.DataSource = typeof(TravelAgency.Models.Agency);
            // 
            // portionBindingSource1
            // 
            this.portionBindingSource1.AllowNew = false;
            this.portionBindingSource1.DataSource = typeof(TravelAgency.Models.Portion);
            // 
            // portionBindingSource2
            // 
            this.portionBindingSource2.DataSource = typeof(TravelAgency.Models.Portion);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(TravelAgency.Models.Order);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(TravelAgency.Models.Client);
            // 
            // orderBindingSource1
            // 
            this.orderBindingSource1.DataSource = typeof(TravelAgency.Models.Order);
            // 
            // Orders
            // 
            this.Orders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.Orders.Controls.Add(this.BanButt);
            this.Orders.Controls.Add(this.ViewOrder);
            this.Orders.Controls.Add(this.OperateOrder);
            this.Orders.Controls.Add(this.OrdersGridView);
            this.Orders.Controls.Add(this.ClientsGridView);
            this.Orders.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Orders.ForeColor = System.Drawing.Color.Maroon;
            this.Orders.Location = new System.Drawing.Point(4, 25);
            this.Orders.Name = "Orders";
            this.Orders.Padding = new System.Windows.Forms.Padding(3);
            this.Orders.Size = new System.Drawing.Size(792, 471);
            this.Orders.TabIndex = 3;
            this.Orders.Text = "Orders";
            // 
            // BanButt
            // 
            this.BanButt.AccessibleName = "";
            this.BanButt.BackColor = System.Drawing.Color.Peru;
            this.BanButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BanButt.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold);
            this.BanButt.ForeColor = System.Drawing.Color.Wheat;
            this.BanButt.Location = new System.Drawing.Point(34, 4);
            this.BanButt.Margin = new System.Windows.Forms.Padding(4);
            this.BanButt.Name = "BanButt";
            this.BanButt.Size = new System.Drawing.Size(70, 34);
            this.BanButt.TabIndex = 31;
            this.BanButt.Text = "Ban";
            this.BanButt.UseVisualStyleBackColor = false;
            this.BanButt.Click += new System.EventHandler(this.BanButt_Click);
            // 
            // ViewOrder
            // 
            this.ViewOrder.AccessibleName = "";
            this.ViewOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewOrder.BackColor = System.Drawing.Color.Peru;
            this.ViewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewOrder.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold);
            this.ViewOrder.ForeColor = System.Drawing.Color.Wheat;
            this.ViewOrder.Location = new System.Drawing.Point(588, 11);
            this.ViewOrder.Margin = new System.Windows.Forms.Padding(4);
            this.ViewOrder.Name = "ViewOrder";
            this.ViewOrder.Size = new System.Drawing.Size(133, 41);
            this.ViewOrder.TabIndex = 30;
            this.ViewOrder.Text = "View";
            this.ViewOrder.UseVisualStyleBackColor = false;
            this.ViewOrder.Click += new System.EventHandler(this.ViewOrder_Click);
            // 
            // OperateOrder
            // 
            this.OperateOrder.AccessibleName = "";
            this.OperateOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OperateOrder.BackColor = System.Drawing.Color.Peru;
            this.OperateOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OperateOrder.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold);
            this.OperateOrder.ForeColor = System.Drawing.Color.Wheat;
            this.OperateOrder.Location = new System.Drawing.Point(421, 11);
            this.OperateOrder.Margin = new System.Windows.Forms.Padding(4);
            this.OperateOrder.Name = "OperateOrder";
            this.OperateOrder.Size = new System.Drawing.Size(136, 41);
            this.OperateOrder.TabIndex = 29;
            this.OperateOrder.Text = "Operate";
            this.OperateOrder.UseVisualStyleBackColor = false;
            this.OperateOrder.Click += new System.EventHandler(this.OperateOrder_Click);
            // 
            // OrdersGridView
            // 
            this.OrdersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdersGridView.AutoGenerateColumns = false;
            this.OrdersGridView.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.OrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientName,
            this.dateTimeDataGridViewTextBoxColumn2});
            this.OrdersGridView.DataSource = this.orderBindingSource;
            this.OrdersGridView.Location = new System.Drawing.Point(408, 59);
            this.OrdersGridView.MultiSelect = false;
            this.OrdersGridView.Name = "OrdersGridView";
            this.OrdersGridView.ReadOnly = true;
            this.OrdersGridView.RowHeadersWidth = 51;
            this.OrdersGridView.RowTemplate.Height = 24;
            this.OrdersGridView.Size = new System.Drawing.Size(301, 296);
            this.OrdersGridView.TabIndex = 1;
            // 
            // ClientsGridView
            // 
            this.ClientsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientsGridView.AutoGenerateColumns = false;
            this.ClientsGridView.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emailDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1});
            this.ClientsGridView.DataSource = this.clientBindingSource;
            this.ClientsGridView.Location = new System.Drawing.Point(22, 48);
            this.ClientsGridView.MultiSelect = false;
            this.ClientsGridView.Name = "ClientsGridView";
            this.ClientsGridView.ReadOnly = true;
            this.ClientsGridView.RowHeadersWidth = 51;
            this.ClientsGridView.RowTemplate.Height = 24;
            this.ClientsGridView.Size = new System.Drawing.Size(314, 307);
            this.ClientsGridView.TabIndex = 0;
            this.ClientsGridView.SelectionChanged += new System.EventHandler(this.ClientsGridView_SelectionChanged);
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // HotSales
            // 
            this.HotSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.HotSales.Controls.Add(this.HotSalesGridView);
            this.HotSales.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HotSales.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HotSales.Location = new System.Drawing.Point(4, 25);
            this.HotSales.Name = "HotSales";
            this.HotSales.Padding = new System.Windows.Forms.Padding(3);
            this.HotSales.Size = new System.Drawing.Size(792, 471);
            this.HotSales.TabIndex = 2;
            this.HotSales.Text = "HotSales";
            // 
            // HotSalesGridView
            // 
            this.HotSalesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HotSalesGridView.AutoGenerateColumns = false;
            this.HotSalesGridView.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.HotSalesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HotSalesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agencyNameDataGridViewTextBoxColumn,
            this.locationOfTripDataGridViewTextBoxColumn1,
            this.amountDataGridViewTextBoxColumn1});
            this.HotSalesGridView.DataSource = this.portionBindingSource2;
            this.HotSalesGridView.Location = new System.Drawing.Point(18, 52);
            this.HotSalesGridView.MultiSelect = false;
            this.HotSalesGridView.Name = "HotSalesGridView";
            this.HotSalesGridView.ReadOnly = true;
            this.HotSalesGridView.RowHeadersWidth = 51;
            this.HotSalesGridView.RowTemplate.Height = 24;
            this.HotSalesGridView.Size = new System.Drawing.Size(412, 308);
            this.HotSalesGridView.TabIndex = 0;
           
            // 
            // FutureTrips
            // 
            this.FutureTrips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(138)))));
            this.FutureTrips.Controls.Add(this.FutureTripGridView);
            this.FutureTrips.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FutureTrips.Location = new System.Drawing.Point(4, 25);
            this.FutureTrips.Name = "FutureTrips";
            this.FutureTrips.Padding = new System.Windows.Forms.Padding(3);
            this.FutureTrips.Size = new System.Drawing.Size(792, 471);
            this.FutureTrips.TabIndex = 1;
            this.FutureTrips.Text = "FutureTrips";
            // 
            // FutureTripGridView
            // 
            this.FutureTripGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FutureTripGridView.AutoGenerateColumns = false;
            this.FutureTripGridView.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.FutureTripGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FutureTripGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agencyNameDataGridViewTextBoxColumn2,
            this.locationOfTripDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn2});
            this.FutureTripGridView.DataSource = this.portionBindingSource1;
            this.FutureTripGridView.Location = new System.Drawing.Point(28, 25);
            this.FutureTripGridView.MultiSelect = false;
            this.FutureTripGridView.Name = "FutureTripGridView";
            this.FutureTripGridView.ReadOnly = true;
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
            this.tabPage1.Size = new System.Drawing.Size(792, 471);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agencies";
            // 
            // portionGridView
            // 
            this.portionGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.portionGridView.AutoGenerateColumns = false;
            this.portionGridView.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.portionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.portionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AgencyName,
            this.locationOfTripAgency,
            this.amountDataGridViewTextBoxColumn});
            this.portionGridView.DataSource = this.portionBindingSource;
            this.portionGridView.Location = new System.Drawing.Point(509, 47);
            this.portionGridView.MultiSelect = false;
            this.portionGridView.Name = "portionGridView";
            this.portionGridView.ReadOnly = true;
            this.portionGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.portionGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.portionGridView.RowTemplate.Height = 24;
            this.portionGridView.Size = new System.Drawing.Size(256, 336);
            this.portionGridView.TabIndex = 2;
            // 
            // AgencyName
            // 
            this.AgencyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AgencyName.DataPropertyName = "AgencyName";
            this.AgencyName.HeaderText = "AgencyName";
            this.AgencyName.MinimumWidth = 6;
            this.AgencyName.Name = "AgencyName";
            this.AgencyName.ReadOnly = true;
            // 
            // locationOfTripAgency
            // 
            this.locationOfTripAgency.DataPropertyName = "LocationOfTrip";
            this.locationOfTripAgency.HeaderText = "LocationOfTrip";
            this.locationOfTripAgency.MinimumWidth = 6;
            this.locationOfTripAgency.Name = "locationOfTripAgency";
            this.locationOfTripAgency.ReadOnly = true;
            this.locationOfTripAgency.Width = 125;
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
            // agencyGridView1
            // 
            this.agencyGridView1.AllowUserToOrderColumns = true;
            this.agencyGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.agencyGridView1.AutoGenerateColumns = false;
            this.agencyGridView1.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.agencyGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agencyGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.Description,
            this.amountOfTripsDataGridViewTextBoxColumn,
            this.Image});
            this.agencyGridView1.DataSource = this.agencyBindingSource;
            this.agencyGridView1.GridColor = System.Drawing.Color.Yellow;
            this.agencyGridView1.Location = new System.Drawing.Point(6, 47);
            this.agencyGridView1.MultiSelect = false;
            this.agencyGridView1.Name = "agencyGridView1";
            this.agencyGridView1.ReadOnly = true;
            this.agencyGridView1.RowHeadersWidth = 51;
            this.agencyGridView1.RowTemplate.Height = 24;
            this.agencyGridView1.Size = new System.Drawing.Size(494, 336);
            this.agencyGridView1.TabIndex = 0;
            this.agencyGridView1.SelectionChanged += new System.EventHandler(this.agencyGridView1_SelectionChanged);
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
            this.amountOfTripsDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountOfTripsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountOfTripsDataGridViewTextBoxColumn.Name = "amountOfTripsDataGridViewTextBoxColumn";
            this.amountOfTripsDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountOfTripsDataGridViewTextBoxColumn.Width = 125;
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Image";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Width = 125;
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
            this.menuStrip1.Size = new System.Drawing.Size(786, 32);
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
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // AgencyGridView
            // 
            this.AgencyGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgencyGridView.Controls.Add(this.tabPage1);
            this.AgencyGridView.Controls.Add(this.FutureTrips);
            this.AgencyGridView.Controls.Add(this.HotSales);
            this.AgencyGridView.Controls.Add(this.Orders);
            this.AgencyGridView.Location = new System.Drawing.Point(12, 3);
            this.AgencyGridView.Name = "AgencyGridView";
            this.AgencyGridView.SelectedIndex = 0;
            this.AgencyGridView.Size = new System.Drawing.Size(800, 500);
            this.AgencyGridView.TabIndex = 0;
            // 
            // ClientName
            // 
            this.ClientName.DataPropertyName = "ClientName";
            this.ClientName.HeaderText = "ClientName";
            this.ClientName.MinimumWidth = 6;
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            this.ClientName.Width = 125;
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
            // agencyNameDataGridViewTextBoxColumn
            // 
            this.agencyNameDataGridViewTextBoxColumn.DataPropertyName = "AgencyName";
            this.agencyNameDataGridViewTextBoxColumn.HeaderText = "AgencyName";
            this.agencyNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.agencyNameDataGridViewTextBoxColumn.Name = "agencyNameDataGridViewTextBoxColumn";
            this.agencyNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.agencyNameDataGridViewTextBoxColumn.Width = 109;
            // 
            // locationOfTripDataGridViewTextBoxColumn1
            // 
            this.locationOfTripDataGridViewTextBoxColumn1.DataPropertyName = "LocationOfTrip";
            this.locationOfTripDataGridViewTextBoxColumn1.HeaderText = "LocationOfTrip";
            this.locationOfTripDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.locationOfTripDataGridViewTextBoxColumn1.Name = "locationOfTripDataGridViewTextBoxColumn1";
            this.locationOfTripDataGridViewTextBoxColumn1.ReadOnly = true;
            this.locationOfTripDataGridViewTextBoxColumn1.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn1
            // 
            this.amountDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.amountDataGridViewTextBoxColumn1.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn1.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn1.Name = "amountDataGridViewTextBoxColumn1";
            this.amountDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // agencyNameDataGridViewTextBoxColumn2
            // 
            this.agencyNameDataGridViewTextBoxColumn2.DataPropertyName = "AgencyName";
            this.agencyNameDataGridViewTextBoxColumn2.HeaderText = "AgencyName";
            this.agencyNameDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.agencyNameDataGridViewTextBoxColumn2.Name = "agencyNameDataGridViewTextBoxColumn2";
            this.agencyNameDataGridViewTextBoxColumn2.ReadOnly = true;
            this.agencyNameDataGridViewTextBoxColumn2.Width = 119;
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
            // amountDataGridViewTextBoxColumn2
            // 
            this.amountDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.amountDataGridViewTextBoxColumn2.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn2.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn2.Name = "amountDataGridViewTextBoxColumn2";
            this.amountDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.AgencyGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.portionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portionBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).EndInit();
            this.Orders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGridView)).EndInit();
            this.HotSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HotSalesGridView)).EndInit();
            this.FutureTrips.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FutureTripGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencyGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.AgencyGridView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource agencyBindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource portionBindingSource1;
        private System.Windows.Forms.BindingSource portionBindingSource2;
        private System.Windows.Forms.BindingSource portionBindingSource;
        private System.Windows.Forms.BindingSource orderBindingSource1;
        private System.Windows.Forms.TabPage Orders;
        private System.Windows.Forms.Button BanButt;
        private System.Windows.Forms.Button ViewOrder;
        private System.Windows.Forms.Button OperateOrder;
        private System.Windows.Forms.DataGridView OrdersGridView;
        private System.Windows.Forms.DataGridView ClientsGridView;
        private System.Windows.Forms.TabPage HotSales;
        private System.Windows.Forms.DataGridView HotSalesGridView;
        private System.Windows.Forms.TabPage FutureTrips;
        private System.Windows.Forms.DataGridView FutureTripGridView;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView portionGridView;
        private System.Windows.Forms.DataGridView agencyGridView1;
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
        private System.Windows.Forms.TabControl AgencyGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountOfTripsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgencyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationOfTripAgency;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn agencyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationOfTripDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn agencyNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationOfTripDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn2;
    }
}