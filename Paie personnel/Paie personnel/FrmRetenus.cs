using MySql.Data.MySqlClient;
using Paie_personnel.Common.Helper;
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
    public partial class FrmRetenus : Form
    {
        public FrmRetenus()
        {
            InitializeComponent();
            ListerAvances();
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            new FrmAjouterAvance().ShowDialog();
        }
        private void ListerAvances()
        {
            string sql = "select p.id,p.nom,p.Fonction,a.createdtime 'Date',a.montant from personnel p,avance a where p.id = a.personnel_id and  date(a.createdtime)=date(now()) union select '01','-','Total','-',sum(montant) from avance where date(createdtime)=date(now())";
            Connexion.OuvrirConnexion();
            using (MySqlCommand cmd = new MySqlCommand(sql, Connexion.Con))
            {

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    da.Fill(table);
                    DgvListe.DataSource = table;
                }
            }
        }

    }
}
