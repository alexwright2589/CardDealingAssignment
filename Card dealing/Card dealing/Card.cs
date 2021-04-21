using System;
using System.Collections.Generic;
using System.Text;

namespace Card_dealing
{
    public class Card
    {
        // creates the variables suit and face and sets them as a string value
        private string suit;
        private string face;

        //makes these variables = the string the method requires to take in
        public Card(string cardFace, string cardSuit)
        {
            suit = cardSuit;
            face = cardFace;
        }
        // creates the layout to output the cards
        public override string ToString()
        {
            return face + " of " + suit;

        }
    }
}
