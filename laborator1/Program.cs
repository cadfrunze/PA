using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborator_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercitiu1 exercitiu1 = new exercitiu1();
            //Console.WriteLine(exercitiu1.convertFahr());
            //Console.WriteLine(exercitiu1.convertCelsius());

            //Exercitiul2 exercitiul2 = new Exercitiul2();
            //Console.WriteLine(exercitiul2.isLeapYear());

            //Exercitiul5 exercitiul5 = new Exercitiul5();
            //int pret, tva;
            //while (true)
            //{
            //    Console.WriteLine("Pretul= ");
            //    pret = Convert.ToInt16(Console.ReadLine());
            //    Console.WriteLine("TVA= ");
            //    tva = Convert.ToInt16(Console.ReadLine());
            //    Console.WriteLine("Pretul {0}, TVA {1}, pretul cu TVA {2}", pret, tva, exercitiul5.calculTva(pret, tva));
            //    Console.ReadKey();
            //}

            // Temp medie
            int zile;
            float[] temperaturi;
            Exercitiul7 exercitiul7 = new Exercitiul7();
            Console.WriteLine("Nr. zile: ");
            zile = Convert.ToInt16(Console.ReadLine());
            temperaturi = new float[zile];
            for (int i = 0; i < zile; i++) {
                Console.WriteLine("Temp: scrie cu '.' de ex. 10.5");
                string input = Console.ReadLine();
                float temperatura = float.Parse(input, CultureInfo.InvariantCulture);
                temperaturi[i] = temperatura;
            }
            Console.WriteLine("\n");
            //foreach (int i in temperaturi)
            //{
            //    Console.WriteLine(i);
            //}
            Console.WriteLine(exercitiul7.tempMedie(temperaturi));
            Console.ReadKey();

        }

    }
}
