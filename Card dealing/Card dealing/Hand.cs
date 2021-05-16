using System;
using System.Collections.Generic;
namespace Card_dealing
{
    public class Hand
    {
        public List<Card> newHand { get; private set; }
        public List<Card> newHand2 { get; private set; }

        public Hand(Deck deck1)
        {
            HAND(deck1);
            CARD(deck1);
        }
        private void HAND(Deck deck1)
        {
            newHand = new List<Card>();
            for (int i = 0; i < 10; i++)
            {
                newHand.Add(deck1.DealCard());
            }
        }
        private void CARD(Deck deck1)
        {
            newHand2 = new List<Card>();
            for (int i = 0; i < 3; i++)
            {
                newHand2.Add(deck1.DealCard());
            }
        }
    }
}