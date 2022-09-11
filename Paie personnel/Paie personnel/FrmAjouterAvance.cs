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
    }
}
