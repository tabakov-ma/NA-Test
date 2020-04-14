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
      this.button1 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.tb_patch = new System.Windows.Forms.TextBox();
      this.btn_saveAs = new System.Windows.Forms.Button();
      this.SuspendLayout();
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
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(314, 132);
      this.Controls.Add(this.btn_saveAs);
      this.Controls.Add(this.tb_patch);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_patch;
        private System.Windows.Forms.Button btn_saveAs;
    }
}

