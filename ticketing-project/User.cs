﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ticketing_project
{
    internal class User
    {
        private DbAcess dbAcess = new DbAcess();
        Dictionary<string, string> regUser = new Dictionary<string, string>();
        private string _name, _prenume, _cnp, _email, _telefon, _serieTicket, _tipTicket;
     
        public User() {
            regUser.Add("nume", null);
            regUser.Add("prenume", null);
            regUser.Add("cnp", null);
            regUser.Add("email", null);
            regUser.Add("telefon", null);
            regUser.Add("serie_ticket", null);
            regUser.Add("tip_ticket", null);
        }
        // getter settere pt actualizare din campuri
        public string Name {
            get { return _name; }
            set { _name = value; }
            
        }
        public string Prenom
        {
            get { return _prenume; }
            set { _prenume = value; }
        }
        public string Cnp
        {
            get { return _cnp; }
            set { _cnp = value; }
        }
        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        // final getters & setters
        string GenerareSerie()
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
        public void Register()
        {
            regUser["nume"] = _name;
            regUser["prenume"] = _prenume;
            _serieTicket = GenerareSerie();
            //dbAcess.Regis(regUser);
        }
    }
}
