using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticketing_system.modell
{
    internal class StocBilete
    {
        public string TipTicket { get; }
        public int Cantitate { get;}
        public int Pret { get;}
        public StocBilete(string tip_ticket, int cantiate, int pret)
        {
            TipTicket = tip_ticket;
            Cantitate = cantiate;
            Pret = pret;
        }
    }
}
