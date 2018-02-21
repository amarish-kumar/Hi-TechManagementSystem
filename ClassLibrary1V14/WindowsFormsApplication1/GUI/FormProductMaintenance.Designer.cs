namespace WindowsFormsApp_EF
{
    partial class FormProductMaintenance
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewBook = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxBookId = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxAuthorId = new System.Windows.Forms.ComboBox();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hiTechDataSet = new WindowsFormsApplication1.HiTechDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxPublisherId = new System.Windows.Forms.ComboBox();
            this.publishersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxCategoryId = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxQOH = new System.Windows.Forms.TextBox();
            this.textBoxYearPublished = new System.Windows.Forms.TextBox();
            this.textBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxSearchBook = new System.Windows.Forms.MaskedTextBox();
            this.labelDisplay = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listViewSoftware = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxSoftwareID = new System.Windows.Forms.TextBox();
            this.buttonExitSoftware = new System.Windows.Forms.Button();
            this.buttonListSoftware = new System.Windows.Forms.Button();
            this.buttonDeleteSoftware = new System.Windows.Forms.Button();
            this.buttonUpdateSoftware = new System.Windows.Forms.Button();
            this.buttonSaveSoftware = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxQOHSoftware = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxCatId = new System.Windows.Forms.ComboBox();
            this.textBoxSoftwareName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxCompany = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxSearchSoftware = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonSearchSoftware = new System.Windows.Forms.Button();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new WindowsFormsApplication1.HiTechDataSetTableAdapters.BooksTableAdapter();
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new WindowsFormsApplication1.HiTechDataSetTableAdapters.CategoriesTableAdapter();
            this.publishersTableAdapter = new WindowsFormsApplication1.HiTechDataSetTableAdapters.PublishersTableAdapter();
            this.authorsTableAdapter = new WindowsFormsApplication1.HiTechDataSetTableAdapters.AuthorsTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiTechDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(21, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(681, 444);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewBook);
            this.tabPage1.Controls.Add(this.textBoxBookId);
            this.tabPage1.Controls.Add(this.buttonExit);
            this.tabPage1.Controls.Add(this.buttonList);
            this.tabPage1.Controls.Add(this.buttonDelete);
            this.tabPage1.Controls.Add(this.buttonUpdate);
            this.tabPage1.Controls.Add(this.buttonSave);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(673, 415);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Book";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewBook
            // 
            this.listViewBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader10});
            this.listViewBook.GridLines = true;
            this.listViewBook.Location = new System.Drawing.Point(10, 219);
            this.listViewBook.Name = "listViewBook";
            this.listViewBook.Size = new System.Drawing.Size(645, 131);
            this.listViewBook.TabIndex = 53;
            this.listViewBook.UseCompatibleStateImageBehavior = false;
            this.listViewBook.View = System.Windows.Forms.View.Details;
            this.listViewBook.SelectedIndexChanged += new System.EventHandler(this.listViewBook_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Book ID";
            this.columnHeader1.Width = 68;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Title";
            this.columnHeader2.Width = 143;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ISBN";
            this.columnHeader3.Width = 73;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Unit Price";
            this.columnHeader4.Width = 59;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Year Publ.";
            this.columnHeader5.Width = 65;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "QOH";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Category ID";
            this.columnHeader7.Width = 69;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Publisher ID";
            this.columnHeader8.Width = 76;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Author Id";
            // 
            // textBoxBookId
            // 
            this.textBoxBookId.Enabled = false;
            this.textBoxBookId.Location = new System.Drawing.Point(25, 56);
            this.textBoxBookId.Name = "textBoxBookId";
            this.textBoxBookId.Size = new System.Drawing.Size(79, 20);
            this.textBoxBookId.TabIndex = 43;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(580, 375);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 42;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(384, 161);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(75, 23);
            this.buttonList.TabIndex = 40;
            this.buttonList.Text = "&List";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(384, 121);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 39;
            this.buttonDelete.Text = "&Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(384, 80);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 38;
            this.buttonUpdate.Text = "&Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(384, 41);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 37;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Book ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxAuthorId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxPublisherId);
            this.groupBox1.Controls.Add(this.comboBoxCategoryId);
            this.groupBox1.Controls.Add(this.textBoxQOH);
            this.groupBox1.Controls.Add(this.textBoxYearPublished);
            this.groupBox1.Controls.Add(this.textBoxUnitPrice);
            this.groupBox1.Controls.Add(this.textBoxISBN);
            this.groupBox1.Controls.Add(this.textBoxTitle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(10, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 195);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Information";
            // 
            // comboBoxAuthorId
            // 
            this.comboBoxAuthorId.DataSource = this.authorsBindingSource;
            this.comboBoxAuthorId.DisplayMember = "AuthorId";
            this.comboBoxAuthorId.FormattingEnabled = true;
            this.comboBoxAuthorId.Location = new System.Drawing.Point(204, 153);
            this.comboBoxAuthorId.Name = "comboBoxAuthorId";
            this.comboBoxAuthorId.Size = new System.Drawing.Size(79, 21);
            this.comboBoxAuthorId.TabIndex = 61;
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.hiTechDataSet;
            // 
            // hiTechDataSet
            // 
            this.hiTechDataSet.DataSetName = "HiTechDataSet";
            this.hiTechDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Author ID";
            // 
            // comboBoxPublisherId
            // 
            this.comboBoxPublisherId.DataSource = this.publishersBindingSource;
            this.comboBoxPublisherId.DisplayMember = "PublisherId";
            this.comboBoxPublisherId.FormattingEnabled = true;
            this.comboBoxPublisherId.Location = new System.Drawing.Point(110, 153);
            this.comboBoxPublisherId.Name = "comboBoxPublisherId";
            this.comboBoxPublisherId.Size = new System.Drawing.Size(79, 21);
            this.comboBoxPublisherId.TabIndex = 59;
            // 
            // publishersBindingSource
            // 
            this.publishersBindingSource.DataMember = "Publishers";
            this.publishersBindingSource.DataSource = this.hiTechDataSet;
            // 
            // comboBoxCategoryId
            // 
            this.comboBoxCategoryId.DataSource = this.categoriesBindingSource;
            this.comboBoxCategoryId.DisplayMember = "CategoryId";
            this.comboBoxCategoryId.FormattingEnabled = true;
            this.comboBoxCategoryId.Location = new System.Drawing.Point(15, 153);
            this.comboBoxCategoryId.Name = "comboBoxCategoryId";
            this.comboBoxCategoryId.Size = new System.Drawing.Size(79, 21);
            this.comboBoxCategoryId.TabIndex = 58;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.hiTechDataSet;
            // 
            // textBoxQOH
            // 
            this.textBoxQOH.Location = new System.Drawing.Point(237, 100);
            this.textBoxQOH.Name = "textBoxQOH";
            this.textBoxQOH.Size = new System.Drawing.Size(50, 20);
            this.textBoxQOH.TabIndex = 57;
            this.textBoxQOH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxYearPublished_KeyPress);
            // 
            // textBoxYearPublished
            // 
            this.textBoxYearPublished.Location = new System.Drawing.Point(170, 98);
            this.textBoxYearPublished.Name = "textBoxYearPublished";
            this.textBoxYearPublished.Size = new System.Drawing.Size(50, 20);
            this.textBoxYearPublished.TabIndex = 56;
            this.textBoxYearPublished.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxYearPublished_KeyPress);
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Location = new System.Drawing.Point(109, 98);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(50, 20);
            this.textBoxUnitPrice.TabIndex = 55;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(15, 97);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(79, 20);
            this.textBoxISBN.TabIndex = 54;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(109, 48);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(243, 20);
            this.textBoxTitle.TabIndex = 54;
            this.textBoxTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTitle_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Publisher ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Category ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = " Year Publ.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "QOH";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "ISBN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(106, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Title";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(106, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Unit Price";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maskedTextBoxSearchBook);
            this.groupBox2.Controls.Add(this.labelDisplay);
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Location = new System.Drawing.Point(493, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 194);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Book";
            // 
            // maskedTextBoxSearchBook
            // 
            this.maskedTextBoxSearchBook.Location = new System.Drawing.Point(29, 78);
            this.maskedTextBoxSearchBook.Mask = "0000";
            this.maskedTextBoxSearchBook.Name = "maskedTextBoxSearchBook";
            this.maskedTextBoxSearchBook.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxSearchBook.TabIndex = 42;
            // 
            // labelDisplay
            // 
            this.labelDisplay.AutoSize = true;
            this.labelDisplay.Location = new System.Drawing.Point(26, 56);
            this.labelDisplay.Name = "labelDisplay";
            this.labelDisplay.Size = new System.Drawing.Size(111, 13);
            this.labelDisplay.TabIndex = 30;
            this.labelDisplay.Text = "Please enter Book ID:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(43, 112);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 41;
            this.buttonSearch.Text = "&Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listViewSoftware);
            this.tabPage3.Controls.Add(this.textBoxSoftwareID);
            this.tabPage3.Controls.Add(this.buttonExitSoftware);
            this.tabPage3.Controls.Add(this.buttonListSoftware);
            this.tabPage3.Controls.Add(this.buttonDeleteSoftware);
            this.tabPage3.Controls.Add(this.buttonUpdateSoftware);
            this.tabPage3.Controls.Add(this.buttonSaveSoftware);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(673, 415);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Software";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listViewSoftware
            // 
            this.listViewSoftware.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader11});
            this.listViewSoftware.GridLines = true;
            this.listViewSoftware.Location = new System.Drawing.Point(10, 227);
            this.listViewSoftware.Name = "listViewSoftware";
            this.listViewSoftware.Size = new System.Drawing.Size(645, 131);
            this.listViewSoftware.TabIndex = 53;
            this.listViewSoftware.UseCompatibleStateImageBehavior = false;
            this.listViewSoftware.View = System.Windows.Forms.View.Details;
            this.listViewSoftware.SelectedIndexChanged += new System.EventHandler(this.listViewSoftware_SelectedIndexChanged);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Software ID";
            this.columnHeader9.Width = 68;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Software Name";
            this.columnHeader15.Width = 127;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Company";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Category ID";
            this.columnHeader18.Width = 77;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Price";
            this.columnHeader19.Width = 81;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "QOH";
            // 
            // textBoxSoftwareID
            // 
            this.textBoxSoftwareID.Enabled = false;
            this.textBoxSoftwareID.Location = new System.Drawing.Point(25, 56);
            this.textBoxSoftwareID.Name = "textBoxSoftwareID";
            this.textBoxSoftwareID.Size = new System.Drawing.Size(79, 20);
            this.textBoxSoftwareID.TabIndex = 43;
            // 
            // buttonExitSoftware
            // 
            this.buttonExitSoftware.Location = new System.Drawing.Point(580, 375);
            this.buttonExitSoftware.Name = "buttonExitSoftware";
            this.buttonExitSoftware.Size = new System.Drawing.Size(75, 23);
            this.buttonExitSoftware.TabIndex = 42;
            this.buttonExitSoftware.Text = "E&xit";
            this.buttonExitSoftware.UseVisualStyleBackColor = true;
            this.buttonExitSoftware.Click += new System.EventHandler(this.buttonExitSoftware_Click);
            // 
            // buttonListSoftware
            // 
            this.buttonListSoftware.Location = new System.Drawing.Point(384, 161);
            this.buttonListSoftware.Name = "buttonListSoftware";
            this.buttonListSoftware.Size = new System.Drawing.Size(75, 23);
            this.buttonListSoftware.TabIndex = 40;
            this.buttonListSoftware.Text = "&List";
            this.buttonListSoftware.UseVisualStyleBackColor = true;
            this.buttonListSoftware.Click += new System.EventHandler(this.buttonListSoftware_Click);
            // 
            // buttonDeleteSoftware
            // 
            this.buttonDeleteSoftware.Location = new System.Drawing.Point(384, 121);
            this.buttonDeleteSoftware.Name = "buttonDeleteSoftware";
            this.buttonDeleteSoftware.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteSoftware.TabIndex = 39;
            this.buttonDeleteSoftware.Text = "&Delete";
            this.buttonDeleteSoftware.UseVisualStyleBackColor = true;
            this.buttonDeleteSoftware.Click += new System.EventHandler(this.buttonDeleteSoftware_Click);
            // 
            // buttonUpdateSoftware
            // 
            this.buttonUpdateSoftware.Location = new System.Drawing.Point(384, 80);
            this.buttonUpdateSoftware.Name = "buttonUpdateSoftware";
            this.buttonUpdateSoftware.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateSoftware.TabIndex = 38;
            this.buttonUpdateSoftware.Text = "&Update";
            this.buttonUpdateSoftware.UseVisualStyleBackColor = true;
            this.buttonUpdateSoftware.Click += new System.EventHandler(this.buttonUpdateSoftware_Click);
            // 
            // buttonSaveSoftware
            // 
            this.buttonSaveSoftware.Location = new System.Drawing.Point(384, 41);
            this.buttonSaveSoftware.Name = "buttonSaveSoftware";
            this.buttonSaveSoftware.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveSoftware.TabIndex = 37;
            this.buttonSaveSoftware.Text = "&Save";
            this.buttonSaveSoftware.UseVisualStyleBackColor = true;
            this.buttonSaveSoftware.Click += new System.EventHandler(this.buttonSaveSoftware_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Sofware ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxQOHSoftware);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.comboBoxCatId);
            this.groupBox3.Controls.Add(this.textBoxSoftwareName);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.textBoxCompany);
            this.groupBox3.Controls.Add(this.textBoxPrice);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(10, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(477, 195);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Software Information";
            // 
            // textBoxQOHSoftware
            // 
            this.textBoxQOHSoftware.Location = new System.Drawing.Point(305, 103);
            this.textBoxQOHSoftware.Name = "textBoxQOHSoftware";
            this.textBoxQOHSoftware.Size = new System.Drawing.Size(50, 20);
            this.textBoxQOHSoftware.TabIndex = 67;
            this.textBoxQOHSoftware.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxYearPublished_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "QOH";
            // 
            // comboBoxCatId
            // 
            this.comboBoxCatId.DataSource = this.categoriesBindingSource;
            this.comboBoxCatId.DisplayMember = "CategoryId";
            this.comboBoxCatId.FormattingEnabled = true;
            this.comboBoxCatId.Location = new System.Drawing.Point(126, 103);
            this.comboBoxCatId.Name = "comboBoxCatId";
            this.comboBoxCatId.Size = new System.Drawing.Size(79, 21);
            this.comboBoxCatId.TabIndex = 65;
            // 
            // textBoxSoftwareName
            // 
            this.textBoxSoftwareName.Location = new System.Drawing.Point(102, 48);
            this.textBoxSoftwareName.Name = "textBoxSoftwareName";
            this.textBoxSoftwareName.Size = new System.Drawing.Size(253, 20);
            this.textBoxSoftwareName.TabIndex = 64;
            this.textBoxSoftwareName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTitle_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Software Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 87);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 62;
            this.label18.Text = "Company";
            // 
            // textBoxCompany
            // 
            this.textBoxCompany.Location = new System.Drawing.Point(15, 103);
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.Size = new System.Drawing.Size(101, 20);
            this.textBoxCompany.TabIndex = 61;
            this.textBoxCompany.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTitle_KeyPress);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(217, 103);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(79, 20);
            this.textBoxPrice.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(123, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Category ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(214, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Price";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.maskedTextBoxSearchSoftware);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.buttonSearchSoftware);
            this.groupBox4.Location = new System.Drawing.Point(493, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(162, 194);
            this.groupBox4.TabIndex = 52;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Software";
            // 
            // maskedTextBoxSearchSoftware
            // 
            this.maskedTextBoxSearchSoftware.Location = new System.Drawing.Point(30, 76);
            this.maskedTextBoxSearchSoftware.Mask = "0000";
            this.maskedTextBoxSearchSoftware.Name = "maskedTextBoxSearchSoftware";
            this.maskedTextBoxSearchSoftware.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxSearchSoftware.TabIndex = 43;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Please enter Software ID:";
            // 
            // buttonSearchSoftware
            // 
            this.buttonSearchSoftware.Location = new System.Drawing.Point(43, 112);
            this.buttonSearchSoftware.Name = "buttonSearchSoftware";
            this.buttonSearchSoftware.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchSoftware.TabIndex = 41;
            this.buttonSearchSoftware.Text = "&Search";
            this.buttonSearchSoftware.UseVisualStyleBackColor = true;
            this.buttonSearchSoftware.Click += new System.EventHandler(this.buttonSearchSoftware_Click);
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.hiTechDataSet;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "Books";
            this.booksBindingSource1.DataSource = this.hiTechDataSet;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // publishersTableAdapter
            // 
            this.publishersTableAdapter.ClearBeforeFill = true;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // FormProductMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 476);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormProductMaintenance";
            this.Text = "Product Maintenance";
            this.Load += new System.EventHandler(this.ProductMaintenance_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiTechDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listViewBook;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox textBoxBookId;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxQOH;
        private System.Windows.Forms.TextBox textBoxYearPublished;
        private System.Windows.Forms.TextBox textBoxUnitPrice;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView listViewSoftware;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TextBox textBoxSoftwareID;
        private System.Windows.Forms.Button buttonExitSoftware;
        private System.Windows.Forms.Button buttonListSoftware;
        private System.Windows.Forms.Button buttonDeleteSoftware;
        private System.Windows.Forms.Button buttonUpdateSoftware;
        private System.Windows.Forms.Button buttonSaveSoftware;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonSearchSoftware;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.TextBox textBoxSoftwareName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxCategoryId;
        private WindowsFormsApplication1.HiTechDataSet hiTechDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private WindowsFormsApplication1.HiTechDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private WindowsFormsApplication1.HiTechDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingSource publishersBindingSource;
        private WindowsFormsApplication1.HiTechDataSetTableAdapters.PublishersTableAdapter publishersTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxAuthorId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxPublisherId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private WindowsFormsApplication1.HiTechDataSetTableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSearchBook;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSearchSoftware;
        private System.Windows.Forms.ComboBox comboBoxCatId;
        private System.Windows.Forms.TextBox textBoxQOHSoftware;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader columnHeader11;
    }
}