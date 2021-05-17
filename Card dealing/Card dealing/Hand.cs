using System;
using System.Collections.Generic;
namespace Card_dealing
{
    public class Hand
    {
        //creates the list fields for the hands
        public List<Card> newHand { get; private set; }
        public List<Card> newHand2 { get; private set; }
        // calls the both functions
        public Hand(Deck deck1)
        {
            HAND(deck1);
            CARD(deck1);
        }
        //populates the lists with 10 cards to play the normal game
        private void HAND(Deck deck1)
        {
            newHand = new List<Card>();
            for (int i = 0; i < 10; i++)
            {
                newHand.Add(deck1.DealCard());
            }
        }
        //populates the lists with 3 cards incase the end is a draw and more cards are needed
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