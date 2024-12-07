using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborator_1
{
    internal class Exercitiul5
    {
        public float calculTva(int pret, int tva)
        {
            float tvaCuPret, totalSum;
            tvaCuPret = pret * (float)tva / 100;
            totalSum = pret + tvaCuPret;
            return totalSum;
        }
    }
}
