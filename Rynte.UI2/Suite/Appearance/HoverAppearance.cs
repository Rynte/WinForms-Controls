using System.ComponentModel;
using System.Drawing;

namespace Rynte.UI2.Suite.Appearance
{
   [TypeConverter(typeof(ExpandableObject))]
   public class HoverAppearance
   {
      private int _borderSize;

      [Browsable(true)]
      [NotifyParentProperty(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public int BorderSize
      {
         get => _borderSize;
         set => _borderSize = value;
      }

      private Color _borderColor;

      [Browsable(true)]
      [NotifyParentProperty(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public Color BorderColor
      {
         get => _borderColor;
         set => _borderColor = value;
      }
   }
}
