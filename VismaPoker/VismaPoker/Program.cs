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
            PokerMenu pokerMenu = new PokerMenu();
            pokerMenu.StartPokerGame();

        }
    }
}
