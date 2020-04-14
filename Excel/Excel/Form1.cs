using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExceL = Microsoft.Office.Interop.Excel;

namespace ExcelTest
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      this.tb_patch.Text = ExcelTest.Properties.Settings.Default.Patch;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //Объявляем приложение
      ExceL.Application ex = new Microsoft.Office.Interop.Excel.Application();
      //Отобразить Excel
      ex.Visible = true;
      //Количество листов в рабочей книге
      ex.SheetsInNewWorkbook = 2;
      //Добавить рабочую книгу
      ExceL.Workbook workBook = ex.Workbooks.Add(Type.Missing);
      //Отключить отображение окон с сообщениями
      ex.DisplayAlerts = false;
      //Получаем первый лист документа (счет начинается с 1)
      ExceL.Worksheet sheet = (ExceL.Worksheet)ex.Worksheets.get_Item(1);
      //Название листа (вкладки снизу)
      sheet.Name = "Штамп А4";
      //Статус бар
      ex.StatusBar = "Формируем штамп А4";

      FormatSheet(sheet, ex);

      //Включаем отображение окон с сообщениями
      workBook.SaveAs(tb_patch.Text);
      workBook.Close();
      ex.DisplayAlerts = true;
      ex.Quit();
      

    }
    /// <summary>
    /// Форматирует границы диапазона
    /// </summary>
    /// <param name="rang">Рабочий диапазон</param>
    private void FormatRangeLineBorder(ExceL.Range rang, ExceL.XlLineStyle style, ExceL.XlBorderWeight weight )
    {
      //Слево
      rang.Borders.get_Item(ExceL.XlBordersIndex.xlEdgeLeft).LineStyle = style;
      rang.Borders.get_Item(ExceL.XlBordersIndex.xlEdgeLeft).Weight = weight;
      //Сверху
      rang.Borders.get_Item(ExceL.XlBordersIndex.xlEdgeTop).LineStyle = style;
      rang.Borders.get_Item(ExceL.XlBordersIndex.xlEdgeTop).Weight = weight;
      //Право
      rang.Borders.get_Item(ExceL.XlBordersIndex.xlEdgeRight).LineStyle = style;
      rang.Borders.get_Item(ExceL.XlBordersIndex.xlEdgeRight).Weight = weight;
      //Низ
      rang.Borders.get_Item(ExceL.XlBordersIndex.xlEdgeBottom).LineStyle = style;
      rang.Borders.get_Item(ExceL.XlBordersIndex.xlEdgeBottom).Weight = weight;

    }
    private void FormatRangeLineInsaide(ExceL.Range rang, ExceL.XlLineStyle style, ExceL.XlBorderWeight weightV, ExceL.XlBorderWeight weightH)
    {
      //Вертикаль
      rang.Borders.get_Item(ExceL.XlBordersIndex.xlInsideVertical).LineStyle = style;
      rang.Borders.get_Item(ExceL.XlBordersIndex.xlInsideVertical).Weight = weightV;
      //Горизонталь
      rang.Borders.get_Item(ExceL.XlBordersIndex.xlInsideHorizontal).LineStyle = style;
      rang.Borders.get_Item(ExceL.XlBordersIndex.xlInsideHorizontal).Weight = weightH;
    }
    /// <summary>
    /// Устанавливает кординаты диапазона
    /// </summary>
    /// <param name="sheet">Рабочий лист</param>
    /// <param name="snr"> стартовая строка </param>
    /// <param name="snc"> стартовый столбец </param>
    /// <param name="enr"> конечная строка </param>
    /// <param name="enc"> конечный столбец </param>
    /// <returns></returns>
    private ExceL.Range SetRange(ExceL.Worksheet sheet, int snr, int snc, int enr, int enc)
    {
      ExceL.Range r = sheet.Cells[snr, snc];
      ExceL.Range c = sheet.Cells[enr, enc];
      return  sheet.get_Range(r, c);
    }

    private void FormatSheet(ExceL.Worksheet sheet, ExceL.Application app)
    {
      //Принтер
      app.ActivePrinter = "Adobe PDF (Ne06:)";
      //Поля
      {
        sheet.PageSetup.LeftMargin = app.InchesToPoints(0);
        sheet.PageSetup.RightMargin = app.InchesToPoints(0);
        sheet.PageSetup.TopMargin = app.InchesToPoints(0);
        sheet.PageSetup.BottomMargin = app.InchesToPoints(0);
        sheet.PageSetup.HeaderMargin = app.InchesToPoints(0);
        sheet.PageSetup.FooterMargin = app.InchesToPoints(0);
      }
      ExceL.Range range;
      //Ширина/высота строк листа
      {
        sheet.Cells[1, 1].RowHeight = 18;    // 6,3 мм
        sheet.Cells[1, 1].ColumnWidth = 0.6; // 2 мм
        sheet.Cells[1, 2].ColumnWidth = 0.9; // 3 мм
        sheet.Cells[1, 3].ColumnWidth = 0.6;
        sheet.Cells[1, 4].ColumnWidth = 0.9;
        sheet.Cells[1, 5].ColumnWidth = 0.6;

        range = SetRange(sheet, 2, 6, 58, 39);
        range.ColumnWidth = 1.85; // 5 мм
        range.RowHeight = 14.8;   // 5 мм

        sheet.Cells[1, 40].ColumnWidth = 0.6;
        sheet.Cells[1, 41].ColumnWidth = 0.9;
        range = SetRange(sheet, 1, 42, 1, 45);
        range.ColumnWidth = 1.85; // 5 мм
      }
      int offSetR = 48, offSetC = 7; //Левая верхняя точка штампа
      //Строка для заполнения
      string[] str = new string[] { "Изм", "Кол. уч.", "Лист", "№док" }; int n = 0;
      //Объединение ячеек
      {
        for (int r = offSetR; r <= offSetR+4; r++)
        {
          for (int c = offSetC; c <= offSetC+7; c = c + 2)
          {
            range = SetRange(sheet, r, c, r, c + 1);
            range.Merge();
            if (r == offSetR + 4) 
            { range.Value = str[n]; n++;
              //Шрифт для диапазона
              range.Cells.Font.Name = "Gost type A"; range.Cells.Font.Size = 10;
            }
          }
        }
        //Строка для заполнения
        str = new string[] { "Разраб.", "", "", "", "", "", "","", "", "", "", "" }; n = 0;
        for (int r = offSetR+5; r <= offSetR+10; r++)
        {
          for (int c = offSetC; c <= offSetC+7; c = c + 4)
          {
            range = SetRange(sheet, r, c, r, c + 3);
            range.Merge();
            range.Value = str[n]; n++;
            //Шрифт для диапазона
            range.Cells.Font.Name = "Gost type A"; range.Cells.Font.Size = 10;
            range.ClearComments();
            //var comment2 = range.Comment;
            //comment2.AddText("Frist line in comment.").SetBold().SetFontSize(6);
            //comment2.AddNewLine();
            //comment2.AddText("Sencond line.").FontName = "Times New Roman";
            //Object str1 = "";
            //range.AddComment(str1);
            //var comment = "Mikhail";  range.AddComment();
            //range.Comment.Visible = true;
            //range.Comment.Text(obj);
            //range.Comment. ="Тестовое примечание";
          }
        }
        //Строка для заполнения
        str = new string[] { "", "", "", "", "Подп.", "", "", "", "", "", "" }; n = 0;
        for (int r = offSetR; r <= offSetR+10; r++)
        {
          for (int c = offSetC+8; c <= offSetC+10; c = c + 3)
          {
            range = SetRange(sheet, r, c, r, c + 2);
            range.Merge();

            range.Value = str[n]; n++;
            //Шрифт для диапазона
            range.Cells.Font.Name = "Gost type A"; range.Cells.Font.Size = 10;

          }
        }
        //Строка для заполнения
        str = new string[] { "", "", "", "", "Дата", "", "", "", "", "", "" }; n = 0;
        for (int r = offSetR; r <= offSetR+10; r++)
        {
          for (int c = offSetC+11; c <= offSetC+12; c = c + 2)
          {
            range = SetRange(sheet, r, c, r, c + 1);
            range.Merge();
            range.Value = str[n]; n++;
            //Шрифт для диапазона
            range.Cells.Font.Name = "Gost type A"; range.Cells.Font.Size = 10;
          }
        }
        range = SetRange(sheet, offSetR, offSetC+13, offSetR+1, offSetC+37);
        range.Merge();
        range = SetRange(sheet, offSetR+2, offSetC+13, offSetR+4, offSetC+37);
        range.Merge();
        range = SetRange(sheet, offSetR+5, offSetC+13, offSetR+7, offSetC+26);
        range.Merge();
        range = SetRange(sheet, offSetR+8, offSetC+13, offSetR+10, offSetC+26);
        range.Merge();
        range = SetRange(sheet, offSetR+8, offSetC+27, offSetR+10, offSetC+37);
        range.Merge();
        range = SetRange(sheet, offSetR+5, offSetC+27, offSetR+5, offSetC+29); //Ситадия
        range.Merge();
        range = SetRange(sheet, offSetR+5, offSetC+30, offSetR+5, offSetC+33); //Лист
        range.Merge();
        range = SetRange(sheet, offSetR+5, offSetC+34, offSetR+5, offSetC+37); //Листов
        range.Merge();
        range = SetRange(sheet, offSetR+6, offSetC+27, offSetR+7, offSetC+29); //Ситадия
        range.Merge();
        range = SetRange(sheet, offSetR+6, offSetC+30, offSetR+7, offSetC+33); //Лист
        range.Merge();
        range = SetRange(sheet, offSetR+6, offSetC+34, offSetR+7, offSetC+37); //Листов
        range.Merge();

        offSetR = 29; offSetC = 2; //Левая верхняя точка штампа
        //Верхний левый боковой
        range = SetRange(sheet, offSetR, offSetC, offSetR+14, offSetC+1); //Боковой штамп
        range.Merge();
        range = SetRange(sheet, offSetR, offSetC+2, offSetR+1, offSetC+3); //Боковой штамп
        range.Merge();
        range = SetRange(sheet, offSetR+2, offSetC+2, offSetR+4, offSetC+3); //Боковой штамп
        range.Merge();
        range = SetRange(sheet, offSetR+5, offSetC+2, offSetR+9, offSetC+3); //Боковой штамп
        range.Merge();
        range = SetRange(sheet, offSetR+10, offSetC+2, offSetR+14, offSetC+3); //Боковой штамп
        range.Merge();
        range = SetRange(sheet, offSetR+10, offSetC+2, offSetR+14, offSetC+3); //Боковой штамп
        range.Merge();
        range = SetRange(sheet, offSetR, offSetC+4, offSetR+1, offSetC+4); //Боковой штамп
        range.Merge();
        range = SetRange(sheet, offSetR+2, offSetC+4, offSetR+4, offSetC+4); //Боковой штамп
        range.Merge();
        range = SetRange(sheet, offSetR+5, offSetC+4, offSetR+9, offSetC+4); //Боковой штамп
        range.Merge();
        range = SetRange(sheet, offSetR+10, offSetC+4, offSetR+14, offSetC+4); //Боковой штамп
        range.Merge();
        range = SetRange(sheet, offSetR+10, offSetC+4, offSetR+14, offSetC+4); //Боковой штамп
        range.Merge();
        range = SetRange(sheet, offSetR, offSetC, offSetR+14, offSetC+4); //Боковой штамп
        FormatRangeLineBorder(range, ExceL.XlLineStyle.xlContinuous, ExceL.XlBorderWeight.xlThin);
        FormatRangeLineInsaide(range, ExceL.XlLineStyle.xlContinuous, ExceL.XlBorderWeight.xlThin, ExceL.XlBorderWeight.xlThin);

        //Нижний левый боковой
        range = SetRange(sheet, offSetR+15, offSetC+1, offSetR+19, offSetC+2); //Боковой штамп
        range.Merge();
        range = SetRange(sheet, offSetR+20, offSetC+1, offSetR+26, offSetC+2); //Боковой штамп
        range.Merge();
        range = SetRange(sheet, offSetR+27, offSetC+1, offSetR+29, offSetC+2); //Боковой штамп
        range.Merge();
        range = SetRange(sheet, offSetR+15, offSetC+3, offSetR+19, offSetC+4); //Боковой штамп
        range.Merge();
        range = SetRange(sheet, offSetR+20, offSetC+3, offSetR+26, offSetC+4); //Боковой штамп
        range.Merge();
        range = SetRange(sheet, offSetR+27, offSetC+3, offSetR+29, offSetC+4); //Боковой штамп
        range.Merge();
        range = SetRange(sheet, offSetR+15, offSetC+1, offSetR+29, offSetC+4); //Боковой штамп
        FormatRangeLineBorder(range, ExceL.XlLineStyle.xlContinuous, ExceL.XlBorderWeight.xlMedium);
        FormatRangeLineInsaide(range, ExceL.XlLineStyle.xlContinuous, ExceL.XlBorderWeight.xlMedium, ExceL.XlBorderWeight.xlMedium);

        //Рамка
        range = SetRange(sheet, 2, 7, 55, 44);
        FormatRangeLineBorder(range, ExceL.XlLineStyle.xlContinuous, ExceL.XlBorderWeight.xlMedium);

        //Нижний штамп
        range = SetRange(sheet, offSetR+19, offSetC+5, offSetR+29, offSetC+42);
        FormatRangeLineBorder(range, ExceL.XlLineStyle.xlContinuous, ExceL.XlBorderWeight.xlMedium);
        

        range = SetRange(sheet, offSetR+19, offSetC+5, offSetR+29, offSetC+18);
        FormatRangeLineInsaide(range, ExceL.XlLineStyle.xlContinuous, ExceL.XlBorderWeight.xlMedium, ExceL.XlBorderWeight.xlThin);
        range = SetRange(sheet, offSetR+23, offSetC+5, offSetR+23, offSetC+17);
        FormatRangeLineBorder(range, ExceL.XlLineStyle.xlContinuous, ExceL.XlBorderWeight.xlMedium);
        range = SetRange(sheet, offSetR+19, offSetC+18, offSetR+29, offSetC+42);
        FormatRangeLineInsaide(range, ExceL.XlLineStyle.xlContinuous, ExceL.XlBorderWeight.xlMedium, ExceL.XlBorderWeight.xlMedium);
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      OpenFileDialog OPF = new OpenFileDialog();
      OPF.Filter = "Файлы Excel|*.xls;*.xlsm;*.xlsx";
      if (OPF.ShowDialog() == DialogResult.OK)
      {
        tb_patch.Text = OPF.FileName;
        //MessageBox.Show(OPF.FileName);
      }
    }

    private void btn_saveAs_Click(object sender, EventArgs e)
    {
      SaveFileDialog SFD = new SaveFileDialog();
      if (SFD.ShowDialog() == DialogResult.Cancel)
        return;
      // получаем выбранный файл
      tb_patch.Text = SFD.FileName;
    }
  }
}
