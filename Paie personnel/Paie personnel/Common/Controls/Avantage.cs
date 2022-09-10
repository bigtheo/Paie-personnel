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
    public partial class Avantage : UserControl
    {
        public Avantage()
        {
            InitializeComponent();
        }

        [Category("Custom Props")]
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; lbl_nom.Text = value; }
        }

    }
}
