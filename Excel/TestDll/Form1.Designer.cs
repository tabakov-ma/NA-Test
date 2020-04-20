namespace TestDll
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
      this.cb_v = new System.Windows.Forms.ComboBox();
      this.tb_print = new System.Windows.Forms.TextBox();
      this.button2 = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.cb_model = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // cb_v
      // 
      this.cb_v.FormattingEnabled = true;
      this.cb_v.Location = new System.Drawing.Point(101, 58);
      this.cb_v.Name = "cb_v";
      this.cb_v.Size = new System.Drawing.Size(94, 21);
      this.cb_v.TabIndex = 0;
      this.cb_v.SelectedIndexChanged += new System.EventHandler(this.cb_v_SelectedIndexChanged);
      // 
      // tb_print
      // 
      this.tb_print.Location = new System.Drawing.Point(101, 107);
      this.tb_print.MaximumSize = new System.Drawing.Size(400, 200);
      this.tb_print.MaxLength = 3276700;
      this.tb_print.MinimumSize = new System.Drawing.Size(400, 200);
      this.tb_print.Multiline = true;
      this.tb_print.Name = "tb_print";
      this.tb_print.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.tb_print.Size = new System.Drawing.Size(400, 200);
      this.tb_print.TabIndex = 6;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(33, 107);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(62, 26);
      this.button2.TabIndex = 7;
      this.button2.Text = "Print";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(51, 61);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(44, 13);
      this.label2.TabIndex = 8;
      this.label2.Text = "Версия";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(51, 25);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(46, 13);
      this.label1.TabIndex = 10;
      this.label1.Text = "Модель";
      // 
      // cb_model
      // 
      this.cb_model.FormattingEnabled = true;
      this.cb_model.Location = new System.Drawing.Point(101, 22);
      this.cb_model.Name = "cb_model";
      this.cb_model.Size = new System.Drawing.Size(94, 21);
      this.cb_model.TabIndex = 9;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cb_model);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.tb_print);
      this.Controls.Add(this.cb_v);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.ComboBox cb_v;
        private System.Windows.Forms.TextBox tb_print;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_model;
    }
}

