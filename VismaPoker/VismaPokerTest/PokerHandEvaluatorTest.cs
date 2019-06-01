using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VismaPoker.VismaPoker;

namespace VismaPokerTest
{
    [TestClass]
    public class PokerHandEvaluatorTest
    {
        protected readonly PokerHandEvaluator _pokerHandEvaluator = new PokerHandEvaluator();

        [TestMethod]
        public void JacksOrBetterEvaluationTest()
        {
            List<Card> hand = new List<Card>
            {
                new Card(Rank.JACK, Suit.DIAMONDS),
                new Card(Rank.JACK, Suit.CLUBS),
                new Card(Rank.TEN, Suit.CLUBS),
                new Card(Rank.QUEEN, Suit.CLUBS),
                new Card(Rank.KING, Suit.CLUBS),
            };

            var jacksOrBetter = _pokerHandEvaluator.EvaluateHand(hand);
            Assert.AreEqual(Hand.JACKS_OR_BETTER, jacksOrBetter);
        }
        [TestMethod]
        public void TwoPairEvaluationTest()
        {
            List<Card> hand = new List<Card>
            {
                new Card(Rank.THREE, Suit.SPADES),
                new Card(Rank.JACK, Suit.SPADES),
                new Card(Rank.JACK, Suit.HEARTS),
                new Card(Rank.THREE, Suit.CLUBS),
                new Card(Rank.TWO, Suit.HEARTS),
            };

            var twoPair = _pokerHandEvaluator.EvaluateHand(hand);
            Assert.AreEqual(Hand.TWO_PAIR, twoPair);
        }
        [TestMethod]
        public void ThreeOfAKindEvaluationTest()
        {
            List<Card> hand = new List<Card>
            {
                new Card(Rank.QUEEN, Suit.CLUBS),
                new Card(Rank.QUEEN, Suit.SPADES),
                new Card(Rank.QUEEN, Suit.HEARTS),
                new Card(Rank.NINE, Suit.HEARTS),
                new Card(Rank.TWO, Suit.SPADES),
            };

            var threeOfAKind = _pokerHandEvaluator.EvaluateHand(hand);
            Assert.AreEqual(Hand.THREE_OF_A_KIND, threeOfAKind);
        }
        [TestMethod]
        public void StraightEvaluationTest()
        {
            List<Card> hand = new List<Card>
            {
                new Card(Rank.TEN, Suit.DIAMONDS),
                new Card(Rank.NINE, Suit.SPADES),
                new Card(Rank.EIGHT, Suit.HEARTS),
                new Card(Rank.SEVEN, Suit.DIAMONDS),
                new Card(Rank.SIX, Suit.CLUBS),
            };

            var straight = _pokerHandEvaluator.EvaluateHand(hand);
            Assert.AreEqual(Hand.STRAIGHT, straight);
        }
        [TestMethod]
        public void FlushEvaluationTest()
        {
            List<Card> hand = new List<Card>
            {
                new Card(Rank.JACK, Suit.DIAMONDS),
                new Card(Rank.NINE, Suit.DIAMONDS),
                new Card(Rank.EIGHT, Suit.DIAMONDS),
                new Card(Rank.FOUR, Suit.DIAMONDS),
                new Card(Rank.THREE, Suit.DIAMONDS),
            };

            var flush = _pokerHandEvaluator.EvaluateHand(hand);
            Assert.AreEqual(Hand.FLUSH, flush);
        }
        [TestMethod]
        public void FullHouseEvaluationTest()
        {
            List<Card> hand = new List<Card>
            {
                new Card(Rank.SIX, Suit.SPADES),
                new Card(Rank.SIX, Suit.HEARTS),
                new Card(Rank.SIX, Suit.DIAMONDS),
                new Card(Rank.KING, Suit.CLUBS),
                new Card(Rank.KING, Suit.HEARTS),
            };

            var fullHouse = _pokerHandEvaluator.EvaluateHand(hand);
            Assert.AreEqual(Hand.FULL_HOUSE, fullHouse);
        }
        [TestMethod]
        public void FourOfAKindEvaluationTest()
        {
            List<Card> hand = new List<Card>
            {
                new Card(Rank.FIVE, Suit.CLUBS),
                new Card(Rank.FIVE, Suit.DIAMONDS),
                new Card(Rank.FIVE, Suit.HEARTS),
                new Card(Rank.FIVE, Suit.SPADES),
                new Card(Rank.TWO, Suit.DIAMONDS),
            };

            var fourOfAKind = _pokerHandEvaluator.EvaluateHand(hand);
            Assert.AreEqual(Hand.FOUR_OF_A_KIND, fourOfAKind);
        }
        [TestMethod]
        public void StraightFlushEvaluationTest()
        {
            List<Card> hand = new List<Card>
            {
                new Card(Rank.JACK, Suit.CLUBS),
                new Card(Rank.TEN, Suit.CLUBS),
                new Card(Rank.NINE, Suit.CLUBS),
                new Card(Rank.EIGHT, Suit.CLUBS),
                new Card(Rank.SEVEN, Suit.CLUBS),
            };

            var straightFlush = _pokerHandEvaluator.EvaluateHand(hand);
            Assert.AreEqual(Hand.STRAIGHT_FLUSH, straightFlush);
        }

        [TestMethod]
        public void RoyalFlushEvaluationTest()
        {
            List<Card> hand = new List<Card>
            {
                new Card(Rank.ACE, Suit.CLUBS),
                new Card(Rank.TEN, Suit.CLUBS),
                new Card(Rank.JACK, Suit.CLUBS),
                new Card(Rank.QUEEN, Suit.CLUBS),
                new Card(Rank.KING, Suit.CLUBS),
            };

            var royalFlush = _pokerHandEvaluator.EvaluateHand(hand);
            Assert.AreEqual(Hand.ROYAL_FLUSH, royalFlush);
        }

    }
}
