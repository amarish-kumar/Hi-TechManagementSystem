namespace WindowsFormsApplication1.GUI
{
    partial class FormOrderSoftware
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxSearchOrderID = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonSearchOrder = new System.Windows.Forms.Button();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonListOrder = new System.Windows.Forms.Button();
            this.buttonDeleteOrder = new System.Windows.Forms.Button();
            this.buttonUpdateOrder = new System.Windows.Forms.Button();
            this.buttonSaveOrder = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxOrderID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxShippingDate = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxOrderDate = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxMadeBy = new System.Windows.Forms.ComboBox();
            this.comboBoxClientID = new System.Windows.Forms.ComboBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hiTechDataSet = new WindowsFormsApplication1.HiTechDataSet();
            this.comboBoxEmployeeId = new System.Windows.Forms.ComboBox();
            this.clientsTableAdapter = new WindowsFormsApplication1.HiTechDataSetTableAdapters.ClientsTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonListOL = new System.Windows.Forms.Button();
            this.textBoxOrderLineQuantity = new System.Windows.Forms.TextBox();
            this.buttonDeleteOL = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonUpdateOL = new System.Windows.Forms.Button();
            this.buttonSaveOL = new System.Windows.Forms.Button();
            this.comboBoxSoftwareID = new System.Windows.Forms.ComboBox();
            this.softwaresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxOrderID = new System.Windows.Forms.ComboBox();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxOLID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.softwaresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new WindowsFormsApplication1.HiTechDataSetTableAdapters.OrdersTableAdapter();
            this.softwaresTableAdapter = new WindowsFormsApplication1.HiTechDataSetTableAdapters.SoftwaresTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxSearchOLID = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSearchOL = new System.Windows.Forms.Button();
            this.listViewOrderLine = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonReturn = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiTechDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.softwaresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwaresBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(582, 664);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 59;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.maskedTextBoxSearchOrderID);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.buttonSearchOrder);
            this.groupBox4.Location = new System.Drawing.Point(495, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(162, 194);
            this.groupBox4.TabIndex = 62;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Order";
            // 
            // maskedTextBoxSearchOrderID
            // 
            this.maskedTextBoxSearchOrderID.Location = new System.Drawing.Point(30, 76);
            this.maskedTextBoxSearchOrderID.Mask = "0000";
            this.maskedTextBoxSearchOrderID.Name = "maskedTextBoxSearchOrderID";
            this.maskedTextBoxSearchOrderID.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxSearchOrderID.TabIndex = 43;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Please enter Order ID:";
            // 
            // buttonSearchOrder
            // 
            this.buttonSearchOrder.Location = new System.Drawing.Point(43, 112);
            this.buttonSearchOrder.Name = "buttonSearchOrder";
            this.buttonSearchOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchOrder.TabIndex = 41;
            this.buttonSearchOrder.Text = "&Search";
            this.buttonSearchOrder.UseVisualStyleBackColor = true;
            this.buttonSearchOrder.Click += new System.EventHandler(this.buttonSearchOrder_Click);
            // 
            // listViewOrder
            // 
            this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader11});
            this.listViewOrder.GridLines = true;
            this.listViewOrder.Location = new System.Drawing.Point(12, 231);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(645, 131);
            this.listViewOrder.TabIndex = 63;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.Details;
            this.listViewOrder.SelectedIndexChanged += new System.EventHandler(this.listViewOrder_SelectedIndexChanged);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Order ID";
            this.columnHeader9.Width = 68;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Employee ID";
            this.columnHeader15.Width = 127;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Client ID";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Made By";
            this.columnHeader18.Width = 77;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Order Date";
            this.columnHeader19.Width = 81;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Shipping Date";
            this.columnHeader11.Width = 85;
            // 
            // buttonListOrder
            // 
            this.buttonListOrder.Location = new System.Drawing.Point(386, 165);
            this.buttonListOrder.Name = "buttonListOrder";
            this.buttonListOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonListOrder.TabIndex = 58;
            this.buttonListOrder.Text = "&List";
            this.buttonListOrder.UseVisualStyleBackColor = true;
            this.buttonListOrder.Click += new System.EventHandler(this.buttonListOrder_Click);
            // 
            // buttonDeleteOrder
            // 
            this.buttonDeleteOrder.Location = new System.Drawing.Point(386, 125);
            this.buttonDeleteOrder.Name = "buttonDeleteOrder";
            this.buttonDeleteOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteOrder.TabIndex = 57;
            this.buttonDeleteOrder.Text = "&Delete";
            this.buttonDeleteOrder.UseVisualStyleBackColor = true;
            this.buttonDeleteOrder.Click += new System.EventHandler(this.buttonDeleteOrder_Click);
            // 
            // buttonUpdateOrder
            // 
            this.buttonUpdateOrder.Location = new System.Drawing.Point(386, 84);
            this.buttonUpdateOrder.Name = "buttonUpdateOrder";
            this.buttonUpdateOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateOrder.TabIndex = 56;
            this.buttonUpdateOrder.Text = "&Update";
            this.buttonUpdateOrder.UseVisualStyleBackColor = true;
            this.buttonUpdateOrder.Click += new System.EventHandler(this.buttonUpdateOrder_Click);
            // 
            // buttonSaveOrder
            // 
            this.buttonSaveOrder.Location = new System.Drawing.Point(386, 45);
            this.buttonSaveOrder.Name = "buttonSaveOrder";
            this.buttonSaveOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveOrder.TabIndex = 55;
            this.buttonSaveOrder.Text = "&Save";
            this.buttonSaveOrder.UseVisualStyleBackColor = true;
            this.buttonSaveOrder.Click += new System.EventHandler(this.buttonSaveOrder_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "Shipping Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Employee ID";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(240, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 13);
            this.label18.TabIndex = 62;
            this.label18.Text = "Client ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Made By";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(137, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Order Date";
            // 
            // textBoxOrderID
            // 
            this.textBoxOrderID.Enabled = false;
            this.textBoxOrderID.Location = new System.Drawing.Point(27, 59);
            this.textBoxOrderID.Name = "textBoxOrderID";
            this.textBoxOrderID.Size = new System.Drawing.Size(79, 20);
            this.textBoxOrderID.TabIndex = 60;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 54;
            this.label17.Text = "Order ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.maskedTextBoxShippingDate);
            this.groupBox3.Controls.Add(this.maskedTextBoxOrderDate);
            this.groupBox3.Controls.Add(this.comboBoxMadeBy);
            this.groupBox3.Controls.Add(this.comboBoxClientID);
            this.groupBox3.Controls.Add(this.comboBoxEmployeeId);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(477, 195);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "MM/DD/YYYY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "MM/DD/YYYY";
            // 
            // maskedTextBoxShippingDate
            // 
            this.maskedTextBoxShippingDate.Enabled = false;
            this.maskedTextBoxShippingDate.Location = new System.Drawing.Point(247, 116);
            this.maskedTextBoxShippingDate.Mask = "00/00/0000";
            this.maskedTextBoxShippingDate.Name = "maskedTextBoxShippingDate";
            this.maskedTextBoxShippingDate.Size = new System.Drawing.Size(91, 20);
            this.maskedTextBoxShippingDate.TabIndex = 72;
            this.maskedTextBoxShippingDate.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxOrderDate
            // 
            this.maskedTextBoxOrderDate.Location = new System.Drawing.Point(134, 117);
            this.maskedTextBoxOrderDate.Mask = "00/00/0000";
            this.maskedTextBoxOrderDate.Name = "maskedTextBoxOrderDate";
            this.maskedTextBoxOrderDate.Size = new System.Drawing.Size(91, 20);
            this.maskedTextBoxOrderDate.TabIndex = 71;
            this.maskedTextBoxOrderDate.ValidatingType = typeof(System.DateTime);
            // 
            // comboBoxMadeBy
            // 
            this.comboBoxMadeBy.FormattingEnabled = true;
            this.comboBoxMadeBy.Location = new System.Drawing.Point(15, 116);
            this.comboBoxMadeBy.Name = "comboBoxMadeBy";
            this.comboBoxMadeBy.Size = new System.Drawing.Size(95, 21);
            this.comboBoxMadeBy.TabIndex = 70;
            // 
            // comboBoxClientID
            // 
            this.comboBoxClientID.DataSource = this.clientsBindingSource;
            this.comboBoxClientID.DisplayMember = "ClientId";
            this.comboBoxClientID.FormattingEnabled = true;
            this.comboBoxClientID.Location = new System.Drawing.Point(237, 47);
            this.comboBoxClientID.Name = "comboBoxClientID";
            this.comboBoxClientID.Size = new System.Drawing.Size(95, 21);
            this.comboBoxClientID.TabIndex = 69;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.hiTechDataSet;
            // 
            // hiTechDataSet
            // 
            this.hiTechDataSet.DataSetName = "HiTechDataSet";
            this.hiTechDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxEmployeeId
            // 
            this.comboBoxEmployeeId.FormattingEnabled = true;
            this.comboBoxEmployeeId.Location = new System.Drawing.Point(122, 47);
            this.comboBoxEmployeeId.Name = "comboBoxEmployeeId";
            this.comboBoxEmployeeId.Size = new System.Drawing.Size(95, 21);
            this.comboBoxEmployeeId.TabIndex = 68;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonListOL);
            this.groupBox1.Controls.Add(this.textBoxOrderLineQuantity);
            this.groupBox1.Controls.Add(this.buttonDeleteOL);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.buttonUpdateOL);
            this.groupBox1.Controls.Add(this.buttonSaveOL);
            this.groupBox1.Controls.Add(this.comboBoxSoftwareID);
            this.groupBox1.Controls.Add(this.comboBoxOrderID);
            this.groupBox1.Controls.Add(this.textBoxOLID);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 379);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 129);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Items";
            // 
            // buttonListOL
            // 
            this.buttonListOL.Location = new System.Drawing.Point(374, 92);
            this.buttonListOL.Name = "buttonListOL";
            this.buttonListOL.Size = new System.Drawing.Size(75, 23);
            this.buttonListOL.TabIndex = 79;
            this.buttonListOL.Text = "&List";
            this.buttonListOL.UseVisualStyleBackColor = true;
            this.buttonListOL.Click += new System.EventHandler(this.buttonListOL_Click);
            // 
            // textBoxOrderLineQuantity
            // 
            this.textBoxOrderLineQuantity.Location = new System.Drawing.Point(268, 59);
            this.textBoxOrderLineQuantity.Name = "textBoxOrderLineQuantity";
            this.textBoxOrderLineQuantity.Size = new System.Drawing.Size(79, 20);
            this.textBoxOrderLineQuantity.TabIndex = 80;
            this.textBoxOrderLineQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOrderLineQuantity_KeyPress);
            // 
            // buttonDeleteOL
            // 
            this.buttonDeleteOL.Location = new System.Drawing.Point(374, 66);
            this.buttonDeleteOL.Name = "buttonDeleteOL";
            this.buttonDeleteOL.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteOL.TabIndex = 78;
            this.buttonDeleteOL.Text = "&Delete";
            this.buttonDeleteOL.UseVisualStyleBackColor = true;
            this.buttonDeleteOL.Click += new System.EventHandler(this.buttonDeleteOL_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(268, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 79;
            this.label14.Text = "Order Line Quantity";
            // 
            // buttonUpdateOL
            // 
            this.buttonUpdateOL.Location = new System.Drawing.Point(374, 38);
            this.buttonUpdateOL.Name = "buttonUpdateOL";
            this.buttonUpdateOL.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateOL.TabIndex = 77;
            this.buttonUpdateOL.Text = "&Update";
            this.buttonUpdateOL.UseVisualStyleBackColor = true;
            this.buttonUpdateOL.Click += new System.EventHandler(this.buttonUpdateOL_Click);
            // 
            // buttonSaveOL
            // 
            this.buttonSaveOL.Location = new System.Drawing.Point(374, 12);
            this.buttonSaveOL.Name = "buttonSaveOL";
            this.buttonSaveOL.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveOL.TabIndex = 76;
            this.buttonSaveOL.Text = "&Save";
            this.buttonSaveOL.UseVisualStyleBackColor = true;
            this.buttonSaveOL.Click += new System.EventHandler(this.buttonSaveOL_Click);
            // 
            // comboBoxSoftwareID
            // 
            this.comboBoxSoftwareID.DataSource = this.softwaresBindingSource1;
            this.comboBoxSoftwareID.DisplayMember = "SoftwareId";
            this.comboBoxSoftwareID.FormattingEnabled = true;
            this.comboBoxSoftwareID.Location = new System.Drawing.Point(187, 58);
            this.comboBoxSoftwareID.Name = "comboBoxSoftwareID";
            this.comboBoxSoftwareID.Size = new System.Drawing.Size(71, 21);
            this.comboBoxSoftwareID.TabIndex = 77;
            // 
            // softwaresBindingSource1
            // 
            this.softwaresBindingSource1.DataMember = "Softwares";
            this.softwaresBindingSource1.DataSource = this.hiTechDataSet;
            // 
            // comboBoxOrderID
            // 
            this.comboBoxOrderID.DataSource = this.ordersBindingSource;
            this.comboBoxOrderID.DisplayMember = "OrderId";
            this.comboBoxOrderID.FormattingEnabled = true;
            this.comboBoxOrderID.Location = new System.Drawing.Point(103, 58);
            this.comboBoxOrderID.Name = "comboBoxOrderID";
            this.comboBoxOrderID.Size = new System.Drawing.Size(71, 21);
            this.comboBoxOrderID.TabIndex = 75;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.hiTechDataSet;
            // 
            // textBoxOLID
            // 
            this.textBoxOLID.Enabled = false;
            this.textBoxOLID.Location = new System.Drawing.Point(15, 58);
            this.textBoxOLID.Name = "textBoxOLID";
            this.textBoxOLID.Size = new System.Drawing.Size(79, 20);
            this.textBoxOLID.TabIndex = 76;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 75;
            this.label13.Text = "Order Line ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 63;
            this.label8.Text = "Order ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(187, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "Software ID";
            // 
            // softwaresBindingSource
            // 
            this.softwaresBindingSource.DataMember = "Softwares";
            this.softwaresBindingSource.DataSource = this.hiTechDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // softwaresTableAdapter
            // 
            this.softwaresTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maskedTextBoxSearchOLID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.buttonSearchOL);
            this.groupBox2.Location = new System.Drawing.Point(495, 379);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 129);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Order Line";
            // 
            // maskedTextBoxSearchOLID
            // 
            this.maskedTextBoxSearchOLID.Location = new System.Drawing.Point(30, 42);
            this.maskedTextBoxSearchOLID.Mask = "0000";
            this.maskedTextBoxSearchOLID.Name = "maskedTextBoxSearchOLID";
            this.maskedTextBoxSearchOLID.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxSearchOLID.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Please enter Order Line ID:";
            // 
            // buttonSearchOL
            // 
            this.buttonSearchOL.Location = new System.Drawing.Point(43, 78);
            this.buttonSearchOL.Name = "buttonSearchOL";
            this.buttonSearchOL.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchOL.TabIndex = 41;
            this.buttonSearchOL.Text = "&Search";
            this.buttonSearchOL.UseVisualStyleBackColor = true;
            this.buttonSearchOL.Click += new System.EventHandler(this.buttonSearchOL_Click);
            // 
            // listViewOrderLine
            // 
            this.listViewOrderLine.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewOrderLine.GridLines = true;
            this.listViewOrderLine.Location = new System.Drawing.Point(12, 514);
            this.listViewOrderLine.Name = "listViewOrderLine";
            this.listViewOrderLine.Size = new System.Drawing.Size(645, 131);
            this.listViewOrderLine.TabIndex = 76;
            this.listViewOrderLine.UseCompatibleStateImageBehavior = false;
            this.listViewOrderLine.View = System.Windows.Forms.View.Details;
            this.listViewOrderLine.SelectedIndexChanged += new System.EventHandler(this.listViewOrderLine_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order Line ID";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Order ID";
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Software ID";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Order Line Quantity";
            this.columnHeader4.Width = 111;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(495, 665);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 77;
            this.buttonReturn.Text = "&Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // FormOrderSoftware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 705);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.listViewOrderLine);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.listViewOrder);
            this.Controls.Add(this.buttonListOrder);
            this.Controls.Add(this.buttonDeleteOrder);
            this.Controls.Add(this.buttonUpdateOrder);
            this.Controls.Add(this.buttonSaveOrder);
            this.Controls.Add(this.textBoxOrderID);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox3);
            this.Name = "FormOrderSoftware";
            this.Text = "Order Software";
            this.Load += new System.EventHandler(this.FormOrderSoftware_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiTechDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.softwaresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwaresBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSearchOrderID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonSearchOrder;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button buttonListOrder;
        private System.Windows.Forms.Button buttonDeleteOrder;
        private System.Windows.Forms.Button buttonUpdateOrder;
        private System.Windows.Forms.Button buttonSaveOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxOrderID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxClientID;
        private System.Windows.Forms.ComboBox comboBoxEmployeeId;
        private HiTechDataSet hiTechDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private HiTechDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxShippingDate;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxOrderDate;
        private System.Windows.Forms.ComboBox comboBoxMadeBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxOrderID;
        private System.Windows.Forms.TextBox textBoxOLID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private HiTechDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxSoftwareID;
        private System.Windows.Forms.BindingSource softwaresBindingSource;
        private HiTechDataSetTableAdapters.SoftwaresTableAdapter softwaresTableAdapter;
        private System.Windows.Forms.Button buttonListOL;
        private System.Windows.Forms.TextBox textBoxOrderLineQuantity;
        private System.Windows.Forms.Button buttonDeleteOL;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonUpdateOL;
        private System.Windows.Forms.Button buttonSaveOL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSearchOLID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSearchOL;
        private System.Windows.Forms.ListView listViewOrderLine;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.BindingSource softwaresBindingSource1;
    }
}