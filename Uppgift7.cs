using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop19
{
    class Uppgift7
    {
        public static void uppgift7()
        {
            var random = new Random();

            bool inteSant = false;

            string hej = "";
            while (inteSant != true)
            {
                var color = random.Next(8, 15);
                Console.BackgroundColor = (ConsoleColor)color;
                Console.WriteLine(hej.PadLeft(Console.WindowWidth));
            }
            Console.ReadLine();
        }
    }
}
