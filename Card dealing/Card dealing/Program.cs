using System;
using System.Collections.Generic;

namespace Card_dealing
{
    public class Program
    {
        //creates all the relevant fields/variables needed in the game
        public static Hand PlayersHand { get; private set; }
        public static Hand ComputersHand { get; private set; }
        public static Hand PlayersCards { get; private set; }
        public static Hand ComputersCards { get; private set; }
        public static int Counter;
        public static int count;
        static void Main(string[] args)
        {
            //makes the human and computer objects
            Human player1 = new Human();
            Computer computer1 = new Computer();
            // goes over to the deck class creating an array as deck1
            Deck deck1 = new Deck();
            // once the array is created goes over to the shuffle method in the deck class and shuffles our array
            deck1.Shuffle();
            // while loop to determine whether or not the user would like a card delt
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
                    // deals the cards
                    Console.WriteLine("The cards have been dealt");
                    player(deck1);
                    computer(deck1);
                    _player(deck1);
                    _computer(deck1);
                    //calls the play method
                    Play(deck1, player1, computer1);
                    break;
                }
                // ends program if user does not want anymore cards
                if (Answer == "2")
                {
                    Console.WriteLine("No more cards will be dealt");
                    break;
                }
                else
                //just some exception handling
                {
                    Console.WriteLine("This is not a valid input");
                    continue;
                }
            }
        }
        //creates the hands needed to play the game by calling hand class
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
        //play method for playing the game
        public static Card Play(Deck deck1, Human player1, Computer computer1)
        {
            //for loop so it loops five times as there are five rounds
            for (int i = 0; i < 5; i++)
            {
                // while loop to make sure the user is entering a correct input
                while (true)
                {
                    Console.WriteLine("Would you like to play a round \ntype 1 for yes 2 for no.");
                    string answer = Console.ReadLine();
                    if (answer == "1")
                    {
                        //outputs each players cards and checks the totals to see wether it needs to increase score for which one or if it was a draw
                        Console.WriteLine($"\nYour cards are: {PlayersHand.newHand[(i * 2)]} {PlayersHand.newHand[(i * 2) + 1]}");
                        Console.WriteLine($"The computers cards are: {ComputersHand.newHand[i * 2]} {ComputersHand.newHand[(i * 2) + 1]}");
                        if (((PlayersHand.newHand[(i * 2)]).face + (PlayersHand.newHand[(i * 2) + 1]).face) > ((ComputersHand.newHand[i * 2]).face + (ComputersHand.newHand[(i * 2) + 1]).face))
                        {
                            Console.WriteLine("\nWell done looks like you won that round!! ");
                            Human.humanID();
                            player1.increasescore(Counter);
                            Console.WriteLine($"Players score is: {player1.score}");
                            if (Counter > 0)
                            {
                                Counter = 0;
                            }

                        }
                        if (((PlayersHand.newHand[(i * 2)]).face + (PlayersHand.newHand[(i * 2) + 1]).face) < ((ComputersHand.newHand[i * 2]).face + (ComputersHand.newHand[(i * 2) + 1]).face))
                        {
                            Console.WriteLine("\nUnlucky looks like the computer won that round ");
                            Computer.computerID();
                            computer1.increasescore(Counter);
                            Console.WriteLine($"Computers score is: {computer1.score}");
                            if (Counter > 0)
                            {
                                Counter = 0;
                            }
                        }
                        //if its a draw it checks to see if the next round would make a difference to who wins if not outputs this if so increases a count so that the correct points can be awarded
                        if (((PlayersHand.newHand[(i * 2)]).face + (PlayersHand.newHand[(i * 2) + 1]).face) == ((ComputersHand.newHand[i * 2]).face + (ComputersHand.newHand[(i * 2) + 1]).face))
                        {
                            if (i == 4)
                            {
                                Draw(deck1, player1, computer1);
                            }
                            else
                            {
                                //outputs the id and points for each
                                Counter++;
                                Console.WriteLine($"\nLooks like it was a draw whoever wins the next round gets all the points!!!");
                                Human.humanID();
                                Console.WriteLine($"Player score is: {player1.score}");
                                Computer.computerID();
                                Console.WriteLine($"Computers score is: {computer1.score} ");
                            }
                        }
                        //breaks out the while loop when everything is finished for that round
                        break;
                    }
                    if (answer == "2")
                    {
                        Console.WriteLine("Thanks and goodbye");
                        i = 4;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not valid input");
                        continue;
                    }
                }
            }
            // outputs the winner if the game is finished and not a draw
            Console.WriteLine($"\n\nThe final scores are: \n {computer1.score} points to the computer \n {player1.score} points to the player ");
            if (computer1.score > player1.score)
            {
                Console.WriteLine("\nThe computer has won the game :(");
            }
            if (computer1.score < player1.score)
            {
                Console.WriteLine("\nYou have won the game!!");
            }
            return null;
        }
        public static Card Draw(Deck deck1, Human player1, Computer computer1)
        {
            // if the game is a draw will output another card for each player and whichever is biggest wins the game
            while (true)
            {
                Console.WriteLine($"Looks like its a draw the points as stand are:\n{player1.score} points to you\n{computer1.score} to the computer \nWould you like to deal another card each from the remaining deck? 1 for yes 2 for no.");
                string ans = Console.ReadLine();
                if (ans == "1")
                {
                    //only loops if its a draw again
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"\nYour card is: {PlayersHand.newHand2[i]}");
                        Console.WriteLine($"The computers card is: {ComputersHand.newHand2[i]}");
                        if ((PlayersCards.newHand2[i].face) < (ComputersCards.newHand2[i].face))
                        {
                            player1.increasescore(Counter);
                            // sets i to 2 so it doesnt loop if won
                            i = 2;
                            
                        }
                        if ((PlayersCards.newHand2[i].face) > (ComputersCards.newHand2[i].face))
                        {
                            computer1.increasescore(Counter);
                            i = 2;
                            
                        }
                        if ((PlayersCards.newHand2[i].face) == (ComputersCards.newHand2[i].face))
                        {
                            Console.WriteLine("A draw again!! Another card will be drawn.");
                            
                        }
                    }
                    break;
                }
                if (ans == "2")
                {
                    Console.WriteLine("Thanks and goodbye");
                    break;
                }
                // exception handling
                else
                {
                    Console.WriteLine("Not valid input");
                }
            }
            return null;
        }
        
    }
}
    

