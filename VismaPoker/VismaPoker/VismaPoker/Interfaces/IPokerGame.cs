﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VismaPoker.VismaPoker.Interfaces
{
    public interface IPokerGame
    {
        void GenerateHand();
        Card GenerateCard();
        void ReplaceCard(int cardNumber);
        void PrintHand();
        void EvaluateHand();
        void ClearHand();
    }
}
