using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VismaPoker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Visma Poker Hand Evaluator\nOption list:");
            while (true)
            {
                Console.WriteLine(
                    "1. Generate a hand\n2. Discard and replace a card.\n3. Evaluate a hand and get a prize.");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Hand Generated");
                        break;
                    case "2":
                        Console.WriteLine("Which card do you want to replace? (0-4)");
                        var cardNumber = Console.ReadLine();
                        Console.WriteLine("Card number " + cardNumber + " was replaced");
                        Console.WriteLine("Do you want to replace another card? (Y/N)");
                        break;
                    case "3":
                        Console.WriteLine("Hand evaluated");
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
