using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop19
{
    class Uppgift1
    {
        public static void uppgift1()
        {
            int x = ReadInt("Type a number: ");
            int y = ReadInt("Type another number: ");

            Console.WriteLine();
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        static int ReadInt(string hej)
        {

            Console.WriteLine(hej);
            var input = Console.ReadLine();
            while (true)
            {
                try
                {
                    var returnValue = Int32.Parse(input);
                    return returnValue;
                }
                catch
                {
                    Console.WriteLine("Not an int, try again!: ");
                    input = Console.ReadLine();
                }
            }
        }
    }
}
