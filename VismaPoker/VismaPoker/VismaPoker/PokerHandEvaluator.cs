using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VismaPoker.VismaPoker.Interfaces;

namespace VismaPoker.VismaPoker
{
    public class PokerHandEvaluator : IPokerHandEvaluator
    {
        public Hand EvaluateHand(List<Card> hand)
        {
            var currentHand = Hand.OTHER;

            if (IsJacksOrBetter(hand))
            {
                currentHand = Hand.JACKS_OR_BETTER;
            }

            if (IsTwoPair(hand))
            {
                currentHand = Hand.TWO_PAIR;
            }

            if (IsThreeOfAKind(hand))
            {
                currentHand = Hand.THREE_OF_A_KIND;
            }

            if (IsStraight(hand))
            {
                currentHand = Hand.STRAIGHT;
            }

            if (IsFlush(hand))
            {
                currentHand = Hand.FLUSH;
            }

            if (IsFullHouse(hand))
            {
                currentHand = Hand.FULL_HOUSE;
            }

            if (IsFourOfAKind(hand))
            {
                currentHand = Hand.FOUR_OF_A_KIND;
            }

            if (IsStraightFlush(hand))
            {
                currentHand = Hand.STRAIGHT_FLUSH;
            }

            if (IsRoyalFlush(hand))
            {
                currentHand = Hand.ROYAL_FLUSH;
            }

            return currentHand;
        }

        public bool HasPair(List<Card> hand)
        {
            return hand.GroupBy(card => card.rank)
                .Count(ranks => ranks.Count() == 2) == 1;
        }

        public bool HasThreeOfAKind(List<Card> hand)
        {
            return hand.GroupBy(card => card.rank)
                       .Count(ranks => ranks.Count() == 3) > 0;
        }

        //Jacks Or Better is a hand that has two or more Jacks in it of any suit
        public bool IsJacksOrBetter(List<Card> hand)
        {
            return hand.Count(card => card.rank == Rank.JACK) >= 2;
        }

        //Two pair is a hand that contains two cards of one rank, two cards of another rank and one card of a third rank
        public bool IsTwoPair(List<Card> hand)
        {
            return hand.GroupBy(card => card.rank)
                       .Count(ranks => ranks.Count() >= 2) == 2;
        }

        //Three of a kind is a hand that contains three cards of one rank and two cards of two other ranks, not a pair
        public bool IsThreeOfAKind(List<Card> hand)
        {
            return !HasPair(hand) &&
                        hand.GroupBy(card => card.rank)
                            .Count(ranks => ranks.Count() == 3) > 0;
        }

        //Four of a kind is a hand that contains four cards of one rank and one card of another rank
        public bool IsFourOfAKind(List<Card> hand)
        {
            return hand.GroupBy(card => card.rank)
                .Count(ranks => ranks.Count() == 4) > 0;
        }

        /*
        A straight is a hand that contains five cards of sequential rank, not all of the same suit.
        Difference between highest and lowest card should be 4.
        */
        public bool IsStraight(List<Card> hand)
        {
            return hand.GroupBy(card => card.rank)
                       .Count() == hand.Count()
                   && hand.Max(card => (int)card.rank)
                   - hand.Min(card => (int)card.rank) == 4;
        }

        //A flush is a hand that contains five cards all of the same suit, not all of sequential rank.
        public bool IsFlush(List<Card> hand)
        {
            return hand.GroupBy(card => card.suit).Count() == 1;
        }

        //A full house is a hand that contains three cards of one rank and two cards of another rank.
        public bool IsFullHouse(List<Card> hand)
        {
            return HasThreeOfAKind(hand) && HasPair(hand);
        }

        //A straight flush is a hand that contains five cards of sequential rank, all of the same suit.
        //It's a Flush which is also a Straight, but not RoyalFlush
        public bool IsStraightFlush(List<Card> hand)
        {
            return IsFlush(hand) && IsStraight(hand) && !IsRoyalFlush(hand);
        }

        //Royal Flush is a hand consisting of the cards A, K, Q, J, 10, of the same suit.
        public bool IsRoyalFlush(List<Card> hand)
        {
            var ranks = hand.Select(card => card.rank).ToList();

            return ranks.Contains(Rank.ACE)
                && ranks.Contains(Rank.TEN)
                && ranks.Contains(Rank.JACK)
                && ranks.Contains(Rank.QUEEN)
                && ranks.Contains(Rank.KING)
                && IsFlush(hand);
        }

    }
}
