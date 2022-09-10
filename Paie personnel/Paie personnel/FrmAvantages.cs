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
    public partial class FrmAvantages : Form
    {
        public FrmAvantages()
        {
            InitializeComponent();
            ListerAvantages();
        }


        private void ListerAvantages()
        {
            string sql = "Select Id,nom Noms, Fonction, Salaire,Transport,Logement,Assidite 'Assidité',Pfonction 'Primes',salaire +Transport + Logement + Assidite + Diplome + PFonction as Total from personnel";
            Connexion.OuvrirConnexion();
            using (MySqlCommand cmd=new MySqlCommand (sql,Connexion.Con))
            {

                using (MySqlDataAdapter da=new MySqlDataAdapter (cmd))
                {
                    DataTable table = new DataTable();
                    da.Fill (table);
                    DgvListe.DataSource = table;
                }
            }
        }
    }
}
