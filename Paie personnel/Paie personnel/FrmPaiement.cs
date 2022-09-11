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
    public partial class FrmPaiement : Form
    {
        public FrmPaiement()
        {
            InitializeComponent();
            ListerPaiement();
        }
        private void ListerPaiement()
        {
            string sql = "select p.id, p.nom,p.Fonction,p.salaire 'Salaire de Base',p.Transport,p.Logement,p.Assidite 'Assidité',p.Diplome,p.pFonction Primes, p.Salaire + p.Transport + p.Logement + p.Assidite + p.Diplome + p.Pfonction 'Salaire Brut',p.Enfant ,p.CNSS , p.DGI , Autres,p.Enfant + p.CNSS + p.DGI + Autres Retenus,ifnull(sum(a.montant),0) Avance,(p.Salaire + p.Transport + p.Logement + p.Assidite + p.Diplome + p.Pfonction )-(p.Enfant + p.CNSS + p.DGI + Autres ) - ifnull(sum(a.montant),0) Net from  personnel p left join avance a on a.personnel_id = p.id group by (p.id);";
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
