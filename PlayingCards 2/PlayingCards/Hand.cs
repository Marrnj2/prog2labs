using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCards
{
    class Hand
    {
        private const int SIZE = 5;
        private Card[] cards;
        private Deck deck;
        public Hand(Random random)
        {
            cards = new Card[5];
            deck = new Deck(random);
        }

        internal Card[] Cards { get => cards; set => cards = value; }

        public void DealAHand()
        {
            for (int i = 0; i < SIZE; i++)
            {
                Card newCard = deck.DealACard();
                cards[i] = deck.DealACard();
                for (int j = 0; j < cards.Length; j++)
                {
                    while (newCard == cards[j])
                    {
                        newCard = deck.DealACard();
                    }
                }
                cards[i] = newCard;
            }
        }
    }
}
