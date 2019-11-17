using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop19
{
    class Uppgift4
    {
        public static void uppgift4()
        {
            for (int i = 1; i <= 100; i++)
            {
                string answer = "";
                if (i % 3 == 0)
                {
                    answer = "Fizz";
                }

                if (i % 5 == 0)
                {
                    answer = answer + "Buzz";
                }

                if (answer.Length < 1)
                {
                    answer = i.ToString();
                }

                Console.WriteLine(answer);
                Console.Read();
            }
        }

    }
}
