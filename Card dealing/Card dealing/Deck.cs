using System;
using System.Collections.Generic;
using System.Text;

namespace Card_dealing
{
    public class Deck
    {
        // sets card as an array
        // creates the variables for currentcard and num_cards and rannum
        private Card[] deck;
        private int currentCard;
        private const int num_cards = 52;
        private Random ranNum;
        public int PlayerorComputer;

        // where the deck is populated with each face matching a suit
        public Deck()
        {
            string[] suits = { "Hearts", "Clubs", "Spades", "Diamonds" };
            int[] faces = { 2, 3, 4, 5, 6, 7, 8, 9 ,10, 11, 12, 13, 14};
            deck = new Card[num_cards];
            currentCard = 0;
            ranNum = new Random();
            for (int count = 0; count < deck.Length; count++) 
                deck[count] = new Card(faces[count % 11], suits[count / 13]);
        }
        // where the shuffle is done by placing the first card in a random spot and so on
        public void Shuffle()
        {
            currentCard = 0;
            for (int first = 0; first < deck.Length; first++)
            {
                int second = ranNum.Next(num_cards);
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }
        // method to check if the deck has ran out of cards
        public bool isEmpty()
        {
            if (currentCard == 52)
                return true;
            else
                return false;
        }
            
            
        

        // used to deal a card when the user asks for one by keeping track of the current card and returning the card at this index
        public Card DealCard()
        {
            PlayerorComputer++;
            if (currentCard < 53)
            {
                for (int i = 0; i < 10; i++)
                    Hand.hand(deck[currentCard++], PlayerorComputer);
            }
            else
            {
                Console.WriteLine("The deck is empty all cards have been delt");
                return null;
            }
            return null;
        }
    }
}

