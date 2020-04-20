using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel.XML.Property_classes

{
  class PropertyTextField
  {
    String m_TextField;
    [Browsable(true)]
    [Description("Example of text field")]
    [DisplayName("Text field")]
    public String TextField
    {
      get { return m_TextField; }
      set { m_TextField = value; }
    }
  }
}
