using Paie_personnel.Common.Core;
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
        Color defaultColor = Color.FromArgb(34, 34, 34);
        Color activeColor = Color.FromArgb(3, 136, 232);

        private Form activeForm;
        public FrmAccueil()
        {
            InitializeComponent();
        }

        private void BtnPersonnel_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FrmPersonnel());
            BtnPersonnel.Image= Couleur.ChangeColor((Bitmap)BtnPersonnel.Image);
            BtnPersonnel.ForeColor = activeColor;
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

        private void BtnAvantages_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FrmPersonnel());
            BtnAvantages.Image = Couleur.ChangeColor((Bitmap)BtnAvantages.Image);
            BtnAvantages.ForeColor = activeColor;
        }

        private void BtnRetenus_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FrmPersonnel());
            BtnRetenus.Image = Couleur.ChangeColor((Bitmap)BtnRetenus.Image);
            BtnRetenus.ForeColor = activeColor;
        }

        private void BtnPaiements_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FrmPersonnel());
            BtnPaiements.Image = Couleur.ChangeColor((Bitmap)BtnPaiements.Image);
            BtnPaiements.ForeColor = activeColor;
        }
    }
}
