using MySql.Data.MySqlClient;
using Paie_personnel.Common.Helper;
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

namespace Paie_personnel
{
    public partial class FrmAjouterAvance : Form
    {
        public FrmAjouterAvance()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr handle, int a, int b, int c);
        private void panelBarreTitre_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void FrmFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_matricule.Text)&& !string.IsNullOrEmpty(cbx_mois.Text)&& nup_montant.Value>0)
            {
                EnregisterAvance();
                BtnEnregistrer.Enabled = false; 
            }
            else
            {
                MessageBox.Show("il se pourrait que certains champs sont vides", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
        private void EnregisterAvance()
        {
            string sql = "insert into avance(montant,personnel_id,salaire_id) values(@montant,@personnel_id,@salaire_id)";
            using (MySqlCommand cmd=new MySqlCommand(sql,Connexion.Con))
            {
                MySqlParameter p_montant = new MySqlParameter("@montant", MySqlDbType.Decimal)
                {
                    Value=nup_montant.Value
                };

                MySqlParameter p_personnel_id = new MySqlParameter("@personnel_id", MySqlDbType.Int64)
                {
                    Value = txt_matricule.Value
                };

                MySqlParameter p_salaire_id = new MySqlParameter("@salaire_id", MySqlDbType.Int64)
                {
                    Value = 1
                };

                cmd.Parameters.Add(p_montant);
                cmd.Parameters.Add(p_personnel_id);
                cmd.Parameters.Add(p_salaire_id);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Enregistrement effectué avec succès","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 1452:
                            MessageBox.Show($"Le matricle n° : {txt_matricule.Text} n'est pas attribué.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                            default:
                            MessageBox.Show($"Erreur n° : {ex.Number}\nVeuillez contacter l'administrateur", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            break;

                    }

                }
            }
        }
        private void GetPersonnelInformations()
        {
            string sql = "select p.id, p.nom,p.Fonction,p.Salaire + p.Transport + p.Logement + p.Assidite + p.Diplome + p.Pfonction 'Salaire Brut',\r\np.Enfant + p.CNSS + p.DGI + Autres  + ifnull(sum(a.montant),0) Retenu ,\r\n(p.Salaire + p.Transport + p.Logement + p.Assidite + p.Diplome + p.Pfonction )-(p.Enfant + p.CNSS + p.DGI + Autres ) - ifnull(sum(a.montant),0) 'Net à payer' \r\nfrom  personnel p left join avance a on a.personnel_id = p.id where p.id=@p_id group by (p.id) ;";
            using (MySqlCommand cmd=new MySqlCommand(sql, Connexion.Con))
            {
                MySqlParameter p_id = new MySqlParameter("@p_id", MySqlDbType.Int64)
                {
                    Value = txt_matricule.Value
                };
                cmd.Parameters.Add(p_id);


                MySqlDataReader dr = cmd.ExecuteReader();

                lbl_nom.Text = "-";
                lbl_fonction.Text = "0";
                lbl_salaire_de_brut.Text = "0";
                lbl_retenu.Text = "0";

                while (dr.Read())
                {
                    lbl_nom.Text = dr.GetString(1);
                    lbl_fonction.Text = dr.GetString(2);
                    lbl_salaire_de_brut.Text=dr.GetString(3);
                    lbl_retenu.Text = dr.GetString(4);
                }
                dr.Close();


            }
            {

            }
        }

        private void txt_matricule_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                GetPersonnelInformations();

                if(decimal.TryParse(lbl_salaire_de_brut.Text,out decimal salaire_brut))
                {
                    if(salaire_brut > 0)
                    {
                        BtnEnregistrer.Enabled= true;
                    }
                    else
                    {
                        BtnEnregistrer.Enabled = false;
                    }
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lbl_retenu_Click(object sender, EventArgs e)
        {

        }

        private void lbl_fonction_Click(object sender, EventArgs e)
        {

        }

        private void lbl_nom_Click(object sender, EventArgs e)
        {

        }

        private void lbl_salaire_de_brut_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nup_montant_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cbx_mois_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txt_matricule_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
