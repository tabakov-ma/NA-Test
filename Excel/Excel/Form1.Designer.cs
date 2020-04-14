namespace ExcelTest
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.Label idLabel;
      System.Windows.Forms.Label nameLabel;
      this.button1 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.tb_patch = new System.Windows.Forms.TextBox();
      this.btn_saveAs = new System.Windows.Forms.Button();
      this.idTextBox = new System.Windows.Forms.TextBox();
      this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.database1DataSet1 = new Excel.Database1DataSet1();
      this.nameTextBox = new System.Windows.Forms.TextBox();
      this.tableDataGridView = new System.Windows.Forms.DataGridView();
      this.tableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
      this.database1DataSet3 = new Excel.Database1DataSet3();
      this.button3 = new System.Windows.Forms.Button();
      this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.dataSet1 = new Excel.DataSet1();
      this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.database1DataSet = new Excel.Database1DataSet();
      this.tableTableAdapter = new Excel.Database1DataSet1TableAdapters.TableTableAdapter();
      this.tableAdapterManager = new Excel.Database1DataSet1TableAdapters.TableAdapterManager();
      this.database1DataSet2 = new Excel.Database1DataSet2();
      this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.tableTableAdapter1 = new Excel.Database1DataSet2TableAdapters.TableTableAdapter();
      this.tableTableAdapter2 = new Excel.Database1DataSet3TableAdapters.TableTableAdapter();
      this.database1DataSet4 = new Excel.Database1DataSet4();
      this.table2BindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.table2TableAdapter = new Excel.Database1DataSet4TableAdapters.Table2TableAdapter();
      this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.familiyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      idLabel = new System.Windows.Forms.Label();
      nameLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.table2BindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // idLabel
      // 
      idLabel.AutoSize = true;
      idLabel.Location = new System.Drawing.Point(398, 123);
      idLabel.Name = "idLabel";
      idLabel.Size = new System.Drawing.Size(19, 13);
      idLabel.TabIndex = 6;
      idLabel.Text = "Id:";
      // 
      // nameLabel
      // 
      nameLabel.AutoSize = true;
      nameLabel.Location = new System.Drawing.Point(398, 149);
      nameLabel.Name = "nameLabel";
      nameLabel.Size = new System.Drawing.Size(38, 13);
      nameLabel.TabIndex = 8;
      nameLabel.Text = "Name:";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(140, 13);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(87, 32);
      this.button1.TabIndex = 0;
      this.button1.Text = "Книжная А4";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(43, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(61, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Генерация";
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(216, 69);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(86, 34);
      this.button2.TabIndex = 2;
      this.button2.Text = "Открытие";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // tb_patch
      // 
      this.tb_patch.Location = new System.Drawing.Point(12, 109);
      this.tb_patch.Name = "tb_patch";
      this.tb_patch.Size = new System.Drawing.Size(290, 20);
      this.tb_patch.TabIndex = 3;
      this.tb_patch.TextChanged += new System.EventHandler(this.tb_patch_TextChanged);
      // 
      // btn_saveAs
      // 
      this.btn_saveAs.Location = new System.Drawing.Point(12, 71);
      this.btn_saveAs.Name = "btn_saveAs";
      this.btn_saveAs.Size = new System.Drawing.Size(91, 31);
      this.btn_saveAs.TabIndex = 4;
      this.btn_saveAs.Text = "Сохранить";
      this.btn_saveAs.UseVisualStyleBackColor = true;
      this.btn_saveAs.Click += new System.EventHandler(this.btn_saveAs_Click);
      // 
      // idTextBox
      // 
      this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Id", true));
      this.idTextBox.Location = new System.Drawing.Point(442, 120);
      this.idTextBox.Name = "idTextBox";
      this.idTextBox.Size = new System.Drawing.Size(100, 20);
      this.idTextBox.TabIndex = 7;
      // 
      // tableBindingSource
      // 
      this.tableBindingSource.DataMember = "Table";
      this.tableBindingSource.DataSource = this.database1DataSet1;
      // 
      // database1DataSet1
      // 
      this.database1DataSet1.DataSetName = "Database1DataSet1";
      this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // nameTextBox
      // 
      this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Name", true));
      this.nameTextBox.Location = new System.Drawing.Point(442, 146);
      this.nameTextBox.Name = "nameTextBox";
      this.nameTextBox.Size = new System.Drawing.Size(100, 20);
      this.nameTextBox.TabIndex = 9;
      // 
      // tableDataGridView
      // 
      this.tableDataGridView.AutoGenerateColumns = false;
      this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.tableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.familiyaDataGridViewTextBoxColumn});
      this.tableDataGridView.DataSource = this.table2BindingSource;
      this.tableDataGridView.Location = new System.Drawing.Point(46, 189);
      this.tableDataGridView.Name = "tableDataGridView";
      this.tableDataGridView.Size = new System.Drawing.Size(356, 220);
      this.tableDataGridView.TabIndex = 9;
      // 
      // tableBindingSource2
      // 
      this.tableBindingSource2.DataMember = "Table";
      this.tableBindingSource2.DataSource = this.database1DataSet3;
      // 
      // database1DataSet3
      // 
      this.database1DataSet3.DataSetName = "Database1DataSet3";
      this.database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(445, 248);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(96, 41);
      this.button3.TabIndex = 10;
      this.button3.Text = "button3";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click_1);
      // 
      // dataTable1BindingSource1
      // 
      this.dataTable1BindingSource1.DataMember = "DataTable1";
      this.dataTable1BindingSource1.DataSource = this.dataSet1;
      // 
      // dataSet1
      // 
      this.dataSet1.DataSetName = "DataSet1";
      this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // dataSet1BindingSource
      // 
      this.dataSet1BindingSource.DataSource = this.dataSet1;
      this.dataSet1BindingSource.Position = 0;
      // 
      // dataTable1BindingSource
      // 
      this.dataTable1BindingSource.DataMember = "DataTable1";
      this.dataTable1BindingSource.DataSource = this.dataSet1;
      // 
      // database1DataSetBindingSource
      // 
      this.database1DataSetBindingSource.DataSource = this.database1DataSet;
      this.database1DataSetBindingSource.Position = 0;
      // 
      // database1DataSet
      // 
      this.database1DataSet.DataSetName = "Database1DataSet";
      this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // tableTableAdapter
      // 
      this.tableTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
      this.tableAdapterManager.UpdateOrder = Excel.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // database1DataSet2
      // 
      this.database1DataSet2.DataSetName = "Database1DataSet2";
      this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // tableBindingSource1
      // 
      this.tableBindingSource1.DataMember = "Table";
      this.tableBindingSource1.DataSource = this.database1DataSet2;
      // 
      // tableTableAdapter1
      // 
      this.tableTableAdapter1.ClearBeforeFill = true;
      // 
      // tableTableAdapter2
      // 
      this.tableTableAdapter2.ClearBeforeFill = true;
      // 
      // database1DataSet4
      // 
      this.database1DataSet4.DataSetName = "Database1DataSet4";
      this.database1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // table2BindingSource
      // 
      this.table2BindingSource.DataMember = "Table2";
      this.table2BindingSource.DataSource = this.database1DataSet4;
      // 
      // table2TableAdapter
      // 
      this.table2TableAdapter.ClearBeforeFill = true;
      // 
      // idDataGridViewTextBoxColumn
      // 
      this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
      this.idDataGridViewTextBoxColumn.HeaderText = "Id";
      this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
      // 
      // nameDataGridViewTextBoxColumn
      // 
      this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
      this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
      this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
      // 
      // familiyaDataGridViewTextBoxColumn
      // 
      this.familiyaDataGridViewTextBoxColumn.DataPropertyName = "Familiya";
      this.familiyaDataGridViewTextBoxColumn.HeaderText = "Familiya";
      this.familiyaDataGridViewTextBoxColumn.Name = "familiyaDataGridViewTextBoxColumn";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(649, 445);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.tableDataGridView);
      this.Controls.Add(idLabel);
      this.Controls.Add(this.idTextBox);
      this.Controls.Add(nameLabel);
      this.Controls.Add(this.nameTextBox);
      this.Controls.Add(this.btn_saveAs);
      this.Controls.Add(this.tb_patch);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.table2BindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_patch;
        private System.Windows.Forms.Button btn_saveAs;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private Excel.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Excel.Database1DataSet database1DataSet;
        private Excel.Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private Excel.Database1DataSet1TableAdapters.TableTableAdapter tableTableAdapter;
        private Excel.Database1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.Button button3;
    private Excel.Database1DataSet2 database1DataSet2;
    private System.Windows.Forms.BindingSource tableBindingSource1;
    private Excel.Database1DataSet2TableAdapters.TableTableAdapter tableTableAdapter1;
    private Excel.Database1DataSet3 database1DataSet3;
    private System.Windows.Forms.BindingSource tableBindingSource2;
    private Excel.Database1DataSet3TableAdapters.TableTableAdapter tableTableAdapter2;
    private Excel.Database1DataSet4 database1DataSet4;
    private System.Windows.Forms.BindingSource table2BindingSource;
    private Excel.Database1DataSet4TableAdapters.Table2TableAdapter table2TableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn familiyaDataGridViewTextBoxColumn;
  }
}

