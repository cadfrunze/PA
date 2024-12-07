using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborator_1
{
    internal class Exercitiul7
    {
        public float tempMedie(float[] tempe)
        {
            float sumTotal = 0;
            foreach(float val in tempe)
            {
                sumTotal += val;
            }
            sumTotal = sumTotal / tempe.Length;
            return sumTotal;

            
        }
    }
}
