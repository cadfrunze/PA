using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborator_1
{
    internal class Exercitiul6
    {
        public double radacinaPatrata(int nr)
        {
            double sqrt;
            if (nr <= 0) throw new Exception("Numarul trebuie sa fie mai mare ca si 0");
            sqrt = Math.Sqrt(nr);
            return sqrt;
        }
    }
}
