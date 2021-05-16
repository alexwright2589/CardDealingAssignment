using System;
using System.Collections.Generic;

namespace Card_dealing
{
    public class Program
    {
        public static Hand PlayersHand { get; private set; }
        public static Hand ComputersHand { get; private set; }
        public static Hand PlayersCards { get; private set; }
        public static Hand ComputersCards { get; private set; }
        public static int Counter;
        public static int count;
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
                Console.WriteLine("Would you like the cards to be dealt to you and the computer? \n Enter 1 for yes 2 for no");
                string Answer = Console.ReadLine();

                if (deck1.isEmpty())
                {
                    Console.WriteLine("No more cards left in the deck");
                    break;
                }
                if (Answer == "1")
                {
                    // deals a card and minuses one from the deck count and outputs the card and amount of cards left
                    for (int i = 0; i < 20; i++)
                        count--;
                    player(deck1);
                    computer(deck1);
                    _player(deck1);
                    _computer(deck1);
                    Play(deck1);
                    Console.WriteLine("The computers cards have been dealt");
                    Console.WriteLine(count + " cards left in the deck");
                    break;
                }
                // ends program if user does not want anymore cards
                if (Answer == "2")
                {
                    Console.WriteLine("No more cards will be dealt");
                    break;
                }
                else
                {
                    Console.WriteLine("This is not a valid input");
                    continue;
                }
            }
        }
        public static void player(Deck deck1)
        {
            PlayersHand = new Hand(deck1);
        }
        public static void computer(Deck deck1)
        {
            ComputersHand = new Hand(deck1);
        }
        public static void _player(Deck deck1)
        {
            PlayersCards = new Hand(deck1);
        }
        public static void _computer(Deck deck1)
        {
            ComputersCards = new Hand(deck1);
        }
        public static Card Play(Deck deck1)
        {
            Human player1 = new Human();
            Computer computer1 = new Computer();
            for (int i = 0; i < 5; i++)
            {
                while (true)
                {
                    Console.WriteLine("Would you like to play a round type 1 for yes 2 for no.");
                    string answer = Console.ReadLine();
                    if (answer == "1")
                    {
                        Console.WriteLine($"\nYour cards are: {PlayersHand.newHand[(i*2)]} {PlayersHand.newHand[(i*2)+1]}");
                        Console.WriteLine($"The computers cards are: {ComputersHand.newHand[i * 2]} {ComputersHand.newHand[(i * 2) + 1]}");
                        if (((PlayersHand.newHand[(i * 2)]).face + (PlayersHand.newHand[(i * 2) + 1]).face) > ((ComputersHand.newHand[i * 2]).face + (ComputersHand.newHand[(i * 2) + 1]).face))
                        {
                            Console.WriteLine("\nWell done looks like you won that round!! ");
                            Human.humanID();
                            player1.increasescore(Counter);
                            Console.WriteLine($"Players score is: {player1.score}");

                        }
                        if (((PlayersHand.newHand[(i * 2)]).face + (PlayersHand.newHand[(i * 2) + 1]).face) < ((ComputersHand.newHand[i * 2]).face + (ComputersHand.newHand[(i * 2) + 1]).face))
                        {
                            Console.WriteLine("\nUnlucky looks like the computer won that round ");
                            Computer.computerID();
                            computer1.increasescore(Counter);
                            Console.WriteLine($"Computers score is: {computer1.score}");
                        }
                        if (((PlayersHand.newHand[(i * 2)]).face + (PlayersHand.newHand[(i * 2) + 1]).face) == ((ComputersHand.newHand[i * 2]).face + (ComputersHand.newHand[(i * 2) + 1]).face))
                        {
                            if (i == 4)
                            {
                                Console.WriteLine($"\nLooks like it was a draw whoever wins the next round gets all the points!!!");
                                count++;
                            }
                            else
                            {
                                Counter++;
                                Console.WriteLine($"\nLooks like it was a draw whoever wins the next round gets all the points!!!");
                                Human.humanID();
                                Computer.computerID();
                            }
                        }
                        break;
                    }
                    if (answer == "2")
                    {
                        Console.WriteLine("Thanks and goodbye");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not valid input");
                        continue;
                    }
                }
            }

            Console.WriteLine($"\n\nThe final scores are: \n {computer1.score} points to the computer \n {player1.score} points to the player ");

            if ((computer1.score == player1.score) && (count == 1))
            {
                Console.WriteLine($"Looks like its a draw you both got {player1.score} points, Would you like to deal another card each from the remaining deck? 1 for yes 2 for no.");
                string ans = Console.ReadLine();
                if (ans == "1")
                {
                    while (true)
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            if ((PlayersCards.newHand2[i].face) > (ComputersCards.newHand2[i].face))
                            {
                                Console.WriteLine($"Well done you have won the game!");
                                break;
                            }
                            if ((PlayersCards.newHand2[i].face) < (ComputersCards.newHand2[i].face))
                            {
                                computer1.increasescore(Counter);
                                Console.WriteLine($"Oh no looks like the computer won :(");
                                break;
                            }
                            if ((PlayersCards.newHand2[i].face) == (ComputersCards.newHand2[i].face))
                            {
                                Console.WriteLine("A draw again!! Another card will be drawn.");
                                continue;
                            }
                        }
                    }
                }
            }
            return null;
        }
        
    }
}
    

