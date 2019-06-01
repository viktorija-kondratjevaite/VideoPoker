using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VismaPoker.VismaPoker.Interfaces;

namespace VismaPoker.VismaPoker
{
    public class PokerGame : IPokerGame
    {
        
            private readonly List<Card> _hand = new List<Card>();
            private readonly Array _ranks = Enum.GetValues(typeof(Rank));
            private readonly Array _suits = Enum.GetValues(typeof(Suit));
            private readonly Random _random = new Random();
            private readonly IPokerHandEvaluator _evaluator = new PokerHandEvaluator();


            public void GenerateHand()
            {
                for (var j = 0; j < 5; j++)
                {
                    _hand.Add(GenerateCard());
                }
            }

            public Card GenerateCard()
            {
                return new Card((Rank)_ranks.GetValue(_random.Next(_ranks.Length)),
                    (Suit)_suits.GetValue(_random.Next(_suits.Length)));
            
            }

            public void ReplaceCard(int cardNumber)
            {
                if (_hand.Count == 0)
                {
                    Console.WriteLine("The hand is empty.\n");
                    return;
                }

                var newCard = GenerateCard();
                _hand[cardNumber] = newCard;
            }


            public void PrintHand()
            {
                Console.WriteLine("Your hand:");
                foreach (var card in _hand)
                {
                    Console.WriteLine(card.rank + " OF " + card.suit );
                }
            }

            public void EvaluateHand()
            {
                var handEvaluation = _evaluator.EvaluateHand(_hand);
                Console.WriteLine("Your hand is " + handEvaluation + " and your prize is - " + (int)handEvaluation + "\n");
            }

            public void ClearHand()
                {
                    _hand.Clear();
                }

            }
    
}
