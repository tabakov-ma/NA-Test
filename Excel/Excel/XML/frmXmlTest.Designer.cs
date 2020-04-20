namespace ExcelTest
{
  partial class frmXmlTest
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
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
      this.cbKindOfProps = new System.Windows.Forms.ComboBox();
      this.databaseDataSet = new Excel.DatabaseDataSet();
      this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.personTableAdapter = new Excel.DatabaseDataSetTableAdapters.PersonTableAdapter();
      this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.companyTableAdapter = new Excel.DatabaseDataSetTableAdapters.CompanyTableAdapter();
      this.prgProperty = new System.Windows.Forms.PropertyGrid();
      ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new System.Drawing.Point(18, 13);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(268, 95);
      this.listBox1.TabIndex = 0;
      this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
      // 
      // propertyGrid1
      // 
      this.propertyGrid1.HelpVisible = false;
      this.propertyGrid1.Location = new System.Drawing.Point(18, 112);
      this.propertyGrid1.Name = "propertyGrid1";
      this.propertyGrid1.Size = new System.Drawing.Size(268, 107);
      this.propertyGrid1.TabIndex = 1;
      // 
      // cbKindOfProps
      // 
      this.cbKindOfProps.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.companyBindingSource, "Id", true));
      this.cbKindOfProps.FormattingEnabled = true;
      this.cbKindOfProps.Items.AddRange(new object[] {
            "Example of PropertyGrid for TextField",
            "Example of PropertyGrid for True/False field",
            "Example of PropertyGrid for Categories",
            "Example of PropertyGrid for Color field",
            "Example of PropertyGrid for Font field",
            "Example of PropertyGrid for Enum"});
      this.cbKindOfProps.Location = new System.Drawing.Point(304, 16);
      this.cbKindOfProps.Name = "cbKindOfProps";
      this.cbKindOfProps.Size = new System.Drawing.Size(268, 21);
      this.cbKindOfProps.TabIndex = 2;
      this.cbKindOfProps.SelectedIndexChanged += new System.EventHandler(this.cbKindOfProps_SelectedIndexChanged);
      // 
      // databaseDataSet
      // 
      this.databaseDataSet.DataSetName = "DatabaseDataSet";
      this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // personBindingSource
      // 
      this.personBindingSource.DataMember = "Person";
      this.personBindingSource.DataSource = this.databaseDataSet;
      // 
      // personTableAdapter
      // 
      this.personTableAdapter.ClearBeforeFill = true;
      // 
      // companyBindingSource
      // 
      this.companyBindingSource.DataMember = "Company";
      this.companyBindingSource.DataSource = this.databaseDataSet;
      // 
      // companyTableAdapter
      // 
      this.companyTableAdapter.ClearBeforeFill = true;
      // 
      // prgProperty
      // 
      this.prgProperty.Location = new System.Drawing.Point(304, 43);
      this.prgProperty.Name = "prgProperty";
      this.prgProperty.Size = new System.Drawing.Size(268, 175);
      this.prgProperty.TabIndex = 3;
      // 
      // frmXmlTest
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(590, 238);
      this.Controls.Add(this.prgProperty);
      this.Controls.Add(this.cbKindOfProps);
      this.Controls.Add(this.propertyGrid1);
      this.Controls.Add(this.listBox1);
      this.Name = "frmXmlTest";
      this.Text = "frmXmlTest";
      this.Load += new System.EventHandler(this.frmXmlTest_Load);
      ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.PropertyGrid propertyGrid1;
    private System.Windows.Forms.ComboBox cbKindOfProps;
    private Excel.DatabaseDataSet databaseDataSet;
    private System.Windows.Forms.BindingSource personBindingSource;
    private Excel.DatabaseDataSetTableAdapters.PersonTableAdapter personTableAdapter;
    private System.Windows.Forms.BindingSource companyBindingSource;
    private Excel.DatabaseDataSetTableAdapters.CompanyTableAdapter companyTableAdapter;
    private System.Windows.Forms.PropertyGrid prgProperty;
  }
}