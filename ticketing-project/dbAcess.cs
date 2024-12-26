using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ticketing_project
{   
    internal class DbAcess
    {
        private const string connectionString =
            "Data Source=DESKTOP-H2RI6NV\\SQLEXPRESS;Initial Catalog=spectacol;Integrated Security=True";

        //public DbAcess()
        //{
        //    Console.WriteLine(Testconn());
        //}
        public void Regis(Dictionary<string, string> UserFinal)
        {
            foreach (var detail in UserFinal) { 
                Console.WriteLine($"keya {detail.Key} || valoarea {detail.Value}");
            }
        }



        bool Testconn()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    conn.Close();
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

        
     
