using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ticketing_project
{   
    internal abstract class DbAcess
    {
  
        private const string connectionString =
            "Data Source=DESKTOP-H2RI6NV\\SQLEXPRESS;Initial Catalog=spectacol;Integrated Security=True";

        public void InsertClient(Dictionary<string, string> UserFinal)
        {   
            
                string sqlQuery = "EXEC dbo.NewUser @nume, @prenume, @cnp, @email, @telefon, @tip_ticket, @serie_ticket";
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
                            cmd.Parameters.AddWithValue("@tip_ticket", UserFinal["tip_ticket"]);
                            cmd.Parameters.AddWithValue("@serie_ticket", UserFinal["serie_ticket"]);
                            cmd.ExecuteNonQuery();
                            
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            
        }
        

        public List<string> CnpList()
        {
    
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
            return cnpuri;
            
        }
        public  List<StocBilete> ExtrageBilete()
        {
            List < StocBilete > stocuri = new List<StocBilete>();
            
            int minim = 0;
            string sqlQuery = @"SELECT tip_ticket, pret, cantitate 
                                FROM dbo.stoc_bilete 
                                WHERE cantitate > @minim 
                                ORDER BY pret DESC;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sqlQuery,conn))
                    {
                        cmd.Parameters.AddWithValue("@minim", minim);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string tip_ticket = reader["tip_ticket"].ToString();
                                int cantitate = Convert.ToInt32(reader["cantitate"]);
                                int pret = Convert.ToInt32(reader["pret"]);
                                stocuri.Add(new StocBilete(tip_ticket, cantitate, pret));
                            }
                        }
                    }
                }
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
            return stocuri;
        }
        public bool Testconn()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }
    }
}

        
     
