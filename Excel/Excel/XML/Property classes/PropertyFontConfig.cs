using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Excel.XML.Property_classes
{
  class PropertyFontConfig
  {
    Font m_FontField;
    [Browsable(true)]
    [Description("Пример заполнения текста")]
    [DisplayName("Текстовое поле")]
    public Font FontField
    {
      get { return m_FontField; }
      set { m_FontField = value; }
    }
  }
}
