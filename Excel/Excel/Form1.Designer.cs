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
      this.button1 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.tb_patch = new System.Windows.Forms.TextBox();
      this.btn_saveAs = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.полTableAdapter1 = new Excel.DataSet1TableAdapters.ПолTableAdapter();
      this.человекTableAdapter1 = new Excel.DataSet1TableAdapters.ЧеловекTableAdapter();
      this.dataSet11 = new Excel.DataSet1();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.полBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.полBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.dataGridView2 = new System.Windows.Forms.DataGridView();
      this.fKЧеловекПолBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.iDЧеловекаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fKЧеловекПолBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.tabPage2.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.полBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.полBindingSource1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.fKЧеловекПолBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.fKЧеловекПолBindingSource1)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(10, 69);
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
      this.label1.Location = new System.Drawing.Point(324, 46);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(61, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Генерация";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(11, 107);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(86, 34);
      this.button2.TabIndex = 2;
      this.button2.Text = "Открытие";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // tb_patch
      // 
      this.tb_patch.Location = new System.Drawing.Point(6, 43);
      this.tb_patch.Name = "tb_patch";
      this.tb_patch.Size = new System.Drawing.Size(290, 20);
      this.tb_patch.TabIndex = 3;
      this.tb_patch.TextChanged += new System.EventHandler(this.tb_patch_TextChanged);
      // 
      // btn_saveAs
      // 
      this.btn_saveAs.Location = new System.Drawing.Point(6, 6);
      this.btn_saveAs.Name = "btn_saveAs";
      this.btn_saveAs.Size = new System.Drawing.Size(91, 31);
      this.btn_saveAs.TabIndex = 4;
      this.btn_saveAs.Text = "Сохранить";
      this.btn_saveAs.UseVisualStyleBackColor = true;
      this.btn_saveAs.Click += new System.EventHandler(this.btn_saveAs_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(192, 223);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(96, 23);
      this.button3.TabIndex = 10;
      this.button3.Text = "Save";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click_1);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(72, 220);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(92, 26);
      this.button4.TabIndex = 12;
      this.button4.Text = "Update";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.btn_saveAs);
      this.tabPage2.Controls.Add(this.tb_patch);
      this.tabPage2.Controls.Add(this.button1);
      this.tabPage2.Controls.Add(this.label1);
      this.tabPage2.Controls.Add(this.button2);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(657, 289);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "tabPage2";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.dataGridView2);
      this.tabPage1.Controls.Add(this.dataGridView1);
      this.tabPage1.Controls.Add(this.button3);
      this.tabPage1.Controls.Add(this.button4);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(657, 289);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "tabPage1";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(1, 1);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(665, 315);
      this.tabControl1.TabIndex = 13;
      // 
      // полTableAdapter1
      // 
      this.полTableAdapter1.ClearBeforeFill = true;
      // 
      // человекTableAdapter1
      // 
      this.человекTableAdapter1.ClearBeforeFill = true;
      // 
      // dataSet11
      // 
      this.dataSet11.DataSetName = "DataSet1";
      this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
      this.dataGridView1.DataSource = this.полBindingSource1;
      this.dataGridView1.Location = new System.Drawing.Point(19, 17);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(268, 179);
      this.dataGridView1.TabIndex = 13;
      // 
      // полBindingSource
      // 
      this.полBindingSource.DataMember = "Пол";
      this.полBindingSource.DataSource = this.dataSet11;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Пола";
      this.dataGridViewTextBoxColumn1.HeaderText = "ID_Пола";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "Пол";
      this.dataGridViewTextBoxColumn2.HeaderText = "Пол";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // полBindingSource1
      // 
      this.полBindingSource1.DataMember = "Пол";
      this.полBindingSource1.DataSource = this.dataSet11;
      // 
      // dataGridView2
      // 
      this.dataGridView2.AutoGenerateColumns = false;
      this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDЧеловекаDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3});
      this.dataGridView2.DataSource = this.fKЧеловекПолBindingSource1;
      this.dataGridView2.Location = new System.Drawing.Point(307, 21);
      this.dataGridView2.Name = "dataGridView2";
      this.dataGridView2.Size = new System.Drawing.Size(283, 174);
      this.dataGridView2.TabIndex = 14;
      // 
      // fKЧеловекПолBindingSource
      // 
      this.fKЧеловекПолBindingSource.DataMember = "FK_Человек_Пол";
      this.fKЧеловекПолBindingSource.DataSource = this.полBindingSource;
      // 
      // iDЧеловекаDataGridViewTextBoxColumn
      // 
      this.iDЧеловекаDataGridViewTextBoxColumn.DataPropertyName = "ID_Человека";
      this.iDЧеловекаDataGridViewTextBoxColumn.HeaderText = "ID_Человека";
      this.iDЧеловекаDataGridViewTextBoxColumn.Name = "iDЧеловекаDataGridViewTextBoxColumn";
      this.iDЧеловекаDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // имяDataGridViewTextBoxColumn
      // 
      this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
      this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
      this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "Пол";
      this.dataGridViewTextBoxColumn3.HeaderText = "Пол";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      // 
      // fKЧеловекПолBindingSource1
      // 
      this.fKЧеловекПолBindingSource1.DataMember = "FK_Человек_Пол";
      this.fKЧеловекПолBindingSource1.DataSource = this.полBindingSource1;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(667, 320);
      this.Controls.Add(this.tabControl1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.tabPage1.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.полBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.полBindingSource1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.fKЧеловекПолBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.fKЧеловекПолBindingSource1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_patch;
        private System.Windows.Forms.Button btn_saveAs;
        private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabControl tabControl1;
        //private Excel.Database1DataSetPolTableAdapters.ПолTableAdapter полTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПолаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridView dataGridView2;
    private System.Windows.Forms.DataGridViewTextBoxColumn iDЧеловекаDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.BindingSource fKЧеловекПолBindingSource;
    private System.Windows.Forms.BindingSource полBindingSource;
    private Excel.DataSet1 dataSet11;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.BindingSource полBindingSource1;
    private Excel.DataSet1TableAdapters.ПолTableAdapter полTableAdapter1;
    private Excel.DataSet1TableAdapters.ЧеловекTableAdapter человекTableAdapter1;
    private System.Windows.Forms.BindingSource fKЧеловекПолBindingSource1;
  }
}

