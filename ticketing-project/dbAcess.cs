using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ticketing_project
{   
    internal class dbAcess
    {
        private const string connectionString =
            "Data Source=DESKTOP-H2RI6NV\\SQLEXPRESS;Initial Catalog=testing;Integrated Security=True";

        public bool Testconn()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("succes");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                return false;
            }
        }
    }
}

        
     
