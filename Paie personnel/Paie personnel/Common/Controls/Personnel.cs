using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paie_personnel
{
    public partial class Personnel : UserControl
    {
        #region properties

        [Category("Custom Props")]
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; lbl_nom.Text = value; }
        }

        [Category("Custom Props")]
        private string fonction;

        public string Fonction
        {
            get { return fonction; }
            set { fonction = value;lbl_fonction.Text = value; }
        }

        #endregion

        public Personnel()
        {
            InitializeComponent();
        }

        private void Personnel_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(230, 242, 250); 
        }

        private void Personnel_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 255);
        }
    }
}
