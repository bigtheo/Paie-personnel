using MySql.Data.MySqlClient;
using Paie_personnel.Common.Helper;
using Paie_personnel.Common.UserControl;
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
    public partial class FrmPersonnel : Form
    {
        public FrmPersonnel()
        {
            InitializeComponent();
            PopulateFlowLayout();
        }

        private void ListePersonnel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            new FrmAjouterPersonnel().ShowDialog();
        }


        private void PopulateFlowLayout()
        {
            this.Cursor = Cursors.WaitCursor;

            string sql = "select nom,fonction from personnel";
            
            using (MySqlCommand cmd =new MySqlCommand(sql, Connexion.Con))
            {
                using(MySqlDataAdapter da=new MySqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();

                    da.Fill(table);

                    
                    foreach(DataRow dr in table.Rows)
                    {
                        Personnel personnel = new Personnel()
                        {
                            Nom = dr[0].ToString(),
                            Fonction = dr[1].ToString(),
                        };

                        ListePersonnel.Controls.Add(personnel);
                    }

                }
            }


            this.Cursor = Cursors.Default;
        }
    }
}
