using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VismaPoker.VismaPoker.Interfaces;

namespace VismaPoker.VismaPoker
{
    public class PokerMenu
    {
        
        public void StartPokerGame()
        {
            bool inAction = true;
            Console.WriteLine("Welcome to the Visma Poker Hand Evaluator\nOption list:");
            IPokerGame pokerGame = new PokerGame();
            while (inAction)
            {
                Console.WriteLine(
                    "1. Deal five cards \n2. Discard and replace a card.\n3. Evaluate the hand and get a prize.\n4. Exit the game.\n");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        pokerGame.GenerateHand();
                        Console.WriteLine("Hand Dealt");
                        break;
                    case "2":
                        Console.WriteLine("Which card do you want to replace? (1-5)");
                        var cardNumber = int.Parse(Console.ReadLine())-1;
                        pokerGame.ReplaceCard(cardNumber);
                        Console.WriteLine("Card number " + cardNumber + " was replaced");
                        break;
                    case "3":
                        pokerGame.PrintHand();
                        pokerGame.EvaluateHand();
                        pokerGame.ClearHand();
                        break;
                    case "4":
                        Console.WriteLine("Video Poker shut down.");
                        inAction = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
