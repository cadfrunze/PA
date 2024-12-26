using System;
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
        private string _name, _prenume, _cnp, _email, _telefon, serieTicket, tipTicket;
     
        public User() {
            regUser.Add("nume", null);
            regUser.Add("prenume", null);
            regUser.Add("cnp", null);
            regUser.Add("email", null);
            regUser.Add("telefon", null);
            regUser.Add("ser_ticket", null);
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
        public void Register()
        {
            regUser["nume"] = _name;
            regUser["prenume"] = _prenume;
            dbAcess.Regis(regUser);
        }
    }
}
