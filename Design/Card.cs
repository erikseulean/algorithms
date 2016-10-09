using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design
{
    public enum CardType
    {
        Hearts = 1,
        Spades = 2,
        Diamonds = 3,
        Clubs = 4
    }
    public class Card
    {
        protected int value;
        public virtual int Value { get { return value; } }
        public CardType CardType { get; set; }

        public Card(int value, CardType type)
        {
            this.value = value;
            this.CardType = type;
        }
    }

    public class BlackJackCard : Card
    {
        public BlackJackCard(int value, CardType type) : base(value,type)
        {

        }
        public override int Value
        {
            get
            {
                if (this.value == 1) return 11;
                else if (this.value < 10) return this.value;
                else return 10;
            }
        }
    } 
}
