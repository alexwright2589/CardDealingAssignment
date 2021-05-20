using System;
namespace Card_dealing
{
    // inherits the score and ID
    public class Human : Player
    {
        //abstract method using polymorphism to increase the ID number for the player so its correct
        public override void IncreaseID()
        {
            _ID++;
        }
        //ovverides the ID function and sets it to 1
        public override int ID
        {
            get
            {
                return _ID;
            }
        }

        // outputs the ID number
        public static void humanID()
        {
            var round = new Human();
            round.IncreaseID();
            Console.WriteLine($"Humans ID = {round.ID}");
        }
    }
}
