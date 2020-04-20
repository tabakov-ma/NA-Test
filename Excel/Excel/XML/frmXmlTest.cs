using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Excel.XML.Property_classes;

namespace ExcelTest
{
  public partial class frmXmlTest : Form
  {
    private PropertyTextField prTextProp;
    private PropertyTrueFalse prLogicProp;
    private PropertyCategories prCategoryProp;
    private PropertyColorSelector prColorProp;
    private PropertyFontConfig prFontProp;
    private PropertyList prListProp;
    public frmXmlTest()
    {
      InitializeComponent();
      LoadEmployees();
    }
    private void LoadEmployees()
    {
      XmlDocument doc = new XmlDocument();
      string patch = Environment.CurrentDirectory + @"\XML\XMLFile1.xml";
      doc.Load(patch);

      foreach (XmlNode node in doc.DocumentElement)
      {
        string name = node.Attributes[0].Value;
        int age = int.Parse(node["Age"].InnerText);
        bool programmer = bool.Parse(node["Programmer"].InnerText);
        listBox1.Items.Add(new Employee(name, age, programmer));
      }
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (listBox1.SelectedIndex != -1)
      {
        propertyGrid1.SelectedObject = listBox1.SelectedItem;
      }
    }

    private void frmXmlTest_Load(object sender, EventArgs e)
    {
      // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Company". При необходимости она может быть перемещена или удалена.
      this.companyTableAdapter.Fill(this.databaseDataSet.Company);
      // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Person". При необходимости она может быть перемещена или удалена.
      this.personTableAdapter.Fill(this.databaseDataSet.Person);

      prTextProp = new PropertyTextField();
      prLogicProp = new PropertyTrueFalse();
      prCategoryProp = new PropertyCategories();
      prColorProp = new PropertyColorSelector();
      prFontProp = new PropertyFontConfig();
      prListProp = new PropertyList();

      cbKindOfProps.SelectedIndex = 0;

    }

    private void cbKindOfProps_SelectedIndexChanged(object sender, EventArgs e)
    {
      switch (cbKindOfProps.SelectedIndex)
      {
        case 0:
          prgProperty.SelectedObject = prTextProp;
          break;
        case 1:
          prgProperty.SelectedObject = prLogicProp;
          break;
        case 2:
          prgProperty.SelectedObject = prCategoryProp;
          break;
        case 3:
          prgProperty.SelectedObject = prColorProp;
          break;
        case 4:
          prgProperty.SelectedObject = prFontProp;
          break;
        case 5:
          prgProperty.SelectedObject = prListProp;
          break;
      }
    }
  }
}
