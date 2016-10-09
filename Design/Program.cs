using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design
{
    class Program
    {
        static void Main(string[] args)
        {
            Card c = new Card(5, CardType.Clubs);
            BlackJackCard bjcard = new BlackJackCard(1, CardType.Diamonds);
            Console.WriteLine(c.Value + " " + bjcard.Value);
            Console.ReadLine();
        }

        public class CardManager
        {
            private Card c;
            public CardManager(BlackJackCard card)
            {
                c = card;
            }
        }
    }
}
