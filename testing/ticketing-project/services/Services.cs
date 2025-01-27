using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ticketing_project.DataBase;

namespace ticketing_project
{
    internal class Services
    {

        private DbAcess dbAcess;
        Dictionary<string, string> regUser = new Dictionary<string, string>();
        private string _name, _prenume, _cnp, _email, _telefon, _serieTicket, _tipTicket;
        private string interpretor = Environment.GetEnvironmentVariable("interpreter");
        private string pathScript = Environment.GetEnvironmentVariable("route_script");
        private Tools tools;


        public Services()
        {
            regUser.Add("nume", null);
            regUser.Add("prenume", null);
            regUser.Add("cnp", null);
            regUser.Add("email", null);
            regUser.Add("telefon", null);
            regUser.Add("serie_ticket", null);
            regUser.Add("tip_ticket", null);
            this.dbAcess = new DbAcess();
            this.tools = new Tools();
        }

        public Services(DbAcess dbAcess)
        {
            this.dbAcess = dbAcess;
        }
        // getter settere pt actualizare din campuri
        public string Name
        {
            get { return _name.Trim(); }
            set { _name = value; }

        }
        public string Prenom
        {
            get { return _prenume.Trim(); }
            set { _prenume = value; }
        }
        public string Cnp
        {
            get { return _cnp.Trim(); }
            set { _cnp = value; }
        }
        public string Telefon
        {
            get { return _telefon.Trim(); }
            set { _telefon = value; }
        }
        public string Email
        {
            get { return _email.Trim(); }
            set { _email = value; }
        }
        public string TipTicket
        {
            get { return _tipTicket.Trim(); }
            set { _tipTicket = value; }
        }

        // final getters & setters
        
        public void NewUser()
        {
            regUser["nume"] = Name;
            regUser["prenume"] = Prenom;
            regUser["cnp"] = Cnp;
            regUser["email"] = Email;
            regUser["telefon"] = Telefon;
            _serieTicket = this.tools.GenerareTicket();
            regUser["serie_ticket"] = _serieTicket;
            regUser["tip_ticket"] = TipTicket;
            this.dbAcess.InsertClient(regUser);
        }
        public bool CkeckCnp()
        {
            List<string> listaCnp = this.dbAcess.CnpList();
            foreach (string data in listaCnp)
            {
                if (Cnp == data)
                {
                    return true;
                }
            }
            return false;
        }
        public List<StocBilete> StocuriBilete()
        {
            return this.dbAcess.ExtrageBilete();
            
        }
        public void GenerareBon()
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = interpretor,
                Arguments = $"\"{pathScript}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            try
            {
                using (Process process = Process.Start(processStartInfo))
                {
                    using (StreamReader streamReader = process.StandardOutput)
                    {
                        string result = streamReader.ReadToEnd();
                        Console.WriteLine(result);
                    }
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }

        }
        public DateClient PrelucrareInfo(string cnp, string serie)
        {

            string newSerie = this.tools.prelucrareSerieTicket(serie);

            return this.dbAcess.DateClientBilet(cnp, newSerie);
        }

        public DateClient PrelucareInfoValidare(string serie_ticket)
        {
            string newSerie = this.tools.prelucrareSerieTicket(serie_ticket);
            return this.dbAcess.ValidareTicket(newSerie);
        }

        public void UpdateClient(DateClient client)
        {
            this.dbAcess.updateEvClienti(client.Index, client.Cnp, client.Email, client.Telefon);
        }

        public void DeleteClient(DateClient client)
        {
            this.dbAcess.DropStocClienti(client.Index, client.SerieTicket, client.Cnp);
        }

        
    }
}
