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
      sheet.Name = "Штамп А4";

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
      {
        sheet.PageSetup.LeftMargin = app.InchesToPoints(0);
        sheet.PageSetup.RightMargin = app.InchesToPoints(0);
        sheet.PageSetup.TopMargin = app.InchesToPoints(0);
        sheet.PageSetup.BottomMargin = app.InchesToPoints(0);
        sheet.PageSetup.HeaderMargin = app.InchesToPoints(0);
        sheet.PageSetup.FooterMargin = app.InchesToPoints(0);
      }
      Excel.Range range;
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
        FormatRangeLineBorder(range, Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
        FormatRangeLineInsaide(range, Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlBorderWeight.xlThin);

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
        FormatRangeLineBorder(range, Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium);
        FormatRangeLineInsaide(range, Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium, Excel.XlBorderWeight.xlMedium);

        //Рамка
        range = SetRange(sheet, 2, 7, 55, 44);
        FormatRangeLineBorder(range, Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium);

        //Нижний штамп
        range = SetRange(sheet, offSetR+19, offSetC+5, offSetR+29, offSetC+42);
        FormatRangeLineBorder(range, Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium);
        

        range = SetRange(sheet, offSetR+19, offSetC+5, offSetR+29, offSetC+18);
        FormatRangeLineInsaide(range, Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium, Excel.XlBorderWeight.xlThin);
        range = SetRange(sheet, offSetR+23, offSetC+5, offSetR+23, offSetC+17);
        FormatRangeLineBorder(range, Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium);
        range = SetRange(sheet, offSetR+19, offSetC+18, offSetR+29, offSetC+42);
        FormatRangeLineInsaide(range, Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium, Excel.XlBorderWeight.xlMedium);
      }
    }
  }
}
