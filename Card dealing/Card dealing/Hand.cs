using System;
using System.Collections.Generic;
namespace Card_dealing
{
    public class Hand
    {
        public List<Card> newHand { get; private set; }

        public Hand(Deck deck1)
        {
            hand(deck1);
        }
        private void hand(Deck deck1)
        {
            newHand = new List<Card>();
            for (int i = 0; i < 10; i++)
                newHand.Add(deck1.DealCard());
            Console.WriteLine(" ");
            foreach (var i in newHand)
            {
                Console.WriteLine(i);
            }
        }
    }
}