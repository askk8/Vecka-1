using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop19
{
    class Uppgift5
    {
        public static void uppgift5()
        {
            var random = new Random();
            var number = random.Next(1, 100);

            int gissatNummer;

            do
            {
                Console.WriteLine("Gissa på ett tal mellan 0 till 100: ");
                gissatNummer = int.Parse(Console.ReadLine());

                if (gissatNummer < number)
                {
                    Console.WriteLine("För lågt, gissa på ett högre nummer...");
                }
                if (gissatNummer > number)
                {
                    Console.WriteLine("För högt, gissa på ett lägre nummer...");
                }
            } while (gissatNummer != number);

            Console.WriteLine($"Du gissade på {gissatNummer} och det var rätt, grattis!");
            Console.Read();
        }
    }
}
