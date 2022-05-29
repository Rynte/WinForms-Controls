using Rynte.UI2.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rynte.UI2
{
   public partial class RynteDragControl : Component
   {
      public RynteDragControl()
      {
         InitializeComponent();
      }

      private Control _control;

      [Browsable(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public Control Target
      {
         get => _control;
         set
         {
            _control = value;

            if (_control != null)
            {
               _control.MouseDown += OnMouseDown;
            }
         }
      }

      private void OnMouseDown(object sender, MouseEventArgs e)
      {
         ImportMethods.ReleaseCapture();
         ImportMethods.PostMessage(_control.FindForm().Handle, 0x0112, 0xF012, 0);
      }
   }
}
