using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paie_personnel.Common.UserControl
{
    public partial class FrmAjouterPersonnel : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr handle, int a, int b, int c);
        public FrmAjouterPersonnel()
        {
            InitializeComponent();
        }

        private void panelBarreTitre_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmFermer_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
