using Rynte.UI2.Helpers;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Rynte.UI2
{
   public class RynteComboBox : ComboBox
   {
      private Color _borderColor = Color.Gray;

      [Browsable(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public Color BorderColor
      {
         get => _borderColor;
         set
         {
            if (_borderColor != value)
            {
               _borderColor = value;
               Invalidate();
            }
         }
      }

      private Color _buttonColor = Color.LightGray;

      [Browsable(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public Color ButtonColor
      {
         get => _buttonColor;
         set
         {
            if (_buttonColor != value)
            {
               _buttonColor = value;
               Invalidate();
            }
         }
      }

      protected override void WndProc(ref Message m)
      {
         if (m.Msg == 0xF && DropDownStyle != ComboBoxStyle.Simple)
         {
            Rectangle clientRect = ClientRectangle;

            int dropDownButtonWidth = SystemInformation.HorizontalScrollBarArrowWidth;

            Rectangle outerBorder = new Rectangle(clientRect.Location, new Size(clientRect.Width - 1, clientRect.Height - 1));
            Rectangle innerBorder = new Rectangle(outerBorder.X + 1, outerBorder.Y + 1, outerBorder.Width - dropDownButtonWidth - 2, outerBorder.Height - 2);
            Rectangle innerInnerBorder = new Rectangle(innerBorder.X + 1, innerBorder.Y + 1, innerBorder.Width - 2, innerBorder.Height - 2);
            Rectangle dropDownRect = new Rectangle(innerBorder.Right + 1, innerBorder.Y, dropDownButtonWidth, innerBorder.Height + 1);

            if (RightToLeft == RightToLeft.Yes)
            {
               innerBorder.X = clientRect.Width - innerBorder.Right;
               innerInnerBorder.X = clientRect.Width - innerInnerBorder.Right;
               dropDownRect.X = clientRect.Width - dropDownRect.Right;
               dropDownRect.Width += 1;
            }
            Color innerBorderColor = Enabled ? BackColor : SystemColors.Control;
            Color outerBorderColor = Enabled ? _borderColor : SystemColors.ControlDark;
            Color buttonColor = Enabled ? _buttonColor : SystemColors.Control;
            Point middle = new Point(dropDownRect.Left + dropDownRect.Width / 2, dropDownRect.Top + dropDownRect.Height / 2);

            Point[] arrow = new Point[]
            {
                new Point(middle.X - 3, middle.Y - 2),
                new Point(middle.X + 4, middle.Y - 2),
                new Point(middle.X, middle.Y + 2)
            };

            ImportMethods.PAINTSTRUCT ps = new ImportMethods.PAINTSTRUCT();
            bool shoulEndPaint = false;

            IntPtr dc;
            if (m.WParam == IntPtr.Zero)
            {
               dc = ImportMethods.BeginPaint(Handle, ref ps);
               m.WParam = dc;
               shoulEndPaint = true;
            }
            else
            {
               dc = m.WParam;
            }

            IntPtr rgn = ImportMethods.CreateRectRgn(innerInnerBorder.Left, innerInnerBorder.Top, innerInnerBorder.Right, innerInnerBorder.Bottom);

            ImportMethods.SelectClipRgn(dc, rgn);

            DefWndProc(ref m);

            ImportMethods.DeleteObject(rgn);

            rgn = ImportMethods.CreateRectRgn(clientRect.Left, clientRect.Top, clientRect.Right, clientRect.Bottom);

            ImportMethods.SelectClipRgn(dc, rgn);

            using (Graphics g = Graphics.FromHdc(dc))
            {
               using (SolidBrush b = new SolidBrush(buttonColor))
               {
                  g.FillRectangle(b, dropDownRect);
               }
               using (SolidBrush b = new SolidBrush(outerBorderColor))
               {
                  g.FillPolygon(b, arrow);
               }
               using (Pen p = new Pen(innerBorderColor))
               {
                  g.DrawRectangle(p, innerBorder);
                  g.DrawRectangle(p, innerInnerBorder);
               }
               using (Pen p = new Pen(outerBorderColor))
               {
                  g.DrawRectangle(p, outerBorder);
               }
            }
            if (shoulEndPaint)
            {
               ImportMethods.EndPaint(Handle, ref ps);
            }

            ImportMethods.DeleteObject(rgn);
         }
         else
         {
            base.WndProc(ref m);
         }
      }
   }
}
