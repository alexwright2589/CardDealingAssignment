using System;
using System.Collections.Generic;
namespace Card_dealing
{
    public class Hand
    {
        public static void hand(Card card, int PlayerorComputer)
        {
            if (PlayerorComputer == 1)
            {
                List<Card> newHand1 = new List<Card>();
                newHand1.Add(card);
                foreach (var i in newHand1)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                List<Card> newHand2 = new List<Card>();
                newHand2.Add(card);
            }
        }

    }
}
