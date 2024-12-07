using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborator_1
{
    internal class exercitiu1
    {
       
        public float convertFahr()
        {
            Console.WriteLine("Temperatura grade C");
            float tempC = float.Parse(Console.ReadLine());
            float tempF = tempC * (float)1.8 + 32;
            return tempF;
        }

        public float convertCelsius()
        {
            Console.WriteLine("Temperatura grade F");
            float tempF = float.Parse(Console.ReadLine());
            float tempC = (5 / 9) * (float)(tempF - 32);
            return tempC;
        }



    }
}
