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
    }
}
