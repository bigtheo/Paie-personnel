using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paie_personnel.Common.Controls
{
    public class CustomButton: Button
    {
        public int CornerRaduis { get; set; }
        public int BorderSize { get; set; }

        protected override void OnPaint(PaintEventArgs pevent)
        {
           
            base.OnPaint(pevent);

        }

    }
}
