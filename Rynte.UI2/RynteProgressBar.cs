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
         Rectangle rec = e.ClipRectangle;

         rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;

         if (ProgressBarRenderer.IsSupported)
         {
            ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
         }

         rec.Height -= 4;
         rec.Inflate(1, 1);

         using (Brush brush = new SolidBrush(_progressColor))
         {
            e.Graphics.FillRectangle(brush, 1, 1, rec.Width, rec.Height);
         }
      }
   }
}
