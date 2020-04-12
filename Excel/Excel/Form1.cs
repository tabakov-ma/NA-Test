using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelTest
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //Объявляем приложение
      Excel.Application ex = new Microsoft.Office.Interop.Excel.Application();
      //Отобразить Excel
      ex.Visible = true;
      //Количество листов в рабочей книге
      ex.SheetsInNewWorkbook = 2;
      //Добавить рабочую книгу
      Excel.Workbook workBook = ex.Workbooks.Add(Type.Missing);
      //Отключить отображение окон с сообщениями
      ex.DisplayAlerts = false;
      //Получаем первый лист документа (счет начинается с 1)
      Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);
      //Название листа (вкладки снизу)
      sheet.Name = "Отчет за 13.12.2017";

      FormatSheet(sheet, ex);
      
      //Включаем отображение окон с сообщениями
      ex.DisplayAlerts = true;

    }
    /// <summary>
    /// Форматирует границы диапазона
    /// </summary>
    /// <param name="rang">Рабочий диапазон</param>
    private void FormatRangeLineBorder(Excel.Range rang, Excel.XlLineStyle style, Excel.XlBorderWeight weight )
    {
      //Слево
      rang.Borders.get_Item(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = style;
      rang.Borders.get_Item(Excel.XlBordersIndex.xlEdgeLeft).Weight = weight;
      //Сверху
      rang.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = style;
      rang.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).Weight = weight;
      //Право
      rang.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = style;
      rang.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).Weight = weight;
      //Низ
      rang.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = style;
      rang.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).Weight = weight;

    }
    private void FormatRangeLineInsaide(Excel.Range rang, Excel.XlLineStyle style, Excel.XlBorderWeight weightV, Excel.XlBorderWeight weightH)
    {
      //Вертикаль
      rang.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = style;
      rang.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).Weight = weightV;
      //Горизонталь
      rang.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = style;
      rang.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).Weight = weightH;
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
    private Excel.Range SetRange(Excel.Worksheet sheet, int snr, int snc, int enr, int enc)
    {
      Excel.Range r = sheet.Cells[snr, snc];
      Excel.Range c = sheet.Cells[enr, enc];
      return  sheet.get_Range(r, c);
    }

    private void FormatSheet(Excel.Worksheet sheet, Excel.Application app)
    {
      //Принтер
      app.ActivePrinter = "Adobe PDF (Ne06:)";
      //Поля
      sheet.PageSetup.LeftMargin = app.InchesToPoints(0);
      sheet.PageSetup.RightMargin = app.InchesToPoints(0);
      sheet.PageSetup.TopMargin = app.InchesToPoints(0);
      sheet.PageSetup.BottomMargin = app.InchesToPoints(0);
      sheet.PageSetup.HeaderMargin = app.InchesToPoints(0);
      sheet.PageSetup.FooterMargin = app.InchesToPoints(0);

      sheet.Cells[1, 1].RowHeight = 18;
      sheet.Cells[1, 1].ColumnWidth = 0.6;
      sheet.Cells[1, 2].ColumnWidth = 0.9;
      sheet.Cells[1, 3].ColumnWidth = 0.6;
      sheet.Cells[1, 4].ColumnWidth = 0.9;
      sheet.Cells[1, 5].ColumnWidth = 0.6;

      sheet.Cells[1, 40].ColumnWidth = 0.6;
      sheet.Cells[1, 41].ColumnWidth = 0.9;
      sheet.Cells[1, 42].ColumnWidth = 1.85;
      sheet.Cells[1, 43].ColumnWidth = 1.85;
      sheet.Cells[1, 44].ColumnWidth = 1.85;
      sheet.Cells[1, 45].ColumnWidth = 1.85;

      Excel.Range range;
      range = SetRange(sheet, 2, 6, 58, 39); 
      range.ColumnWidth = 1.85; range.RowHeight = 14.8;


      for (int r = 48; r <= 52; r++)
      {
        for (int c = 7; c <= 14; c = c + 2)
        {
          range = SetRange(sheet, r, c, r, c + 1);
          range.Merge();
        }
      }

      for (int r = 53; r <= 58; r++)
      {
        for (int c = 7; c <= 14; c = c + 4)
        {
          range = SetRange(sheet, r, c, r, c + 3);
          range.Merge();
        }
      }

      for (int r = 48; r <= 58; r++)
      {
        for (int c = 15; c <= 17; c = c + 3)
        {
          range = SetRange(sheet, r, c, r, c + 2);
          range.Merge();
        }
      }

      for (int r = 48; r <= 58; r++)
      {
        for (int c = 18; c <= 19; c = c + 2)
        {
          range = SetRange(sheet, r, c, r, c + 1);
          range.Merge();
        }
      }
      range = SetRange(sheet, 48, 20, 49, 44);
      range.Merge();
      range = SetRange(sheet, 50, 20, 52, 44);
      range.Merge();
      range = SetRange(sheet, 53, 20, 55, 33);
      range.Merge();
      range = SetRange(sheet, 56, 20, 58, 33);
      range.Merge();
      range = SetRange(sheet, 56, 34, 58, 44);
      range.Merge();
      range = SetRange(sheet, 53, 34, 53, 36); //Ситадия
      range.Merge();
      range = SetRange(sheet, 53, 37, 53, 40); //Лист
      range.Merge();
      range = SetRange(sheet, 53, 41, 53, 44); //Листов
      range.Merge();
      range = SetRange(sheet, 54, 34, 55, 36); //Ситадия
      range.Merge();
      range = SetRange(sheet, 54, 37, 55, 40); //Лист
      range.Merge();
      range = SetRange(sheet, 54, 41, 55, 44); //Листов
      range.Merge();

      range = SetRange(sheet, 29, 2, 43, 3); //Боковой штамп
      range.Merge();
      range.Merge();
      range = SetRange(sheet, 29, 4, 30, 5); //Боковой штамп
      range.Merge();
      range = SetRange(sheet, 31, 4, 33, 5); //Боковой штамп
      range.Merge();
      range = SetRange(sheet, 34, 4, 38, 5); //Боковой штамп
      range.Merge();
      range = SetRange(sheet, 39, 4, 43, 5); //Боковой штамп
      range.Merge();
      range = SetRange(sheet, 39, 4, 43, 5); //Боковой штамп
      range.Merge();
      range = SetRange(sheet, 29, 6, 30, 6); //Боковой штамп
      range.Merge();
      range = SetRange(sheet, 31, 6, 33, 6); //Боковой штамп
      range.Merge();
      range = SetRange(sheet, 34, 6, 38, 6); //Боковой штамп
      range.Merge();
      range = SetRange(sheet, 39, 6, 43, 6); //Боковой штамп
      range.Merge();
      range = SetRange(sheet, 39, 6, 43, 6); //Боковой штамп
      range.Merge();
      range = SetRange(sheet, 29, 2, 43, 6); //Боковой штамп
      FormatRangeLineBorder(range, Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
      FormatRangeLineInsaide(range, Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlBorderWeight.xlThin);

      range = SetRange(sheet, 44, 3, 48, 4); //Боковой штамп
      range.Merge();
      range = SetRange(sheet, 49, 3, 55, 4); //Боковой штамп
      range.Merge();
      range = SetRange(sheet, 56, 3, 58, 4); //Боковой штамп
      range.Merge();
      range = SetRange(sheet, 44, 5, 48, 6); //Боковой штамп
      range.Merge();
      range = SetRange(sheet, 49, 5, 55, 6); //Боковой штамп
      range.Merge();
      range = SetRange(sheet, 56, 5, 58, 6); //Боковой штамп
      range.Merge();
      range = SetRange(sheet, 44, 3, 58, 6); //Боковой штамп
      FormatRangeLineBorder(range, Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium);
      FormatRangeLineInsaide(range, Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium, Excel.XlBorderWeight.xlMedium);

      range = SetRange(sheet, 2, 7, 55, 44);
      FormatRangeLineBorder(range, Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium);

      range = SetRange(sheet, 48, 7, 58, 44);
      FormatRangeLineBorder(range, Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium);
      range = SetRange(sheet, 48, 7, 58, 20);
      FormatRangeLineInsaide(range, Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium, Excel.XlBorderWeight.xlThin);
      range = SetRange(sheet, 52, 7, 52, 19);
      FormatRangeLineBorder(range, Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium);
      range = SetRange(sheet, 48, 20, 58, 44);
      FormatRangeLineInsaide(range, Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium, Excel.XlBorderWeight.xlMedium);

    }
  }
}
