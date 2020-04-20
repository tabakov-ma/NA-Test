using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;


namespace Excel.XML.Property_classes
{
  class PropertyList
  {
    Direction m_dir;
    [DisplayName("Direction")]
    [Description("Direction property")]
    [TypeConverter(typeof(DirConverter))]
    public Direction Dir
    {
      get
      {
        return m_dir;
      }
      set
      {
        m_dir = value;
      }
    }
  }
  enum Direction
  {
    [Description("UP")]
    UP,
    [Description("DOWN")]
    DOWN,
    [Description("RIGHT")]
    RIGHT,
    [Description("LEFT")]
    LEFT
  }
  class DirConverter : EnumConverter
  {
    private Type type;

    public DirConverter(Type type)
        : base(type)
    {
      this.type = type;
    }

    public override object ConvertTo(ITypeDescriptorContext context,
        CultureInfo culture, object value, Type destType)
    {
      FieldInfo fi = type.GetField(Enum.GetName(type, value));
      DescriptionAttribute descAttr =
        (DescriptionAttribute)Attribute.GetCustomAttribute(
          fi, typeof(DescriptionAttribute));

      if (descAttr != null)
        return descAttr.Description;
      else
        return value.ToString();
    }

    public override object ConvertFrom(ITypeDescriptorContext context,
        CultureInfo culture, object value)
    {
      foreach (FieldInfo fi in type.GetFields())
      {
        DescriptionAttribute descAttr =
          (DescriptionAttribute)Attribute.GetCustomAttribute(
            fi, typeof(DescriptionAttribute));

        if ((descAttr != null) && ((string)value == descAttr.Description))
          return Enum.Parse(type, fi.Name);
      }
      return Enum.Parse(type, (string)value);
    }
  }
}
