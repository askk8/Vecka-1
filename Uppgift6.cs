using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop19
{
    class Uppgift6
    {
        public static void uppgift6()
        {
            var lowInt = 1;
            var highInt = 101;

            var random = new Random();
            var number = random.Next(1, 101);

            int aiNumber;
            int gissatNummer;

            do
            {
                aiNumber = random.Next(lowInt, highInt);

                Console.WriteLine("Gissa på ett tal mellan 0 till 100: ");
                Console.WriteLine("");
                gissatNummer = int.Parse(Console.ReadLine());

                if (gissatNummer < number)
                {
                    Console.WriteLine($"Human Guess: {gissatNummer}");
                    Console.WriteLine($"Too Low...");
                    Console.WriteLine("");
                }
                if (gissatNummer > number)
                {
                    Console.WriteLine($"Human Guess: {gissatNummer}");
                    Console.WriteLine($"Too High...");
                    Console.WriteLine("");
                }
                if (aiNumber < number)
                {
                    Console.WriteLine($"AI Guess: {aiNumber}");
                    Console.WriteLine($"Too Low...");
                    Console.WriteLine("");
                    lowInt = aiNumber + 1;
                }
                if (aiNumber > number)
                {
                    Console.WriteLine($"AI Guess: {aiNumber}");
                    Console.WriteLine($"Too High...");
                    Console.WriteLine("");
                    highInt = aiNumber - 1;
                }
                if (gissatNummer == number)
                {
                    Console.WriteLine($"Human Guess: {gissatNummer}");
                    Console.WriteLine($"{gissatNummer} is correct, human is the winner");
                    break;
                }
                if (aiNumber == number)
                {
                    Console.WriteLine($"AI Guess: {aiNumber}");
                    Console.WriteLine($"{aiNumber} is correct, AI is the winner");
                    break;
                }

            } while (gissatNummer != number || aiNumber != number);

            Console.Read();
        }
    }
}
