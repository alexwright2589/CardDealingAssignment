using System;

namespace Card_dealing
{
    public class Program
    {
        static void Main(string[] args)
        {
            // goes over to the deck class creating an array as deck1
            Deck deck1 = new Deck();
            // once the array is created goes over to the shuffle method in the deck class and shuffles our array
            deck1.Shuffle();
            // while loop to determine whether or not the user would like a card delt
            int count;
            count = 52;
            while (true)
            {
                Console.WriteLine("Would you like a card to be dealt? \n Enter 1 for yes 2 for no");
                string Answer = Console.ReadLine();

                if (deck1.isEmpty())
                {
                    Console.WriteLine("No more cards left in the deck");
                    break;
                }
                if (Answer == "1")
                {
                    // deals a card and minuses one from the deck count and outputs the card and amount of cards left
                    count--;
                    Console.Write($"{deck1.DealCard()}\n");
                    Console.WriteLine(count + " cards left in the deck");
                }
                // ends program if user does not want anymore cards
                if (Answer == "2")
                {
                    Console.WriteLine("No more cards will be dealt");
                    break;
                }



             
            }
        }
    }
}
    

