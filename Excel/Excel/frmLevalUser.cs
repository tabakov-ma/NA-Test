using Excel.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excel
{
  public partial class frmLevalUser : Form
  {
    Timer timer;
    public frmLevalUser()
    {
      InitializeComponent();
      this.textBox1.Text = Settings.Default.CurLevalUser.ToString();

    }

    private void button1_Click(object sender, EventArgs e)
    {
      ChekLevalUser(sender, Settings.Default.CurLevalUser);
    }

    public bool ChekLevalUser(object sender, int value)
    {

      if (sender is Button && value >= int.Parse((sender as Button).Tag.ToString())) { return true; }
      if (sender is TextBox && (sender as TextBox).Tag != null && value >= int.Parse((sender as TextBox).Tag.ToString())) { return true; }

      MessageBox.Show(text: "   " + "Не достаточно уровня доступа" + "\n" + "для данной операции!",
                   caption: "Предупреждение",
                   buttons: MessageBoxButtons.OK,
                      icon: MessageBoxIcon.Warning,
             defaultButton: MessageBoxDefaultButton.Button1);
      return false;

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      if (ChekLevalUser(sender, Settings.Default.CurLevalUser)) return;
      Settings.Default.CurLevalUser = int.Parse((sender as TextBox).Text);
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
      //if ((sender as TextBox).Text != "") Settings.Default.CurLevalUser = int.Parse((sender as TextBox).Text); else (sender as TextBox).Text = "0";
    }

    private void frmLevalUser_Load(object sender, EventArgs e)
    {
      timer = new Timer();
      timer.Interval = 100;
      timer.Tick += new EventHandler(Timer_Tick);
      timer.Start();
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
      this.lbl_lavelUser.Text = Settings.Default.CurLevalUser.ToString();

    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == 13 && ChekLevalUser(sender, Settings.Default.CurLevalUser))
      {
        int num;
        bool isNum = int.TryParse((sender as TextBox).Text, out num);
        if (isNum) Settings.Default.CurLevalUser = num;
      }
    }

    private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == 13)
      {
        int num;
        bool isNum = int.TryParse((sender as TextBox).Text, out num);
        if (isNum) Settings.Default.CurLevalUser = num;


      }
    }
  }
}
