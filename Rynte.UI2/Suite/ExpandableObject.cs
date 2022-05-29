using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rynte.UI2.Suite
{
   internal class ExpandableObject : ExpandableObjectConverter
   {
      public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
      {
         if (destinationType == typeof(string))
         {
            return "";
         }

         return base.ConvertTo(context, culture, value, destinationType);
      }
   }
}
