using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticketing_project
{
    internal  class StocBilete
    {
        
        public string TipTicket { get; set; }
        public int Cantitate {  get; set; }
        public int Pret {  get; set; }
        public StocBilete(string tip_ticket, int cantiate, int pret) 
        {
            TipTicket = tip_ticket;
            Cantitate = cantiate;
            Pret = pret;
        }

        



    }
}
