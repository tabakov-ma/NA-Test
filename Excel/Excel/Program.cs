﻿using Excel;
using Excel.DataBase;
using Excel.XML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
//using Excel.XML;

namespace ExcelTest
{
  static class Program
  {
    /// <summary>
    /// Главная точка входа для приложения.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new RWriteXmlFile());
      //Application.Run(new frmXmlTest());
      //Application.Run(new frm_DataBase());
      //Application.Run(new frmLevalUser());
      // Application.Run(new Form1());


    }
  }
}
