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
      //Принтер
      ex.ActivePrinter = "Adobe PDF (Ne06:)";
      //Поля
      sheet.PageSetup.LeftMargin = ex.InchesToPoints(0);
      sheet.PageSetup.RightMargin = ex.InchesToPoints(0);
      sheet.PageSetup.TopMargin = ex.InchesToPoints(0);
      sheet.PageSetup.BottomMargin = ex.InchesToPoints(0);
      sheet.PageSetup.HeaderMargin = ex.InchesToPoints(0);
      sheet.PageSetup.FooterMargin = ex.InchesToPoints(0);

      //Пример заполнения ячеек
      //for (int i = 2; i <= 59; i++)
      //{
      //  //sheet.Cells[i, j].RowHeight = 15;
      //  for (int j = 2; j <= 41; j++)
      //  {
      //    sheet.Cells[i, j] = String.Format("{0}:{1}", i, j);

      //  }
      //}
      //Последняя заполненная ячейка
      //Excel.Range last = sheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
      Excel.Range last = sheet.Cells[58,40];
      //Захватываем диапазон ячеек
      Excel.Range r = sheet.Cells[2, 2];
      Excel.Range c = sheet.Cells[last.Row, last.Column];
      Excel.Range range1 = sheet.get_Range(r, c); //("A1","H9");//
      //Ширина/высота ячеек
      range1.ColumnWidth = 1.85; range1.RowHeight = 14.8;
      sheet.Cells[1, 1].RowHeight = 18;
      sheet.Cells[1, 1].ColumnWidth = 2.5;

      //Шрифт для диапазона
      range1.Cells.Font.Name = "Tahoma";
      //Размер шрифта для диапазона
      range1.Cells.Font.Size = 10;
      //Захватываем другой диапазон ячеек
      //r = sheet.Cells[2, 4];
      //c = sheet.Cells[last.Row, last.Column];
      Excel.Range range2 = SetRange(sheet,2, 4, last.Row, last.Column);
      //Excel.Range range2 = sheet.get_Range(r, c);
      range2.Cells.Font.Name = "Times New Roman";
      //Задаем цвет этого диапазона. Необходимо подключить System.Drawing
      range2.Cells.Font.Color = ColorTranslator.ToOle(Color.Green);
      //Фоновый цвет
      //range2.Interior.Color = ColorTranslator.ToOle(Color.FromArgb(0xFF, 0xFF, 0xFF));
      //Периметр диапазона
      FormatRange(range2);
      //Нижний штамп
      range2 = SetRange(sheet, 2, 4, last.Row, last.Column);

      ////Цвет рамки
      //range2.Borders.Color = ColorTranslator.ToOle(Color.Red);
      //Включаем отображение окон с сообщениями
      ex.DisplayAlerts = true;
    }
    /// <summary>
    /// Форматирует границы диапазона
    /// </summary>
    /// <param name="rang">Рабочий диапазон</param>
    private void FormatRange(Excel.Range rang )
    {
      //Слево
      rang.Borders.get_Item(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous;
      rang.Borders.get_Item(Excel.XlBordersIndex.xlEdgeLeft).Weight = Excel.XlBorderWeight.xlMedium;
      //Сверху
      rang.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;
      rang.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium;
      //Право
      rang.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;
      rang.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).Weight = Excel.XlBorderWeight.xlMedium;
      //Низ
      rang.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
      rang.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium;
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
  }
}
