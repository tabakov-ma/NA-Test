using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace vscoder
{

  public class vscode
  {
    public int[,] version = new int[,] { { 0, 1 }, { 0, 2 }, 
                                         { 1, 1 }, 
                                       };
    public string[] nameContr = new string[] { "Siemens 400", "Allen Bradley ControlLogix"};
    public string print(string contr, int ver)
    {
    switch(contr)
    {
        case "Siemens 400":
          switch (ver)
          {
            case 1:
              return printS400v1();
            case 2:
              return printS400v2();
            default:
              return printS400v1();
          }
        case "Allen Bradley ControlLogix":
          switch (ver)
          {
            case 1:
              return printABCnLv1();
            default:
              return printABCnLv1();
          }
        default: return "Тип контроллера и версия не найдена";
      }

      
    }
    private string printS400v1()
    {
      return "Siemens 400" + " " + "v1";
    }

    private string printS400v2()
    {
      return "Siemens 400" + " " + "v2";
    }
    private string printABCnLv1()
    {
      return "Allen Bradley ControlLogix" + " " + "v1";
    }
    //public string Print_()
    //{
    //  string chComStart = "\\"+"\\";
    //  string chComEnd = "";
    //  string version = chComStart + new String('=',30) + "\r\n"        + chComEnd +
    //                   chComStart + "Версия программы: v1.0 \r\n"      + chComEnd +
    //                   chComStart + "Дата разработки: 20-04-2020 \r\n" + chComEnd +
    //                   chComStart + "Название: processAna \r\n"        + chComEnd +
    //                   chComStart + "Разработчик: Муратов И.С.\r\n"    + chComEnd +
    //                   chComStart + new String('=', 30) + "\r\n"       + chComEnd;
    //  return version;
    //}
    
  }
}
