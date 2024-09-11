using System;
using System.Collections.Generic;

namespace ProgramCS
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 100;
            string odgovor;

            while (min <= max)
            {
                int srednjaVrednost = (min + max) / 2;
                Console.WriteLine($"Da li je manje ili jednako sa {srednjaVrednost}? (Odgovorite sa 'da' ili 'ne')");
                odgovor = Console.ReadLine().ToLower();

                if (odgovor == "da")
                {
                    max = srednjaVrednost;
                }
                else if (odgovor == "ne")
                {
                    min = srednjaVrednost + 1;
                }
                
                else if (odgovor == "pogodio si")
                {
                    min = max;
                    Console.WriteLine($"Broj koji ste zamislili je {min - 1}");
                    return;
                }
                else
                {
                    Console.WriteLine("Pogresan unos, pokusajte ponovo.");
                }
            }

        }
    }
}