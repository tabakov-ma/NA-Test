using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excel.DataBase
{
  public partial class frm_DataBase : Form
  {
    public frm_DataBase()
    {
      InitializeComponent();
      FindFileFillComBox(this.NameBDtextBox, "*.mdf");
    }

        private void companyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.companyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void frm_DataBase_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Person". При необходимости она может быть перемещена или удалена.
            this.personTableAdapter.Fill(this.databaseDataSet.Person);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Company". При необходимости она может быть перемещена или удалена.
            this.companyTableAdapter.Fill(this.databaseDataSet.Company);

        }

    private void button1_Click(object sender, EventArgs e)
    {
      //Строка подключения
      string strConn = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\DataBase\Database.mdf; Integrated Security = True";
      SqlConnection Conn = new SqlConnection(strConn);
      try
      {
        Conn.Open();
      }
      catch (Exception exceptionObj)
      {
        MessageBox.Show(exceptionObj.Message.ToString());
      }
      //Заголовок SQL -предложения Insert ...
      string sInsSql = this.IDC.Text != "" ? @"Insert into Person(Id, FistName, LastName, Bithday, Gender, IdCompany) " +
                       "Values('{0}', N'{1}', N'{2}', '{3}', N'{4}', '{5}')" :
                                             @"Insert into Person(Id, FistName, LastName, Bithday, Gender) " +
                       "Values('{0}', N'{1}', N'{2}', '{3}', N'{4}')";

      //Считывает данные с формы
      //var ID = Guid.NewGuid().ToString();
      //string FN = this.fistNameTextBox.Text;
      //string LN = this.lastNameTextBox.Text;
      //string format = "yyyy-MM-dd hh:mm:ss.mmm";
      //DateTime BD = this.bithdayDateTimePicker.Value;
      //string G = this.genderTextBox.Text;
      //var IdCom = this.idCompanyTextBox.Text;
      var ID = Guid.NewGuid().ToString();
      string FN = this.FN.Text;
      string LN = this.LN.Text;
      string format = "yyyy-MM-dd hh:mm:ss.mmm";
      DateTime BD = this.BD.Value;
      string G = this.G.Text;
      var IdCom = this.IDC.Text==""?null: this.IDC.Text;


      //Формируем запрос на вставку данных
      string sInsSotr = this.IDC.Text != "" ? string.Format(sInsSql, ID, FN, LN, BD.ToString(format), G, IdCom):
                                              string.Format(sInsSql, ID, FN, LN, BD.ToString(format), G);
      //string sInsSotr = string.Format(sInsSql, ID, BD.ToString(format), IdCom);
      //string sInsSql = @"Insert into Person(Id, FistName, LastName, Bithday, Gender, IdCompany) " +
      //                 "Values('"+ ID + "', N'Петя', N'Надыршин', '"+ BD.ToString(format) + "', N'Муж', "+ IdCom + ")";

      //Создаём команду ...
      SqlCommand cmdIns = new SqlCommand(sInsSotr, Conn);
      //SqlCommand cmdIns = new SqlCommand();
      //cmdIns.Connection = Conn;
      //cmdIns.CommandText = @"Insert into Person(Id, FistName, LastName, Bithday, Gender, IdCompany) " +
      //                 "Values('" + ID + "', N'Петя2', N'Надыршин2', '" + BD.ToString(format) + "', N'Муж2', " + IdCom + ")";
      //Выполняем команду
      try
      {
        
        cmdIns.ExecuteNonQuery();
        MessageBox.Show(string.Format("Запись {0} успешно вставлена !", FN), "Сообщение");
        this.personTableAdapter.Fill(this.databaseDataSet.Person);
      }
      catch (Exception exceptionObj)
      {
        MessageBox.Show(exceptionObj.Message.ToString());
      }
      Conn.Close();


    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.personTableAdapter.Fill(this.databaseDataSet.Person);
    }

    private void CreateBD_button_Click(object sender, EventArgs e)
    {
      String str;
      SqlConnection myConn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Integrated Security = True");

      str = "CREATE DATABASE "+ strUpToSymbol(this.NameBDtextBox.Text) +" ON PRIMARY " +
          "(NAME = MyDatabase_Data, " +
          "FILENAME = '"+ Environment.CurrentDirectory +"\\" + strUpToSymbol(this.NameBDtextBox.Text) + ".mdf', " +
          "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%) " +
          "LOG ON (NAME = " + strUpToSymbol(this.NameBDtextBox.Text) + "_Log, " +
          "FILENAME = '" + Environment.CurrentDirectory + "\\" + strUpToSymbol(this.NameBDtextBox.Text) + "Log.ldf', " +
          "SIZE = 1MB, " +
          "MAXSIZE = 5MB, " +
          "FILEGROWTH = 10%)";

      SqlCommand myCommand = new SqlCommand(str, myConn);
      try
      {
        myConn.Open();
        myCommand.ExecuteNonQuery();
        MessageBox.Show(this.NameBDtextBox.Text + " is Created Successfully", "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
        FindFileFillComBox(this.NameBDtextBox, "*.mdf");
      }
      catch (System.Exception ex)
      {
        MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      finally
      {
        if (myConn.State == ConnectionState.Open)
        {
          myConn.Close();
        }
      }
    }

    private void DeleteBD_button_Click(object sender, EventArgs e)
    {
      String str;
      //SqlConnection myConn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\DataBase\Database.mdf; Integrated Security = True");
      SqlConnection myConn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Integrated Security = True");

      str = "DROP DATABASE " + strUpToSymbol(this.NameBDtextBox.Text);

      SqlCommand myCommand = new SqlCommand(str, myConn);
      try
      {
        myConn.Open();
        myCommand.ExecuteNonQuery();
        MessageBox.Show(this.NameBDtextBox.Text + " is Deleted Successfully", "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
        FindFileFillComBox(this.NameBDtextBox, "*.mdf");
      }
      catch (System.Exception ex)
      {
        MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      finally
      {
        if (myConn.State == ConnectionState.Open)
        {
          myConn.Close();
        }
      }
    }
    private void FindFileFillComBox(ComboBox comBox, string mask, string directory = "")
    {
      comBox.Items.Clear();
      directory = directory == "" ? Environment.CurrentDirectory : directory;
      DirectoryInfo dir = new DirectoryInfo(directory);
      foreach (var item in dir.GetFiles(searchPattern: mask))
      {
        comBox.Items.Add(item);
      }
      comBox.Text = comBox.Items.Count > 0 ? comBox.Items[0].ToString() : "Нет *.mdf";

    }

    private string strUpToSymbol(string str, string symbol = "." )
    {
      return str.Remove(str.IndexOf(symbol));
    }

    private void FiilComBoxFromBD(ComboBox comBox, DataSet dataSet)
    {
      comBox.Items.Clear();
      //foreach (var cell in dataSet.Tables.
    }
  }
}
