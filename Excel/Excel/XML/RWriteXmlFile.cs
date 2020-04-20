using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Excel.XML
{
  public partial class RWriteXmlFile : Form
  {
    public RWriteXmlFile()
    {
      InitializeComponent();
    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (textBox1.Text == "")
      {
        MessageBox.Show("Заполните все поля.", "Ошибка.");
      }
      else
      {
        int n = dataGridView2.Rows.Add();
        dataGridView2.Rows[n].Cells[0].Value = textBox1.Text; // столбец Name
        dataGridView2.Rows[n].Cells[1].Value = numericUpDown1.Value; // Age
        dataGridView2.Rows[n].Cells[2].Value = (comboBox1.SelectedIndex<0) ? "false" : comboBox1.Text; // Programmer
      }
    }

    private void button6_Click(object sender, EventArgs e)
    {
      try
      {
        DataSet ds = new DataSet(); // создаем пока что пустой кэш данных
        DataTable dt = new DataTable(); // создаем пока что пустую таблицу данных
        dt.TableName = "Employee"; // название таблицы
        dt.Columns.Add("Name"); // название колонок
        dt.Columns.Add("Age");
        dt.Columns.Add("Programmer");
        ds.Tables.Add(dt); //в ds создается таблица, с названием и колонками, созданными выше

        foreach (DataGridViewRow r in dataGridView2.Rows) // пока в dataGridView1 есть строки
        {
          if (r.Cells[0].Value != null)
          {
            DataRow row = ds.Tables["Employee"].NewRow(); // создаем новую строку в таблице, занесенной в ds
            row["Name"] = r.Cells[0].Value;  //в столбец этой строки заносим данные из первого столбца dataGridView1
            row["Age"] = r.Cells[1].Value; // то же самое со вторыми столбцами
            row["Programmer"] = r.Cells[2].Value; //то же самое с третьими столбцами
            ds.Tables["Employee"].Rows.Add(row); //добавление всей этой строки в таблицу ds.
          }
        }
        ds.WriteXml("D:\\Data.xml");
        MessageBox.Show("XML файл успешно сохранен.", "Выполнено.");
      }
      catch
      {
        MessageBox.Show("Невозможно сохранить XML файл.", "Ошибка.");
      }
    }

    
    private void button4_Click(object sender, EventArgs e)
    {
      if (dataGridView2.Rows.Count > 1) //если в таблице больше нуля строк
      {
        MessageBox.Show("Очистите поле перед загрузкой нового файла.", "Ошибка.");
      }
      else
      {
        if (File.Exists("D:\\Data.xml")) // если существует данный файл
        {
          DataSet ds = new DataSet(); // создаем новый пустой кэш данных
          ds.ReadXml("D:\\Data.xml"); // записываем в него XML-данные из файла

          try
          {
            if (ds.Tables["Employee"] == null) { MessageBox.Show("XML файл пуст.", "Ошибка."); return; }
            foreach (DataRow item in ds.Tables["Employee"].Rows)
            {
              int n = dataGridView2.Rows.Add(); // добавляем новую сроку в dataGridView1
              dataGridView2.Rows[n].Cells[0].Value = item["Name"]; // заносим в первый столбец созданной строки данные из первого столбца таблицы ds.
              dataGridView2.Rows[n].Cells[1].Value = item["Age"]; // то же самое со вторым столбцом
              dataGridView2.Rows[n].Cells[2].Value = item["Programmer"]; // то же самое с третьим столбцом
            }
          
          }
          
          catch (Exception ex)
          {
            
            MessageBox.Show(ex.Message, "Ошибка.");
          }

        }
        else
        {
          MessageBox.Show("XML файл не найден.", "Ошибка.");
        }
      }

    }
   

  private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
    {
      //textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
      //int n = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);
      //numericUpDown1.Value = n;
      //comboBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (dataGridView2.SelectedRows.Count > 0)
      {
        int n = dataGridView2.SelectedRows[0].Index;
        dataGridView2.Rows[n].Cells[0].Value = textBox1.Text;
        dataGridView2.Rows[n].Cells[1].Value = numericUpDown1.Value.ToString();
        dataGridView2.Rows[n].Cells[2].Value = comboBox1.Text;
      }
      else
      {
        MessageBox.Show("Выберите строку для редактирования.", "Ошибка.");
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      if (dataGridView2.SelectedRows.Count > 0)
      {
        dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index); //удаление
      }
      else
      {
        MessageBox.Show("Выберите строку для удаления.", "Ошибка.");
      }
    }

    private void button5_Click(object sender, EventArgs e)
    {
      if (dataGridView2.Rows.Count > 1)
      {
        dataGridView2.Rows.Clear();
      }
      else
      {
        MessageBox.Show("Таблица пустая.", "Ошибка.");
      }
    }

    private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
    {
  
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      //textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
      //int n = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);
      //numericUpDown1.Value = n;
      //comboBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
    }

    private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      if (dataGridView2.Rows.Count <= 1 && dataGridView2.SelectedRows[0].Cells[1].Value == null) return;
      textBox1.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
      int n = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[1].Value);
      numericUpDown1.Value = n;
      comboBox1.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
    }

    private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      //MessageBox.Show("Нет событий", "Информация");
    }

    private void RWriteXmlFile_Load(object sender, EventArgs e)
    {
      {
        //создадим таблицу вывода товаров с колонками 
        //Название, Цена, Остаток

        var column1 = new DataGridViewColumn();
        column1.HeaderText = "Название"; //текст в шапке
        column1.Width = 100; //ширина колонки
        column1.ReadOnly = false; //значение в этой колонке нельзя править
        column1.Name = "name"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
        column1.Frozen = false; //флаг, что данная колонка всегда отображается на своем месте
        column1.SortMode = DataGridViewColumnSortMode.Automatic; //сортировка
        column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

        var column2 = new DataGridViewColumn();
        column2.HeaderText = "Цена";
        column2.Name = "price";
        column2.SortMode = DataGridViewColumnSortMode.Automatic; //сортировка
        column2.CellTemplate = new DataGridViewTextBoxCell();

        var column3 = new DataGridViewColumn();
        column3.HeaderText = "Остаток";
        column3.Name = "count";
        column3.SortMode = DataGridViewColumnSortMode.Automatic; //сортировка
        column3.CellTemplate = new DataGridViewTextBoxCell();

        dataGridView1.Columns.Add(column1);
        dataGridView1.Columns.Add(column2);
        dataGridView1.Columns.Add(column3);

        dataGridView1.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки


        for (int i = 0; i < 5; ++i)
        {
          //Добавляем строку, указывая значения колонок поочереди слева направо
          dataGridView1.Rows.Add("Пример 1, Товар " + i, i * 1000, i);
        }

        for (int i = 0; i < 5; ++i)
        {
          //Добавляем строку, указывая значения каждой ячейки по имени (можно использовать индекс 0, 1, 2 вместо имен)
          dataGridView1.Rows.Add();
          dataGridView1["name", dataGridView1.Rows.Count - 1].Value = "Пример 2, Товар " + i;
          dataGridView1["price", dataGridView1.Rows.Count - 1].Value = i * 1000;
          dataGridView1["count", dataGridView1.Rows.Count - 1].Value = i;
        }

        //А теперь простой пройдемся циклом по всем ячейкам
        //int cr = dataGridView1.Rows.Count;
        //int cc = dataGridView1.Columns.Count;
        //object[,] o = new object[cr, cc];
        for (int i = 0; i < dataGridView1.Rows.Count; ++i)
        {
          for (int j = 0; j < dataGridView1.Columns.Count; ++j)
          {
            //Значения ячеек хряняться в типе object
            //это позволяет хранить любые данные в таблице
            //o[j,i] = dataGridView1[j, i].Value;
            //dataGridView1[j, i].Value = dataGridView1[j, i].Value + "?";
          }
        }
      }
    }

    private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      //dataGridView1_RowHeaderMouseClick();
    }
    //метод шифрования строки
    public static string Shifrovka(string ishText, string pass,
           string sol = "doberman", string cryptographicAlgorithm = "SHA1",
           int passIter = 2, string initVec = "a8doSuDitOz1hZe#",
           int keySize = 256)
    {
      if (string.IsNullOrEmpty(ishText))
        return "";

      byte[] initVecB = Encoding.ASCII.GetBytes(initVec);
      byte[] solB = Encoding.ASCII.GetBytes(sol);
      byte[] ishTextB = Encoding.UTF8.GetBytes(ishText);

      PasswordDeriveBytes derivPass = new PasswordDeriveBytes(pass, solB, cryptographicAlgorithm, passIter);
      byte[] keyBytes = derivPass.GetBytes(keySize / 8);
      RijndaelManaged symmK = new RijndaelManaged();
      symmK.Mode = CipherMode.CBC;

      byte[] cipherTextBytes = null;

      using (ICryptoTransform encryptor = symmK.CreateEncryptor(keyBytes, initVecB))
      {
        using (MemoryStream memStream = new MemoryStream())
        {
          using (CryptoStream cryptoStream = new CryptoStream(memStream, encryptor, CryptoStreamMode.Write))
          {
            cryptoStream.Write(ishTextB, 0, ishTextB.Length);
            cryptoStream.FlushFinalBlock();
            cipherTextBytes = memStream.ToArray();
            memStream.Close();
            cryptoStream.Close();
          }
        }
      }

      symmK.Clear();
      return Convert.ToBase64String(cipherTextBytes);
    }

    //метод дешифрования строки
    public static string DeShifrovka(string ciphText, string pass,
           string sol = "doberman", string cryptographicAlgorithm = "SHA1",
           int passIter = 2, string initVec = "a8doSuDitOz1hZe#",
           int keySize = 256)
    {
      try
      {
        if (string.IsNullOrEmpty(ciphText))
          return "";

        byte[] initVecB = Encoding.ASCII.GetBytes(initVec);
        byte[] solB = Encoding.ASCII.GetBytes(sol);
        byte[] cipherTextBytes = Convert.FromBase64String(ciphText);

        PasswordDeriveBytes derivPass = new PasswordDeriveBytes(pass, solB, cryptographicAlgorithm, passIter);
        byte[] keyBytes = derivPass.GetBytes(keySize / 8);

        RijndaelManaged symmK = new RijndaelManaged();
        symmK.Mode = CipherMode.CBC;

        byte[] plainTextBytes = new byte[cipherTextBytes.Length];
        int byteCount = 0;

        using (ICryptoTransform decryptor = symmK.CreateDecryptor(keyBytes, initVecB))
        {
          using (MemoryStream mSt = new MemoryStream(cipherTextBytes))
          {
            using (CryptoStream cryptoStream = new CryptoStream(mSt, decryptor, CryptoStreamMode.Read))
            {
              byteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
              mSt.Close();
              cryptoStream.Close();
            }
          }
        }

        symmK.Clear();
        return Encoding.UTF8.GetString(plainTextBytes, 0, byteCount);
      }
      catch(Exception ex)
      {
        //MessageBox.Show(ex.Message, "Оштбка");
        return "";
      }
    }

    private void buttonShipr_Click(object sender, EventArgs e)
    {
      for (int i = 0; i < dataGridView1.Rows.Count; ++i)
      {
        for (int j = 0; j < dataGridView1.Columns.Count; ++j)
        {
          //шифровка
          dataGridView1[j, i].Value = Shifrovka(dataGridView1[j, i].Value.ToString(), textBoxPassword.Text);
        }
      }
    }

    private void buttonUnShipr_Click(object sender, EventArgs e)
    {
      for (int i = 0; i < dataGridView1.Rows.Count; ++i)
      {
        for (int j = 0; j < dataGridView1.Columns.Count; ++j)
        {
          //дешифровка
          dataGridView1[j, i].Value = DeShifrovka(dataGridView1[j, i].Value.ToString(), textBoxPassword.Text) ==""? dataGridView1[j, i].Value: DeShifrovka(dataGridView1[j, i].Value.ToString(), textBoxPassword.Text);
        }
      }
    }
  }
  
}
