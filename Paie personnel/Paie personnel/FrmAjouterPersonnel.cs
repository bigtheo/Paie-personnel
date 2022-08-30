using MySql.Data.MySqlClient;
using Paie_personnel.Common.Helper;
using System;
using System.Runtime.InteropServices;
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
            this.Close();
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_nom.Text) && !string.IsNullOrEmpty(cbx_fonction.Text))
            {
                if (PersonnelInsertedSuccessFully())
                {
                    MessageBox.Show("Enregistrement effectué avec succès ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    txt_nom.Clear();
                    cbx_fonction.Text = string.Empty;
                    nup_salaire_base.Value = 0;
                
                }
            }
            else
            {
                MessageBox.Show("Le nom ou la fonction ne peut pas être égal null", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                txt_nom.Focus();
            }
        }

        private bool PersonnelInsertedSuccessFully()
        {
            string sql = "Insert into personnel (nom, Fonction, Salaire, Transport, Logement, Assidite, Diplome, PFonction, Enfant, CNSS, DGI, Autres) values(@nom, @Fonction, @Salaire, @Transport, @Logement, @Assidite, @Diplome, @PFonction, @Enfant, @CNSS, @DGI, @Autres); ";
            using (MySqlCommand cmd = new MySqlCommand(sql, Connexion.Con))
            {
                MySqlParameter p_nom = new MySqlParameter("@nom", MySqlDbType.VarChar)
                {
                    Value = txt_nom.Text
                };
                MySqlParameter p_fonction = new MySqlParameter("@Fonction", MySqlDbType.VarChar)
                {
                    Value = cbx_fonction.Text
                };
                MySqlParameter p_salaire = new MySqlParameter("@Salaire", MySqlDbType.Decimal)
                {
                    Value = nup_salaire_base.Value
                };
                MySqlParameter p_transport = new MySqlParameter("@Transport", MySqlDbType.Decimal)
                {
                    Value = nup_transport.Value
                };
                MySqlParameter p_logement = new MySqlParameter("@Logement", MySqlDbType.Decimal)
                {
                    Value = nup_logement.Value
                };

                MySqlParameter p_assidite = new MySqlParameter("@Assidite", MySqlDbType.Decimal)
                {
                    Value = nup_assidite.Value
                };

                MySqlParameter p_diplome = new MySqlParameter("@Diplome", MySqlDbType.Decimal)
                {
                    Value = nup_diplome.Value
                };

                MySqlParameter p_PFonction = new MySqlParameter("@PFonction", MySqlDbType.Decimal)
                {
                    Value = nup_fonction.Value
                };

                MySqlParameter p_enfant = new MySqlParameter("@Enfant", MySqlDbType.Decimal)
                {
                    Value = nup_enfant.Value
                };

                MySqlParameter p_cnss = new MySqlParameter("@CNSS", MySqlDbType.Decimal)
                {
                    Value = nup_cnss.Value
                };

                MySqlParameter p_dgi = new MySqlParameter("@DGI", MySqlDbType.Decimal)
                {
                    Value = nup_dgi.Value
                };

                MySqlParameter p_autres = new MySqlParameter("@Autres", MySqlDbType.Decimal)
                {
                    Value = nup_autres.Value
                };

                cmd.Parameters.Add(p_nom);
                cmd.Parameters.Add(p_fonction);
                cmd.Parameters.Add(p_salaire);
                cmd.Parameters.Add(p_diplome);
                cmd.Parameters.Add(p_logement);
                cmd.Parameters.Add(p_transport);
                cmd.Parameters.Add(p_assidite);

                cmd.Parameters.Add(p_enfant);
                cmd.Parameters.Add(p_cnss);
                cmd.Parameters.Add(p_dgi);
                cmd.Parameters.Add(p_autres);
                cmd.Parameters.Add(p_PFonction);

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return true;
                    }

                    return false;
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 3819)
                    {
                        MessageBox.Show("Le salaire ne peut pas être égal 0", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                        return false;
                    }
                    MessageBox.Show($"Message d'erreur : {ex.Message}\ncode de l'erreur : {ex.Number}");
                    return false;
                }
            };
        }
    }
}