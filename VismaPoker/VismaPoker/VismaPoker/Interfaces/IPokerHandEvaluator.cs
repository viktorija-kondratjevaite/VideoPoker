using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VismaPoker.VismaPoker.Interfaces
{
    public interface IPokerHandEvaluator
    {
        Hand EvaluateHand(List<Card> hand);
        bool HasPair(List<Card> hand);
        bool HasThreeOfAKind(List<Card> hand);
        bool IsJacksOrBetter(List<Card> hand);
        bool IsTwoPair(List<Card> hand);
        bool IsThreeOfAKind(List<Card> hand);
        bool IsFourOfAKind(List<Card> hand);
        bool IsStraight(List<Card> hand);
        bool IsFlush(List<Card> hand);
        bool IsFullHouse(List<Card> hand);
        bool IsStraightFlush(List<Card> hand);
        bool IsRoyalFlush(List<Card> hand);
    }
}
