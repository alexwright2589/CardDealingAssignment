using System;
using System.Collections.Generic;
using System.Text;

namespace Card_dealing
{
    public class Card
    {
        // creates the variables suit and face and sets them as a string value
        public string suit;
        public int face;

        //makes these variables = the string the method requires to take in
        public Card(int cardFace, string cardSuit)
        {
            suit = cardSuit;
            face = cardFace;
        }
        // creates the layout to output the cards
        public override string ToString()
        {
            if (face == 14)
                return "Ace" + " of " + suit;
            if (face == 11)
                return "Jack" + " of " + suit;
            if (face == 12)
                return "Queen" + " of " + suit;
            if (face == 13)
                return "King" + " of " + suit;
            else
                return face + " of " + suit;

        }
    }
}
