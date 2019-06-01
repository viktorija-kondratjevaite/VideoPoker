using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VismaPoker.VismaPoker
{
    public class Card
    {
        public Rank rank { get; set; }
        public Suit suit { get; set; }

        public Card(Rank rank, Suit suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

    }
}
