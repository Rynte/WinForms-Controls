using Rynte.UI2.Helpers;
using Rynte.UI2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace Rynte.UI2
{
   public class RynteTabControl : TabControl
   {
      private readonly Dictionary<Button, TabPage> _listButton = new Dictionary<Button, TabPage>();

      public RynteTabControl()
      {
         SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
         SizeMode = TabSizeMode.Normal;
         ItemSize = new Size(240, 16);
      }

      public event CancelEventHandler CloseButtonClick;

      private bool _showCloseButtonOnTabs = true;

      [Browsable(true)]
      [DefaultValue(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public bool ShowButton
      {
         get => _showCloseButtonOnTabs;
         set
         {
            _showCloseButtonOnTabs = value;
            foreach (Button btn in _listButton.Keys)
            {
               btn.Visible = _showCloseButtonOnTabs;
            }

            RePositionCloseButtons();
         }
      }

      private Color _tabColor = Color.Gray;

      [Browsable(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public Color TabColor
      {
         get => _tabColor;
         set
         {
            _tabColor = value;
            Refresh();
         }
      }

      private Color _textTabColor = Color.White;

      [Browsable(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public Color TextTabColor
      {
         get => _textTabColor;
         set
         {
            _textTabColor = value;
            Refresh();
         }
      }

      private Color _headerBackColor = Color.FromArgb(64, 64, 64);

      [Browsable(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public Color HeaderBackColor
      {
         get => _headerBackColor;
         set
         {
            _headerBackColor = value;
            Refresh();
         }
      }

      private Color _borderPageColor = Color.White;

      [Browsable(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public Color BorderPageColor
      {
         get => _borderPageColor;
         set
         {
            _borderPageColor = value;
            Refresh();
         }
      }

      private Color _selectTabColor = Color.FromArgb(82, 156, 215);

      [Browsable(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public Color SelectTabColor
      {
         get => _selectTabColor;
         set
         {
            _selectTabColor = value;
            Refresh();
         }
      }

      private Color _selectTextTabColor = Color.White;

      [Browsable(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public Color SelectTextTabColor
      {
         get => _selectTextTabColor;
         set
         {
            _selectTextTabColor = value;
            Refresh();
         }
      }

      protected override void OnPaint(PaintEventArgs e)
      {
         base.OnPaint(e);

         e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
         e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

         using (Brush solid = new SolidBrush(_headerBackColor))
         {
            e.Graphics.FillRectangle(solid, new Rectangle(0, 0, Width, Height));
         }

         for (int i = 0; i <= TabCount - 1; ++i)
         {
            Rectangle rect = GetTabRect(i);

            int y = rect.Location.Y;
            int x = rect.Location.X + 2;

            Size size = new Size(rect.Width, rect.Height);

            Rectangle rect1 = new Rectangle(new Point(x, y), size);
            Rectangle rect2 = new Rectangle(rect1.Location, new Size(rect1.Width, rect1.Height));

            if (i == SelectedIndex)
            {
               using (Brush solid = new SolidBrush(_headerBackColor))
               {
                  e.Graphics.FillRectangle(solid, rect2);
               }

               using (Brush brush = new SolidBrush(_selectTabColor))
               {
                  e.Graphics.FillRectangle(brush, new Rectangle(rect1.X - 4, rect1.Y - 3, rect1.Width - 1, rect1.Height + 5));
               }

               using (Brush brush = new SolidBrush(_selectTextTabColor))
               {
                  e.Graphics.DrawString(TabPages[i].Text, Font, brush, rect2.X, rect2.Y / 2 + 1);
               }
            }
            else
            {
               using (Brush brush = new SolidBrush(_tabColor))
               {
                  e.Graphics.FillRectangle(brush, new Rectangle(rect1.X - 4, rect1.Y + 1, rect1.Width - 1, rect1.Height + 5));
               }

               using (Brush brush = new SolidBrush(_textTabColor))
               {
                  e.Graphics.DrawString(TabPages[i].Text, Font, brush, rect2.X, rect2.Y / 2 + 3);
               }
            }

            using (Brush brush = new SolidBrush(_borderPageColor))
            {
               e.Graphics.FillRectangle(brush, new Rectangle(1, 19, Width - 2, Height - 20));
            }
         }
      }

      protected override void OnCreateControl()
      {
         base.OnCreateControl();
         RePositionCloseButtons();
      }

      protected override void OnControlAdded(ControlEventArgs e)
      {
         base.OnControlAdded(e);

         TabPage tp = (TabPage)e.Control;
         Rectangle rect = GetTabRect(TabPages.IndexOf(tp));

         Button btn = AddCloseButton(tp);
         btn.Location = new Point(rect.X + rect.Width - rect.Height - 1, rect.Y + 1);
         btn.Click += OnCloseButtonClick;

         _listButton.Add(btn, tp);

         ImportMethods.SetParent(btn.Handle, Handle);
      }

      protected override void OnControlRemoved(ControlEventArgs e)
      {
         Button btn = CloseButtonOfTabPage((TabPage)e.Control);
         btn.Click -= OnCloseButtonClick;

         _listButton.Remove(btn);

         ImportMethods.SetParent(btn.Handle, Handle);
         btn.Dispose();

         base.OnControlRemoved(e);
      }

      protected override void OnLayout(LayoutEventArgs levent)
      {
         base.OnLayout(levent);
         RePositionCloseButtons();
      }

      protected virtual void OnCloseButtonClick(object sender, EventArgs e)
      {
         if (!DesignMode)
         {
            Button btn = (Button)sender;
            TabPage tp = _listButton[btn];

            CancelEventArgs ee = new CancelEventArgs();

            CloseButtonClick?.Invoke(sender, ee);

            if (!ee.Cancel)
            {
               TabPages.Remove(tp);
               RePositionCloseButtons();
            }
         }
      }

      protected virtual Button AddCloseButton(TabPage tp)
      {
         Button closeButton = new Button()
         {
            BackColor = _selectTabColor,
            FlatStyle = FlatStyle.Flat,
            BackgroundImage = Resources.Close,
            BackgroundImageLayout = ImageLayout.Zoom
         };
         closeButton.FlatAppearance.BorderSize = 0;

         return closeButton;
      }

      public void RePositionCloseButtons()
      {
         foreach (KeyValuePair<Button, TabPage> item in _listButton)
         {
            RePositionCloseButtons(item.Value);
         }
      }

      public void RePositionCloseButtons(TabPage tp)
      {
         Button btn = CloseButtonOfTabPage(tp);

         if (btn != null)
         {
            int tpIndex = TabPages.IndexOf(tp);

            if (tpIndex >= 0)
            {
               Rectangle rect = GetTabRect(tpIndex);

               if (SelectedTab == tp)
               {
                  btn.Size = new Size(rect.Height - 4, rect.Height - 4);
                  btn.Location = new Point(rect.X + rect.Width - rect.Height - 1, rect.Y + 1);
                  btn.Visible = ShowButton;
               }
               else
               {
                  btn.Visible = false;
               }

               btn.BringToFront();
            }
         }
      }

      protected Button CloseButtonOfTabPage(TabPage tp)
      {
         return (from item in _listButton where item.Value == tp select item.Key).FirstOrDefault();
      }
   }
}
