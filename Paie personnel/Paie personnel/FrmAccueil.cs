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
        Color defaultBackColor = Color.FromArgb(221, 221, 221);

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
            BtnPersonnel.BackColor = Color.White;


            //changer la coleur de fond des autres buton

            BtnPaiements.BackColor = DefaultBackColor;
            BtnRetenus.BackColor = DefaultBackColor;
            BtnAvantages.BackColor = DefaultBackColor;


            //changer la couleur du texte

            BtnPaiements.ForeColor = defaultColor;
            BtnRetenus.ForeColor = defaultColor;
            BtnAvantages.ForeColor = defaultColor;


            //changer la couleur des icones
            BtnPaiements.Image = Couleur.DefaultColor((Bitmap)BtnPaiements.Image);
            BtnRetenus.Image = Couleur.DefaultColor((Bitmap)BtnRetenus.Image); ;
            BtnAvantages.Image = Couleur.DefaultColor((Bitmap)BtnAvantages.Image);

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
            OuvrirFormulaire(new FrmAvantages());
            BtnAvantages.Image = Couleur.ChangeColor((Bitmap)BtnAvantages.Image);
            BtnAvantages.ForeColor = activeColor;
            BtnAvantages.BackColor = Color.White;



            //changer la coleur de fond des autres buton

            BtnPaiements.BackColor = DefaultBackColor;
            BtnRetenus.BackColor = DefaultBackColor;
            BtnPersonnel.BackColor = DefaultBackColor;


            //changer la couleur du texte

            BtnPaiements.ForeColor = defaultColor;
            BtnRetenus.ForeColor = defaultColor;
            BtnPersonnel.ForeColor = defaultColor;


            //changer la couleur des icones
            BtnPaiements.Image = Couleur.DefaultColor((Bitmap)BtnPaiements.Image);
            BtnRetenus.Image = Couleur.DefaultColor((Bitmap)BtnRetenus.Image); ;
            BtnPersonnel.Image = Couleur.DefaultColor((Bitmap)BtnPersonnel.Image);
        }

        private void BtnRetenus_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FrmRetenus());
            BtnRetenus.Image = Couleur.ChangeColor((Bitmap)BtnRetenus.Image);
            BtnRetenus.ForeColor = activeColor;
            BtnRetenus.BackColor = Color.White;


            //changer la coleur de fond des autres buton

            BtnPaiements.BackColor = DefaultBackColor;
            BtnAvantages.BackColor = DefaultBackColor;
            BtnPersonnel.BackColor = DefaultBackColor;


            //changer la couleur du texte

            BtnPaiements.ForeColor = defaultColor;
            BtnAvantages.ForeColor = defaultColor;
            BtnPersonnel.ForeColor = defaultColor;


            //changer la couleur des icones
            BtnPaiements.Image = Couleur.DefaultColor((Bitmap)BtnPaiements.Image);
            BtnAvantages.Image = Couleur.DefaultColor((Bitmap)BtnAvantages.Image); ;
            BtnPersonnel.Image = Couleur.DefaultColor((Bitmap)BtnPersonnel.Image);
        }

        private void BtnPaiements_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FrmPaiement());
            BtnPaiements.Image = Couleur.ChangeColor((Bitmap)BtnPaiements.Image);
            BtnPaiements.ForeColor = activeColor;
            BtnPaiements.BackColor =Color.White;



            //changer la coleur de fond des autres buton

            BtnRetenus.BackColor = DefaultBackColor;
            BtnAvantages.BackColor = DefaultBackColor;
            BtnPersonnel.BackColor = DefaultBackColor;


            //changer la couleur du texte

            BtnRetenus.ForeColor = defaultColor;
            BtnAvantages.ForeColor = defaultColor;
            BtnPersonnel.ForeColor = defaultColor;


            //changer la couleur des icones
            BtnRetenus.Image = Couleur.DefaultColor((Bitmap)BtnRetenus.Image);
            BtnAvantages.Image = Couleur.DefaultColor((Bitmap)BtnAvantages.Image); ;
            BtnPersonnel.Image = Couleur.DefaultColor((Bitmap)BtnPersonnel.Image);
        }

        private void FrmAccueil_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
