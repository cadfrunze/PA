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
        private bool _response; // Vezi User (true = invalid, false = valid)
        private const string connectionString =
            "Data Source=DESKTOP-H2RI6NV\\SQLEXPRESS;Initial Catalog=spectacol;Integrated Security=True";

        //public DbAcess()
        //{
        //    Console.WriteLine(Testconn());
        //}
        public bool Response
        {
            get { return _response; }
            set { _response = value; }
        }

        public void InsertClient(Dictionary<string, string> UserFinal)
        {   
            CheckClient(UserFinal);
            if (Response is false)
            {
                string sqlQuery = @"
                                    insert into evidenta_clienti (nume, prenume, cnp, email, telefon)
                                    values (@nume, @prenume, @cnp, @email, @telefon)";
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@nume", UserFinal["nume"]);
                            cmd.Parameters.AddWithValue("@prenume", UserFinal["prenume"]);
                            cmd.Parameters.AddWithValue("@cnp", UserFinal["cnp"]);
                            cmd.Parameters.AddWithValue("@email", UserFinal["email"]);
                            cmd.Parameters.AddWithValue("@telefon", UserFinal["telefon"]);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            Response = false;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
        }

        public void CheckClient(Dictionary<string, string> UserFinal)
        {
            Response = false;
            List<string> cnpuri = new List<string>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlCommand = "select cnp from evidenta_clienti";
                    using (SqlCommand cmd = new SqlCommand(sqlCommand, conn))
                    {
                        using (SqlDataReader  rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                cnpuri.Add(rdr["cnp"].ToString());
                            }
                        }
                    }
                    
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            Console.WriteLine(cnpuri.ToString());
            foreach (string cnp in cnpuri)
            {
                if (cnp == UserFinal["cnp"])
                {
                    Response = true;
                    break;
                }
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

        
     
