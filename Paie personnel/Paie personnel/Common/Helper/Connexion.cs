using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Paie_personnel.Common.Helper
{
    public static class Connexion
    {
        public static MySqlConnection Con;

        public static bool OuvrirConnexion()
        {
       
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder()
        {
            Server = "localhost",
            UserID = "root",
            Password = "1993",
            Database = "HrDd"
        };
            
            try
            {
                Con  = new MySqlConnection(builder.ConnectionString);
                Con.Open();
                return true;
            }
            catch (MySqlException ex)
            {
               
                Console.WriteLine(ex.Message);
                return false;
            }

        }

    }
}
