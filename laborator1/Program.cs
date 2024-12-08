using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
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

            // Radacina patrata
            //Exercitiul6 exercitiul6 = new Exercitiul6();
            //Console.WriteLine(exercitiul6.radacinaPatrata(3));


            // Temp medie + max/min temperaturi 
            //int zile;
            //float[] temperaturi;
            //Exercitiul7 exercitiul7 = new Exercitiul7();
            //Console.WriteLine("Nr. zile: ");
            //zile = Convert.ToInt16(Console.ReadLine());
            //temperaturi = new float[zile];
            //for (int i = 0; i < zile; i++) {
            //    Console.WriteLine("Temp: scrie cu '.' de ex. 10.5");
            //    string input = Console.ReadLine();
            //    float temperatura = float.Parse(input, CultureInfo.InvariantCulture);
            //    temperaturi[i] = temperatura;
            //}
            //Console.WriteLine("\n");
            ////Console.WriteLine("Temperatura medie este: {0}", exercitiul7.tempMedie(temperaturi));
            //string mintemp = exercitiul7.TempMinMax("minim", temperaturi); //maxim sau minim
            //Console.WriteLine(mintemp);
            //Console.WriteLine("\n");
            //string maxtemp = exercitiul7.TempMinMax("maxim", temperaturi);
            //Console.WriteLine(maxtemp);


            // Matrice bidimensional
            int randuri, coloane;
            Console.WriteLine("Numarul de randuri: ");
            randuri = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Numar de coloane: ");
            coloane = Convert.ToInt16(Console.ReadLine());
            Exercitiul8 exercitiul8 = new Exercitiul8();
            int[,] matrice = exercitiul8.matricea(randuri, coloane);

            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    Console.WriteLine("{0} * {1} = {1}", i, j, matrice[i, j]);
                }
            }


            Console.ReadKey();



        }

    }
}
