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
    public partial class FrmAccueil : Form
    {
        private Form activeForm;
        public FrmAccueil()
        {
            InitializeComponent();
        }

        private void BtnPersonnel_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FrmPersonnel());

        }


        #region Ouverir le formulaire
        private void OuvrirFormulaire(Form formulaireEnfant)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = formulaireEnfant;
            formulaireEnfant.TopLevel = false;
            formulaireEnfant.FormBorderStyle = FormBorderStyle.None;
            formulaireEnfant.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(formulaireEnfant);
            panelContainer.Tag = formulaireEnfant;
            formulaireEnfant.BringToFront();
            formulaireEnfant.Show();

        }

        #endregion

    }
}
