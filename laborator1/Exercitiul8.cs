using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace laborator_1
{
    internal class Exercitiul8
    {
        public int[,] matricea(int randuri, int coloane)
        {
            int[,] tbl = new int[randuri, coloane];
            for (int i = 0; i < tbl.GetLength(0); i++) {
                for (int j = 0; j < tbl.GetLength(1); j++) {
                    tbl[i, j] = i * j;
                }

            }
            return tbl;
        }
          
    }  
}
