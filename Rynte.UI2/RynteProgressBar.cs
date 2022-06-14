using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Rynte.UI2
{
   public class RynteProgressBar : ProgressBar
   {
      public RynteProgressBar()
      {
         SetStyle(ControlStyles.UserPaint, true);
         SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
         SetStyle(ControlStyles.SupportsTransparentBackColor, true);
      }

      private Color _fillColor = Color.Gray;

      [Browsable(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public Color FillColor
      {
         get => _fillColor;
         set
         {
            _fillColor = value;
            Invalidate();
         }
      }

      private Color _borderColor = Color.Gray;

      [Browsable(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public Color BorderColor
      {
         get => _borderColor;
         set
         {
            _borderColor = value;
            Invalidate();
         }
      }

      private Color _progressColor = Color.Gray;

      [Browsable(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public Color ProgressColor
      {
         get => _progressColor;
         set
         {
            _progressColor = value;
            Invalidate();
         }
      }

      protected override void OnPaint(PaintEventArgs e)
      {
         base.OnPaint(e);

         Rectangle rec = e.ClipRectangle;
         rec.Inflate(-1, -1);

         rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;

         using (Brush brush = new SolidBrush(_fillColor))
         using (Pen penBorder = new Pen(_borderColor, 1))
         {
            penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

            e.Graphics.FillRectangle(brush, 0, 0, Width - 0.5f, Height - 0.5f);
            e.Graphics.DrawRectangle(penBorder, 0, 0, Width - 0.5f, Height - 0.5f);
         }

         using (Brush brush = new SolidBrush(_progressColor))
         {
            e.Graphics.FillRectangle(brush, 1, 1, rec.Width, rec.Height);
         }
      }
   }
}
