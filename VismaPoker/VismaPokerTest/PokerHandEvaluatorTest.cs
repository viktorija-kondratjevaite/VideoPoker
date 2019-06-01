using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VismaPoker.VismaPoker;

namespace VismaPokerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RoyalFlushEvaluationTest()
        {
            PokerGame pokerGame = new PokerGame();
            PokerHandEvaluator pokerHandEvaluator = new PokerHandEvaluator();
            List<Card> hand = new List<Card>
            {
                new Card(Rank.ACE, Suit.CLUBS),
                new Card(Rank.TEN, Suit.CLUBS),
                new Card(Rank.JACK, Suit.CLUBS),
                new Card(Rank.QUEEN, Suit.CLUBS),
                new Card(Rank.KING, Suit.CLUBS),
            };

            var royalFlush = pokerHandEvaluator.EvaluateHand(hand);
            Assert.AreEqual(Hand.ROYAL_FLUSH, royalFlush);
        }
    }
}
