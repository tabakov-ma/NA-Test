using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vscoder;

namespace TestDll
{
  public partial class Form1 : Form
  {
    vscode o = new vscode();
    public Form1()
    {
      InitializeComponent();
      
      for (int i= 0; i < o.version.Length; i++)
        {
        //cb_v.Items.Add(o.version[i,].ToString());
        }
       
      //for (int i = 0; i < o. Length; i++)
      //{
      //  cb_v.Items.Add(o.version[i]);
      //}
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //tb_equal.Text = o.add(Convert.ToInt32(tb_a.Text), Convert.ToInt32(tb_b.Text), Convert.ToInt32(cb_v.SelectedItem)).ToString();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      //tb_print.Text = o.Print();
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void cb_v_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
  }
}
