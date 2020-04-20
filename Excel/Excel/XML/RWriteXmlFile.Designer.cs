namespace Excel.XML
{
  partial class RWriteXmlFile
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.dataGridView2 = new System.Windows.Forms.DataGridView();
      this.Name_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Age_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Programmer = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.buttonAdd = new System.Windows.Forms.Button();
      this.buttonEdit = new System.Windows.Forms.Button();
      this.buttonRemuve = new System.Windows.Forms.Button();
      this.buttonLoad = new System.Windows.Forms.Button();
      this.buttonClearTab = new System.Windows.Forms.Button();
      this.buttonSave = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.buttonShipr = new System.Windows.Forms.Button();
      this.buttonUnShipr = new System.Windows.Forms.Button();
      this.textBoxPassword = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(58, 12);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(190, 20);
      this.textBox1.TabIndex = 0;
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.Location = new System.Drawing.Point(303, 13);
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new System.Drawing.Size(45, 20);
      this.numericUpDown1.TabIndex = 1;
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "true",
            "false"});
      this.comboBox1.Location = new System.Drawing.Point(453, 13);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(63, 21);
      this.comboBox1.TabIndex = 2;
      this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(17, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Name";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(262, 13);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(26, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Age";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(365, 12);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(63, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Programmer";
      this.label3.Click += new System.EventHandler(this.label3_Click);
      // 
      // dataGridView2
      // 
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_,
            this.Age_,
            this.Programmer});
      this.dataGridView2.Location = new System.Drawing.Point(20, 76);
      this.dataGridView2.Name = "dataGridView2";
      this.dataGridView2.ReadOnly = true;
      this.dataGridView2.Size = new System.Drawing.Size(493, 218);
      this.dataGridView2.TabIndex = 6;
      this.dataGridView2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
      // 
      // Name_
      // 
      this.Name_.Frozen = true;
      this.Name_.HeaderText = "Name";
      this.Name_.Name = "Name_";
      this.Name_.ReadOnly = true;
      this.Name_.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.Name_.Width = 250;
      // 
      // Age_
      // 
      this.Age_.Frozen = true;
      this.Age_.HeaderText = "Age";
      this.Age_.Name = "Age_";
      this.Age_.ReadOnly = true;
      this.Age_.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      // 
      // Programmer
      // 
      this.Programmer.Frozen = true;
      this.Programmer.HeaderText = "Programmer";
      this.Programmer.Name = "Programmer";
      this.Programmer.ReadOnly = true;
      this.Programmer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.Programmer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      // 
      // buttonAdd
      // 
      this.buttonAdd.Location = new System.Drawing.Point(20, 47);
      this.buttonAdd.Name = "buttonAdd";
      this.buttonAdd.Size = new System.Drawing.Size(162, 21);
      this.buttonAdd.TabIndex = 7;
      this.buttonAdd.Text = "Добавить";
      this.buttonAdd.UseVisualStyleBackColor = true;
      this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
      // 
      // buttonEdit
      // 
      this.buttonEdit.Location = new System.Drawing.Point(188, 47);
      this.buttonEdit.Name = "buttonEdit";
      this.buttonEdit.Size = new System.Drawing.Size(162, 21);
      this.buttonEdit.TabIndex = 8;
      this.buttonEdit.Text = "Редактировать";
      this.buttonEdit.UseVisualStyleBackColor = true;
      this.buttonEdit.Click += new System.EventHandler(this.button2_Click);
      // 
      // buttonRemuve
      // 
      this.buttonRemuve.Location = new System.Drawing.Point(356, 47);
      this.buttonRemuve.Name = "buttonRemuve";
      this.buttonRemuve.Size = new System.Drawing.Size(162, 21);
      this.buttonRemuve.TabIndex = 9;
      this.buttonRemuve.Text = "Удалить";
      this.buttonRemuve.UseVisualStyleBackColor = true;
      this.buttonRemuve.Click += new System.EventHandler(this.button3_Click);
      // 
      // buttonLoad
      // 
      this.buttonLoad.Location = new System.Drawing.Point(356, 300);
      this.buttonLoad.Name = "buttonLoad";
      this.buttonLoad.Size = new System.Drawing.Size(162, 21);
      this.buttonLoad.TabIndex = 12;
      this.buttonLoad.Text = "Загрузить XML";
      this.buttonLoad.UseVisualStyleBackColor = true;
      this.buttonLoad.Click += new System.EventHandler(this.button4_Click);
      // 
      // buttonClearTab
      // 
      this.buttonClearTab.Location = new System.Drawing.Point(188, 300);
      this.buttonClearTab.Name = "buttonClearTab";
      this.buttonClearTab.Size = new System.Drawing.Size(162, 21);
      this.buttonClearTab.TabIndex = 11;
      this.buttonClearTab.Text = "Очистить таблицу";
      this.buttonClearTab.UseVisualStyleBackColor = true;
      this.buttonClearTab.Click += new System.EventHandler(this.button5_Click);
      // 
      // buttonSave
      // 
      this.buttonSave.Location = new System.Drawing.Point(20, 300);
      this.buttonSave.Name = "buttonSave";
      this.buttonSave.Size = new System.Drawing.Size(162, 21);
      this.buttonSave.TabIndex = 10;
      this.buttonSave.Text = "Сохранить как XML";
      this.buttonSave.UseVisualStyleBackColor = true;
      this.buttonSave.Click += new System.EventHandler(this.button6_Click);
      // 
      // dataGridView1
      // 
      dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(519, 76);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(389, 218);
      this.dataGridView1.TabIndex = 13;
      this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
      // 
      // buttonShipr
      // 
      this.buttonShipr.Location = new System.Drawing.Point(536, 300);
      this.buttonShipr.Name = "buttonShipr";
      this.buttonShipr.Size = new System.Drawing.Size(133, 21);
      this.buttonShipr.TabIndex = 14;
      this.buttonShipr.Text = "Шифровать";
      this.buttonShipr.UseVisualStyleBackColor = true;
      this.buttonShipr.Click += new System.EventHandler(this.buttonShipr_Click);
      // 
      // buttonUnShipr
      // 
      this.buttonUnShipr.Location = new System.Drawing.Point(775, 300);
      this.buttonUnShipr.Name = "buttonUnShipr";
      this.buttonUnShipr.Size = new System.Drawing.Size(133, 21);
      this.buttonUnShipr.TabIndex = 15;
      this.buttonUnShipr.Text = "ДеШифровать";
      this.buttonUnShipr.UseVisualStyleBackColor = true;
      this.buttonUnShipr.Click += new System.EventHandler(this.buttonUnShipr_Click);
      // 
      // textBoxPassword
      // 
      this.textBoxPassword.Location = new System.Drawing.Point(671, 301);
      this.textBoxPassword.Name = "textBoxPassword";
      this.textBoxPassword.Size = new System.Drawing.Size(98, 20);
      this.textBoxPassword.TabIndex = 16;
      this.textBoxPassword.Text = "пароль";
      // 
      // RWriteXmlFile
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(925, 337);
      this.Controls.Add(this.textBoxPassword);
      this.Controls.Add(this.buttonUnShipr);
      this.Controls.Add(this.buttonShipr);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.buttonLoad);
      this.Controls.Add(this.buttonClearTab);
      this.Controls.Add(this.buttonSave);
      this.Controls.Add(this.buttonRemuve);
      this.Controls.Add(this.buttonEdit);
      this.Controls.Add(this.buttonAdd);
      this.Controls.Add(this.dataGridView2);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.numericUpDown1);
      this.Controls.Add(this.textBox1);
      this.Name = "RWriteXmlFile";
      this.Text = "RWriteXmlFile";
      this.Load += new System.EventHandler(this.RWriteXmlFile_Load);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonRemuve;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonClearTab;
        private System.Windows.Forms.Button buttonSave;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Name_;
    private System.Windows.Forms.DataGridViewTextBoxColumn Age_;
    private System.Windows.Forms.DataGridViewCheckBoxColumn Programmer;
    private System.Windows.Forms.Button buttonShipr;
    private System.Windows.Forms.Button buttonUnShipr;
    private System.Windows.Forms.TextBox textBoxPassword;
  }
}