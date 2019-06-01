using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VismaPoker.VismaPoker;
using VismaPoker.VismaPoker.Interfaces;

namespace VismaPoker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Visma Poker Hand Evaluator\nOption list:");
            IPokerGame pokerGame = new PokerGame();
            while (true)
            {
                Console.WriteLine(
                    "1. Generate a hand\n2. Discard and replace a card.\n3. Evaluate a hand and get a prize.");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        pokerGame.GenerateHand();
                        Console.WriteLine("Hand Generated");
                        pokerGame.PrintHand();
                        break;
                    case "2":
                        Console.WriteLine("Which card do you want to replace? (0-4)");
                        var cardNumber = Console.ReadLine();
                        pokerGame.ReplaceCard(int.Parse(cardNumber));
                        Console.WriteLine("Card number " + cardNumber + " was replaced");
                        pokerGame.PrintHand();
                        Console.WriteLine("Do you want to replace another card? (Y/N)");
                        break;
                    case "3":
                        pokerGame.EvaluateHand();
                        pokerGame.ClearHand();
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
