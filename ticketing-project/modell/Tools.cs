using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticketing_project.DataBase
{
    internal class Tools
    {


        public string prelucrareSerieTicket(string serieTicketBrut)
        {
            string newSerie = "";
            for (int i = 0; i < serieTicketBrut.Length; i++)
            {
                if (i == 3 || i == 6)
                {
                    newSerie = newSerie + "-";
                }
                newSerie = newSerie + serieTicketBrut[i];
            }
            return newSerie;
        }

        public string GenerareTicket()
        {
            const string TEXTS = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string final = "";

            Random randomStart = new Random();
            int num = randomStart.Next(0, 2);

            if (num == 0)
            {
                while (true)
                {
                    num = randomStart.Next(1, 10);
                    final = final + num.ToString();
                    if (final.Length == 11) { break; }
                    else if (final.Length == 3)
                    {
                        final = final + "-";
                    }
                    num = randomStart.Next(TEXTS.Length - 1);
                    char caracter = TEXTS[num];
                    final = final + caracter;
                    if (final.Length == 7)
                    {
                        final = final + "-";
                    }
                }

            }
            else
            {
                while (true)
                {
                    num = randomStart.Next(TEXTS.Length - 1);
                    char caracter = TEXTS[num];
                    final = final + caracter;
                    if (final.Length == 11) { break; }
                    else if (final.Length == 3)
                    {
                        final = final + "-";
                    }
                    num = randomStart.Next(1, 10);
                    final = final + num.ToString();
                    if (final.Length == 7)
                    {
                        final = final + "-";
                    }
                }
            }
            return final;
        }

    }
}
