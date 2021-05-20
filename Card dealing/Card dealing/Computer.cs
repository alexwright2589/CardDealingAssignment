using System;
namespace Card_dealing
{
    // inherits the score and ID
    public class Computer : Player
    {
        //abstract method using polymorphism to increase the ID number for the computer so its correct
        public override void IncreaseID()
        {
            _ID++;
        }
        //ovverides the ID function and sets it to 2
        public override int ID
        {
            get
            {
                return _ID + 1;
            }
        }
        // outputs the relevant ID number
        public static void computerID()
        {
            var round = new Computer();
            round.IncreaseID();
            Console.WriteLine($"Computers ID = {round.ID}");
        }
    }
}
