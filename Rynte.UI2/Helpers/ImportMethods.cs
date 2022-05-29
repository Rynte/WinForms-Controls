using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Rynte.UI2.Helpers
{
   internal class ImportMethods
   {
      [DllImport("user32.dll", CharSet = CharSet.Unicode)]
      public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, string lp);

      [DllImport("user32", CharSet = CharSet.Auto)]
      public static extern bool PostMessage(IntPtr hWnd, uint Msg, uint WParam, uint LParam);

      [DllImport("user32", CharSet = CharSet.Auto)]
      public static extern bool ReleaseCapture();

      [DllImport("user32.dll")]
      public static extern IntPtr BeginPaint(IntPtr hWnd, [In, Out] ref PAINTSTRUCT lpPaint);

      [DllImport("user32.dll")]
      public static extern bool EndPaint(IntPtr hWnd, ref PAINTSTRUCT lpPaint);

      [DllImport("gdi32.dll")]
      public static extern int SelectClipRgn(IntPtr hDC, IntPtr hRgn);

      [DllImport("user32.dll")]
      public static extern int GetUpdateRgn(IntPtr hwnd, IntPtr hrgn, bool fErase);

      [DllImport("gdi32.dll")]
      public static extern bool DeleteObject(IntPtr hObject);

      [DllImport("gdi32.dll")]
      public static extern IntPtr CreateRectRgn(int x1, int y1, int x2, int y2);

      [DllImport("user32")]
      public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

      [StructLayout(LayoutKind.Sequential)]
      public struct PAINTSTRUCT
      {
         public IntPtr hdc;
         public bool fErase;
         public int rcPaint_left;
         public int rcPaint_top;
         public int rcPaint_right;
         public int rcPaint_bottom;
         public bool fRestore;
         public bool fIncUpdate;
         public int reserved1;
         public int reserved2;
         public int reserved3;
         public int reserved4;
         public int reserved5;
         public int reserved6;
         public int reserved7;
         public int reserved8;
      }
   }
}
