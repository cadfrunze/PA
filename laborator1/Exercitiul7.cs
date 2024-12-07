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
        public string TempMinMax(string decizie, float[] zileTemp){
            float temp = zileTemp[0];
            int ziua = 1;
            if (decizie == "minim"){
                for (int i = 1; i < zileTemp.Length; i++)
                {
                    if (zileTemp[i] < temp)
                    {
                        temp = zileTemp[i];
                        ziua = i + 1;
                    }
                    
                }
                return "Temperatura cea mai mica a fost in ziua de " + ziua + ", temperatura fiind de " + temp;
            }
            else if (decizie == "maxim"){
                temp = zileTemp[0];
                ziua = 1;
                for (int i = 1; i < zileTemp.Length; i++)
                {
                    if (zileTemp[i] > temp)
                    {
                        temp = zileTemp[i];
                        ziua = i + 1;
                    }
                    
                }
                return "Temperatura cea mai mare a fost in ziua de " + ziua + ", temperatura fiind de " + temp;

            }
            return "Nu am inteles";
                    
            
            
        }

    }
}
