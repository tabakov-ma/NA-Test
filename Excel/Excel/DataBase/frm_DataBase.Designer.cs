namespace Excel.DataBase
{
  partial class frm_DataBase
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
      System.Windows.Forms.Label idLabel;
      System.Windows.Forms.Label fistNameLabel;
      System.Windows.Forms.Label lastNameLabel;
      System.Windows.Forms.Label bithdayLabel;
      System.Windows.Forms.Label genderLabel;
      System.Windows.Forms.Label idCompanyLabel;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DataBase));
      this.companyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.databaseDataSet = new Excel.DatabaseDataSet();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.companyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.companyDataGridView = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.personDataGridView = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fKPersonToCompanyTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.idTextBox = new System.Windows.Forms.TextBox();
      this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.fistNameTextBox = new System.Windows.Forms.TextBox();
      this.lastNameTextBox = new System.Windows.Forms.TextBox();
      this.bithdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.genderTextBox = new System.Windows.Forms.TextBox();
      this.idCompanyTextBox = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.personDataGridView1 = new System.Windows.Forms.DataGridView();
      this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fistNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bithdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.companyTableAdapter = new Excel.DatabaseDataSetTableAdapters.CompanyTableAdapter();
      this.tableAdapterManager = new Excel.DatabaseDataSetTableAdapters.TableAdapterManager();
      this.personTableAdapter = new Excel.DatabaseDataSetTableAdapters.PersonTableAdapter();
      this.personBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.ID = new System.Windows.Forms.TextBox();
      this.FN = new System.Windows.Forms.TextBox();
      this.LN = new System.Windows.Forms.TextBox();
      this.G = new System.Windows.Forms.TextBox();
      this.IDC = new System.Windows.Forms.TextBox();
      this.BD = new System.Windows.Forms.DateTimePicker();
      this.button2 = new System.Windows.Forms.Button();
      this.CreateBD_button = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.DeleteBD_button = new System.Windows.Forms.Button();
      this.NameBDtextBox = new System.Windows.Forms.ComboBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      idLabel = new System.Windows.Forms.Label();
      fistNameLabel = new System.Windows.Forms.Label();
      lastNameLabel = new System.Windows.Forms.Label();
      bithdayLabel = new System.Windows.Forms.Label();
      genderLabel = new System.Windows.Forms.Label();
      idCompanyLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.companyBindingNavigator)).BeginInit();
      this.companyBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.companyDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.personDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.fKPersonToCompanyTableBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.personDataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // idLabel
      // 
      idLabel.AutoSize = true;
      idLabel.Location = new System.Drawing.Point(461, 265);
      idLabel.Name = "idLabel";
      idLabel.Size = new System.Drawing.Size(19, 13);
      idLabel.TabIndex = 3;
      idLabel.Text = "Id:";
      // 
      // fistNameLabel
      // 
      fistNameLabel.AutoSize = true;
      fistNameLabel.Location = new System.Drawing.Point(461, 291);
      fistNameLabel.Name = "fistNameLabel";
      fistNameLabel.Size = new System.Drawing.Size(57, 13);
      fistNameLabel.TabIndex = 5;
      fistNameLabel.Text = "Fist Name:";
      // 
      // lastNameLabel
      // 
      lastNameLabel.AutoSize = true;
      lastNameLabel.Location = new System.Drawing.Point(461, 317);
      lastNameLabel.Name = "lastNameLabel";
      lastNameLabel.Size = new System.Drawing.Size(61, 13);
      lastNameLabel.TabIndex = 7;
      lastNameLabel.Text = "Last Name:";
      // 
      // bithdayLabel
      // 
      bithdayLabel.AutoSize = true;
      bithdayLabel.Location = new System.Drawing.Point(461, 344);
      bithdayLabel.Name = "bithdayLabel";
      bithdayLabel.Size = new System.Drawing.Size(45, 13);
      bithdayLabel.TabIndex = 9;
      bithdayLabel.Text = "Bithday:";
      // 
      // genderLabel
      // 
      genderLabel.AutoSize = true;
      genderLabel.Location = new System.Drawing.Point(461, 369);
      genderLabel.Name = "genderLabel";
      genderLabel.Size = new System.Drawing.Size(45, 13);
      genderLabel.TabIndex = 11;
      genderLabel.Text = "Gender:";
      // 
      // idCompanyLabel
      // 
      idCompanyLabel.AutoSize = true;
      idCompanyLabel.Location = new System.Drawing.Point(461, 395);
      idCompanyLabel.Name = "idCompanyLabel";
      idCompanyLabel.Size = new System.Drawing.Size(66, 13);
      idCompanyLabel.TabIndex = 13;
      idCompanyLabel.Text = "Id Company:";
      // 
      // companyBindingNavigator
      // 
      this.companyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.companyBindingNavigator.BindingSource = this.companyBindingSource;
      this.companyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.companyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.companyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.companyBindingNavigatorSaveItem});
      this.companyBindingNavigator.Location = new System.Drawing.Point(0, 0);
      this.companyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.companyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.companyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.companyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.companyBindingNavigator.Name = "companyBindingNavigator";
      this.companyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.companyBindingNavigator.Size = new System.Drawing.Size(1197, 25);
      this.companyBindingNavigator.TabIndex = 0;
      this.companyBindingNavigator.Text = "bindingNavigator1";
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorAddNewItem.Text = "Добавить";
      // 
      // companyBindingSource
      // 
      this.companyBindingSource.DataMember = "Company";
      this.companyBindingSource.DataSource = this.databaseDataSet;
      // 
      // databaseDataSet
      // 
      this.databaseDataSet.DataSetName = "DatabaseDataSet";
      this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
      this.bindingNavigatorCountItem.Text = "для {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorDeleteItem.Text = "Удалить";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "Положение";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // companyBindingNavigatorSaveItem
      // 
      this.companyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.companyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("companyBindingNavigatorSaveItem.Image")));
      this.companyBindingNavigatorSaveItem.Name = "companyBindingNavigatorSaveItem";
      this.companyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
      this.companyBindingNavigatorSaveItem.Text = "Сохранить данные";
      this.companyBindingNavigatorSaveItem.Click += new System.EventHandler(this.companyBindingNavigatorSaveItem_Click);
      // 
      // companyDataGridView
      // 
      this.companyDataGridView.AutoGenerateColumns = false;
      this.companyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.companyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
      this.companyDataGridView.DataSource = this.companyBindingSource;
      this.companyDataGridView.Location = new System.Drawing.Point(0, 28);
      this.companyDataGridView.Name = "companyDataGridView";
      this.companyDataGridView.Size = new System.Drawing.Size(404, 220);
      this.companyDataGridView.TabIndex = 1;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
      this.dataGridViewTextBoxColumn1.HeaderText = "Id";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "CompanuName";
      this.dataGridViewTextBoxColumn2.HeaderText = "CompanuName";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "Adress";
      this.dataGridViewTextBoxColumn3.HeaderText = "Adress";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.DataPropertyName = "Phone";
      this.dataGridViewTextBoxColumn4.HeaderText = "Phone";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.DataPropertyName = "Fax";
      this.dataGridViewTextBoxColumn5.HeaderText = "Fax";
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      // 
      // dataGridViewTextBoxColumn6
      // 
      this.dataGridViewTextBoxColumn6.DataPropertyName = "Email";
      this.dataGridViewTextBoxColumn6.HeaderText = "Email";
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      // 
      // personDataGridView
      // 
      this.personDataGridView.AutoGenerateColumns = false;
      this.personDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.personDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
      this.personDataGridView.DataSource = this.fKPersonToCompanyTableBindingSource;
      this.personDataGridView.Location = new System.Drawing.Point(0, 254);
      this.personDataGridView.Name = "personDataGridView";
      this.personDataGridView.Size = new System.Drawing.Size(404, 220);
      this.personDataGridView.TabIndex = 2;
      // 
      // dataGridViewTextBoxColumn7
      // 
      this.dataGridViewTextBoxColumn7.DataPropertyName = "Id";
      this.dataGridViewTextBoxColumn7.HeaderText = "Id";
      this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
      // 
      // dataGridViewTextBoxColumn8
      // 
      this.dataGridViewTextBoxColumn8.DataPropertyName = "FistName";
      this.dataGridViewTextBoxColumn8.HeaderText = "FistName";
      this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
      // 
      // dataGridViewTextBoxColumn9
      // 
      this.dataGridViewTextBoxColumn9.DataPropertyName = "LastName";
      this.dataGridViewTextBoxColumn9.HeaderText = "LastName";
      this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
      // 
      // dataGridViewTextBoxColumn10
      // 
      this.dataGridViewTextBoxColumn10.DataPropertyName = "Bithday";
      this.dataGridViewTextBoxColumn10.HeaderText = "Bithday";
      this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
      // 
      // dataGridViewTextBoxColumn11
      // 
      this.dataGridViewTextBoxColumn11.DataPropertyName = "Gender";
      this.dataGridViewTextBoxColumn11.HeaderText = "Gender";
      this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
      // 
      // dataGridViewTextBoxColumn12
      // 
      this.dataGridViewTextBoxColumn12.DataPropertyName = "IdCompany";
      this.dataGridViewTextBoxColumn12.HeaderText = "IdCompany";
      this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
      // 
      // fKPersonToCompanyTableBindingSource
      // 
      this.fKPersonToCompanyTableBindingSource.DataMember = "FK_Person_ToCompanyTable";
      this.fKPersonToCompanyTableBindingSource.DataSource = this.companyBindingSource;
      // 
      // idTextBox
      // 
      this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Id", true));
      this.idTextBox.Location = new System.Drawing.Point(533, 262);
      this.idTextBox.Name = "idTextBox";
      this.idTextBox.Size = new System.Drawing.Size(200, 20);
      this.idTextBox.TabIndex = 4;
      // 
      // personBindingSource
      // 
      this.personBindingSource.DataMember = "Person";
      this.personBindingSource.DataSource = this.databaseDataSet;
      // 
      // fistNameTextBox
      // 
      this.fistNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "FistName", true));
      this.fistNameTextBox.Location = new System.Drawing.Point(533, 288);
      this.fistNameTextBox.Name = "fistNameTextBox";
      this.fistNameTextBox.Size = new System.Drawing.Size(200, 20);
      this.fistNameTextBox.TabIndex = 6;
      // 
      // lastNameTextBox
      // 
      this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "LastName", true));
      this.lastNameTextBox.Location = new System.Drawing.Point(533, 314);
      this.lastNameTextBox.Name = "lastNameTextBox";
      this.lastNameTextBox.Size = new System.Drawing.Size(200, 20);
      this.lastNameTextBox.TabIndex = 8;
      // 
      // bithdayDateTimePicker
      // 
      this.bithdayDateTimePicker.Cursor = System.Windows.Forms.Cursors.Default;
      this.bithdayDateTimePicker.CustomFormat = "yyyy-MM-dd hh:mm:ss";
      this.bithdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personBindingSource, "Bithday", true));
      this.bithdayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.bithdayDateTimePicker.Location = new System.Drawing.Point(533, 340);
      this.bithdayDateTimePicker.Name = "bithdayDateTimePicker";
      this.bithdayDateTimePicker.Size = new System.Drawing.Size(200, 20);
      this.bithdayDateTimePicker.TabIndex = 10;
      // 
      // genderTextBox
      // 
      this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Gender", true));
      this.genderTextBox.Location = new System.Drawing.Point(533, 366);
      this.genderTextBox.Name = "genderTextBox";
      this.genderTextBox.Size = new System.Drawing.Size(200, 20);
      this.genderTextBox.TabIndex = 12;
      // 
      // idCompanyTextBox
      // 
      this.idCompanyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "IdCompany", true));
      this.idCompanyTextBox.Location = new System.Drawing.Point(533, 392);
      this.idCompanyTextBox.Name = "idCompanyTextBox";
      this.idCompanyTextBox.Size = new System.Drawing.Size(200, 20);
      this.idCompanyTextBox.TabIndex = 14;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(759, 421);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(149, 54);
      this.button1.TabIndex = 15;
      this.button1.Text = "Добавить";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // personDataGridView1
      // 
      this.personDataGridView1.AutoGenerateColumns = false;
      this.personDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.personDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fistNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.bithdayDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.idCompanyDataGridViewTextBoxColumn});
      this.personDataGridView1.DataSource = this.personBindingSource;
      this.personDataGridView1.Location = new System.Drawing.Point(437, 28);
      this.personDataGridView1.Name = "personDataGridView1";
      this.personDataGridView1.Size = new System.Drawing.Size(300, 220);
      this.personDataGridView1.TabIndex = 16;
      // 
      // idDataGridViewTextBoxColumn
      // 
      this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
      this.idDataGridViewTextBoxColumn.HeaderText = "Id";
      this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
      // 
      // fistNameDataGridViewTextBoxColumn
      // 
      this.fistNameDataGridViewTextBoxColumn.DataPropertyName = "FistName";
      this.fistNameDataGridViewTextBoxColumn.HeaderText = "FistName";
      this.fistNameDataGridViewTextBoxColumn.Name = "fistNameDataGridViewTextBoxColumn";
      // 
      // lastNameDataGridViewTextBoxColumn
      // 
      this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
      this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
      this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
      // 
      // bithdayDataGridViewTextBoxColumn
      // 
      this.bithdayDataGridViewTextBoxColumn.DataPropertyName = "Bithday";
      this.bithdayDataGridViewTextBoxColumn.HeaderText = "Bithday";
      this.bithdayDataGridViewTextBoxColumn.Name = "bithdayDataGridViewTextBoxColumn";
      // 
      // genderDataGridViewTextBoxColumn
      // 
      this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
      this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
      this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
      // 
      // idCompanyDataGridViewTextBoxColumn
      // 
      this.idCompanyDataGridViewTextBoxColumn.DataPropertyName = "IdCompany";
      this.idCompanyDataGridViewTextBoxColumn.HeaderText = "IdCompany";
      this.idCompanyDataGridViewTextBoxColumn.Name = "idCompanyDataGridViewTextBoxColumn";
      // 
      // dataGridViewTextBoxColumn13
      // 
      this.dataGridViewTextBoxColumn13.DataPropertyName = "Id";
      this.dataGridViewTextBoxColumn13.HeaderText = "Id";
      this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
      // 
      // dataGridViewTextBoxColumn14
      // 
      this.dataGridViewTextBoxColumn14.DataPropertyName = "FistName";
      this.dataGridViewTextBoxColumn14.HeaderText = "FistName";
      this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
      // 
      // dataGridViewTextBoxColumn15
      // 
      this.dataGridViewTextBoxColumn15.DataPropertyName = "LastName";
      this.dataGridViewTextBoxColumn15.HeaderText = "LastName";
      this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
      // 
      // dataGridViewTextBoxColumn16
      // 
      this.dataGridViewTextBoxColumn16.DataPropertyName = "Bithday";
      this.dataGridViewTextBoxColumn16.HeaderText = "Bithday";
      this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
      // 
      // dataGridViewTextBoxColumn17
      // 
      this.dataGridViewTextBoxColumn17.DataPropertyName = "Gender";
      this.dataGridViewTextBoxColumn17.HeaderText = "Gender";
      this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
      // 
      // dataGridViewTextBoxColumn18
      // 
      this.dataGridViewTextBoxColumn18.DataPropertyName = "IdCompany";
      this.dataGridViewTextBoxColumn18.HeaderText = "IdCompany";
      this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
      // 
      // companyTableAdapter
      // 
      this.companyTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.CompanyTableAdapter = this.companyTableAdapter;
      this.tableAdapterManager.PersonTableAdapter = this.personTableAdapter;
      this.tableAdapterManager.UpdateOrder = Excel.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // personTableAdapter
      // 
      this.personTableAdapter.ClearBeforeFill = true;
      // 
      // personBindingSource1
      // 
      this.personBindingSource1.DataMember = "Person";
      this.personBindingSource1.DataSource = this.databaseDataSet;
      // 
      // ID
      // 
      this.ID.Location = new System.Drawing.Point(759, 262);
      this.ID.Name = "ID";
      this.ID.Size = new System.Drawing.Size(173, 20);
      this.ID.TabIndex = 17;
      // 
      // FN
      // 
      this.FN.Location = new System.Drawing.Point(759, 291);
      this.FN.Name = "FN";
      this.FN.Size = new System.Drawing.Size(173, 20);
      this.FN.TabIndex = 18;
      // 
      // LN
      // 
      this.LN.Location = new System.Drawing.Point(759, 317);
      this.LN.Name = "LN";
      this.LN.Size = new System.Drawing.Size(173, 20);
      this.LN.TabIndex = 19;
      // 
      // G
      // 
      this.G.Location = new System.Drawing.Point(759, 366);
      this.G.Name = "G";
      this.G.Size = new System.Drawing.Size(173, 20);
      this.G.TabIndex = 20;
      // 
      // IDC
      // 
      this.IDC.Location = new System.Drawing.Point(759, 395);
      this.IDC.Name = "IDC";
      this.IDC.Size = new System.Drawing.Size(173, 20);
      this.IDC.TabIndex = 21;
      // 
      // BD
      // 
      this.BD.CustomFormat = "yyyy-MM-dd hh:mm:ss";
      this.BD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.BD.Location = new System.Drawing.Point(762, 342);
      this.BD.Name = "BD";
      this.BD.Size = new System.Drawing.Size(170, 20);
      this.BD.TabIndex = 22;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(764, 32);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(64, 33);
      this.button2.TabIndex = 23;
      this.button2.Text = "Обновить";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // CreateBD_button
      // 
      this.CreateBD_button.Location = new System.Drawing.Point(195, 19);
      this.CreateBD_button.Name = "CreateBD_button";
      this.CreateBD_button.Size = new System.Drawing.Size(59, 42);
      this.CreateBD_button.TabIndex = 24;
      this.CreateBD_button.Text = "Создать БД";
      this.CreateBD_button.UseVisualStyleBackColor = true;
      this.CreateBD_button.Click += new System.EventHandler(this.CreateBD_button_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.NameBDtextBox);
      this.groupBox1.Controls.Add(this.DeleteBD_button);
      this.groupBox1.Controls.Add(this.CreateBD_button);
      this.groupBox1.Location = new System.Drawing.Point(764, 91);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(320, 75);
      this.groupBox1.TabIndex = 25;
      this.groupBox1.TabStop = false;
      // 
      // DeleteBD_button
      // 
      this.DeleteBD_button.Location = new System.Drawing.Point(253, 19);
      this.DeleteBD_button.Name = "DeleteBD_button";
      this.DeleteBD_button.Size = new System.Drawing.Size(59, 42);
      this.DeleteBD_button.TabIndex = 25;
      this.DeleteBD_button.Text = "Удалить БД";
      this.DeleteBD_button.UseVisualStyleBackColor = true;
      this.DeleteBD_button.Click += new System.EventHandler(this.DeleteBD_button_Click);
      // 
      // NameBDtextBox
      // 
      this.NameBDtextBox.FormattingEnabled = true;
      this.NameBDtextBox.Location = new System.Drawing.Point(18, 19);
      this.NameBDtextBox.Name = "NameBDtextBox";
      this.NameBDtextBox.Size = new System.Drawing.Size(126, 21);
      this.NameBDtextBox.TabIndex = 27;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.comboBox1);
      this.groupBox2.Location = new System.Drawing.Point(767, 184);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(316, 63);
      this.groupBox2.TabIndex = 26;
      this.groupBox2.TabStop = false;
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(14, 20);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(126, 21);
      this.comboBox1.TabIndex = 0;
      // 
      // frm_DataBase
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1197, 522);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.BD);
      this.Controls.Add(this.IDC);
      this.Controls.Add(this.G);
      this.Controls.Add(this.LN);
      this.Controls.Add(this.FN);
      this.Controls.Add(this.ID);
      this.Controls.Add(this.personDataGridView1);
      this.Controls.Add(this.button1);
      this.Controls.Add(idLabel);
      this.Controls.Add(this.idTextBox);
      this.Controls.Add(fistNameLabel);
      this.Controls.Add(this.fistNameTextBox);
      this.Controls.Add(lastNameLabel);
      this.Controls.Add(this.lastNameTextBox);
      this.Controls.Add(bithdayLabel);
      this.Controls.Add(this.bithdayDateTimePicker);
      this.Controls.Add(genderLabel);
      this.Controls.Add(this.genderTextBox);
      this.Controls.Add(idCompanyLabel);
      this.Controls.Add(this.idCompanyTextBox);
      this.Controls.Add(this.personDataGridView);
      this.Controls.Add(this.companyDataGridView);
      this.Controls.Add(this.companyBindingNavigator);
      this.Name = "frm_DataBase";
      this.Text = "frm_DataBase";
      this.Load += new System.EventHandler(this.frm_DataBase_Load);
      ((System.ComponentModel.ISupportInitialize)(this.companyBindingNavigator)).EndInit();
      this.companyBindingNavigator.ResumeLayout(false);
      this.companyBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.companyDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.personDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.fKPersonToCompanyTableBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.personDataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private DatabaseDataSetTableAdapters.CompanyTableAdapter companyTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator companyBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton companyBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView companyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DatabaseDataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.DataGridView personDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox fistNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.DateTimePicker bithdayDateTimePicker;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox idCompanyTextBox;
        private System.Windows.Forms.BindingSource fKPersonToCompanyTableBindingSource;
        private System.Windows.Forms.BindingSource personBindingSource1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.DataGridView personDataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn fistNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn bithdayDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn idCompanyDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox FN;
        private System.Windows.Forms.TextBox LN;
        private System.Windows.Forms.TextBox G;
        private System.Windows.Forms.TextBox IDC;
        private System.Windows.Forms.DateTimePicker BD;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button CreateBD_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeleteBD_button;
        private System.Windows.Forms.ComboBox NameBDtextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}