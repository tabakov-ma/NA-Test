namespace Excel
{
  partial class frmLevalUser
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
      this.button1 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.lbl_lavelUser = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(113, 79);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(139, 43);
      this.button1.TabIndex = 0;
      this.button1.Tag = "60";
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(454, 76);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(107, 20);
      this.textBox1.TabIndex = 1;
      this.textBox1.Tag = "99";
      this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(454, 187);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(107, 20);
      this.textBox2.TabIndex = 2;
      this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
      this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(104, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(97, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Уровень доступа:";
      // 
      // lbl_lavelUser
      // 
      this.lbl_lavelUser.AutoSize = true;
      this.lbl_lavelUser.Location = new System.Drawing.Point(227, 10);
      this.lbl_lavelUser.Name = "lbl_lavelUser";
      this.lbl_lavelUser.Size = new System.Drawing.Size(51, 13);
      this.lbl_lavelUser.TabIndex = 4;
      this.lbl_lavelUser.Text = "lavelUser";
      // 
      // frmLevalUser
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.lbl_lavelUser);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.button1);
      this.Name = "frmLevalUser";
      this.Text = "frmLevalUser";
      this.Load += new System.EventHandler(this.frmLevalUser_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_lavelUser;
    }
}