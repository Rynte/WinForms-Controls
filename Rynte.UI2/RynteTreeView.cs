using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Rynte.UI2
{
   public class RynteTreeView : TreeView
   {
      public RynteTreeView()
      {
         DrawMode = TreeViewDrawMode.OwnerDrawText;
      }

      [Browsable(false)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public new bool FullRowSelect { get; set; }

      private bool _selecFullRow;

      [Browsable(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public bool SelectFullRow
      {
         get => _selecFullRow;
         set => _selecFullRow = value;
      }

      private Color _selectNodeBackColor = Color.FromArgb(82, 156, 215);

      [Browsable(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public Color SelectNodeBackColor
      {
         get => _selectNodeBackColor;
         set => _selectNodeBackColor = value;
      }

      private Color _selectNodeForeColor = Color.White;

      [Browsable(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public Color SelectNodeForeColor
      {
         get => _selectNodeForeColor;
         set => _selectNodeForeColor = value;
      }

      protected override void OnDrawNode(DrawTreeNodeEventArgs e)
      {
         Font font = e.Node.NodeFont;

         e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
         e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

         if (e.Node == e.Node.TreeView.SelectedNode)
         {
            using (Brush brush = new SolidBrush(_selectNodeBackColor))
            {
               if (_selecFullRow)
               {
                  e.Graphics.FillRectangle(brush, new RectangleF(0, e.Bounds.Y, Width, e.Bounds.Height));
               }
               else
               {
                  e.Graphics.FillRectangle(brush, e.Bounds);
               }
            }

            TextRenderer.DrawText(e.Graphics, e.Node.Text, font, e.Bounds, _selectNodeForeColor, TextFormatFlags.GlyphOverhangPadding);
         }
         else
         {
            using (Brush brush = new SolidBrush(BackColor))
            {
               e.Graphics.FillRectangle(new SolidBrush(BackColor), e.Bounds);
            }

            TextRenderer.DrawText(e.Graphics, e.Node.Text, font, e.Bounds, e.Node.ForeColor, TextFormatFlags.GlyphOverhangPadding);
         }
      }

      public IEnumerable<TreeNode> GetParents()
      {
         foreach (TreeNode item in Nodes)
         {
            yield return item;
         }
      }
   }
}
