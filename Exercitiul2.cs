using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborator_1
{
    internal class Exercitiul2
    {
        public string isLeapYear()
        {
            Console.WriteLine("Anul: ");
            int anul = int.Parse(Console.ReadLine());
            if ((anul % 4 == 0 && anul % 100 != 0) || (anul % 400 == 0))
            {
                return "An bisect";
            }
            return "Nu este bisect";

        }
    }
}
