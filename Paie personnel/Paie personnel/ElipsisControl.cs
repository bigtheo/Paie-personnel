using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paie_personnel
{
   
    class ElipsisControl : Component
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthElipsis,
            int nHeightElipsis
            );

     

        private Control ctrl;
        public Control ControlTarget
        {
            get
            {
                return ctrl;
            }
            set
            {
                ctrl = value;
                if(ctrl != null)
                ctrl.SizeChanged += Ctrl_SizeChanged;
            }
        }

        private void Ctrl_SizeChanged(object sender, EventArgs e)
        {
            ControlTarget.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ctrl.Width, ctrl.Height, _conerRaduis, _conerRaduis));
        }

        private int _conerRaduis = 30;
        public int CornerRadius
        {
            get { return _conerRaduis; }
            set
            {
                _conerRaduis = value;
                if(value != _conerRaduis)
                ControlTarget.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ctrl.Width, ctrl.Height, _conerRaduis, _conerRaduis));
            }
        }
    }
}
