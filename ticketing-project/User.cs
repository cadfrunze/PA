﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ticketing_project
{
    internal class User : DbAcess
    {

        Dictionary<string, string> regUser = new Dictionary<string, string>();
        private string _name, _prenume, _cnp, _email, _telefon, _serieTicket, _tipTicket;
        private string interpretor = Environment.GetEnvironmentVariable("interpreter");
        private string pathScript = Environment.GetEnvironmentVariable("route_script");


        public User()
        {
            regUser.Add("nume", null);
            regUser.Add("prenume", null);
            regUser.Add("cnp", null);
            regUser.Add("email", null);
            regUser.Add("telefon", null);
            regUser.Add("serie_ticket", null);
            regUser.Add("tip_ticket", null);
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
        string GenerareTicket()
        {
            string ALFABET = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string final = "";

            Random randomStart = new Random();
            int num = randomStart.Next(0, 2);

            if (num == 0)
            {
                while (true)
                {
                    num = randomStart.Next(1, 10);
                    final = final + num.ToString();
                    if (final.Length == 11) { break; }
                    else if (final.Length == 3)
                    {
                        final = final + "-";
                    }
                    num = randomStart.Next(ALFABET.Length - 1);
                    char caracter = ALFABET[num];
                    final = final + caracter;
                    if (final.Length == 7)
                    {
                        final = final + "-";
                    }
                }

            }
            else
            {
                while (true)
                {
                    num = randomStart.Next(ALFABET.Length - 1);
                    char caracter = ALFABET[num];
                    final = final + caracter;
                    if (final.Length == 11) { break; }
                    else if (final.Length == 3)
                    {
                        final = final + "-";
                    }
                    num = randomStart.Next(1, 10);
                    final = final + num.ToString();
                    if (final.Length == 7)
                    {
                        final = final + "-";
                    }
                }
            }
            return final;
        }
        public void NewUser()
        {
            regUser["nume"] = Name;
            regUser["prenume"] = Prenom;
            regUser["cnp"] = Cnp;
            regUser["email"] = Email;
            regUser["telefon"] = Telefon;
            _serieTicket = GenerareTicket();
            regUser["serie_ticket"] = _serieTicket;
            regUser["tip_ticket"] = TipTicket;
            InsertClient(regUser);
        }
        public bool CkeckCnp()
        {
            List<string> listaCnp = CnpList();
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
            List<StocBilete> stocuri = ExtrageBilete();
            return stocuri;
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
            
            string newSerie = "";
            for (int i = 0; i < serie.Length; i++)
            {
                if (i == 3 || i == 6)
                {
                    newSerie = newSerie + "-";
                }
                newSerie = newSerie + serie[i];
            }
            return DateClientBilet(cnp, newSerie);
        }

        public DateClient PrelucareInfoValidare(string serie_ticket)
        {
            string newSerie = "";
            for (int i = 0; i < serie_ticket.Length; i++)
            {
                if (i == 3 || i == 6)
                {
                    newSerie = newSerie + "-";
                }
                newSerie = newSerie + serie_ticket[i];
            }
            return ValidareTicket(newSerie);
        }
        
    }
}
