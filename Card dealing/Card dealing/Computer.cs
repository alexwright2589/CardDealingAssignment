using System;
namespace Card_dealing
{
    public class Computer : Player
    {
        public override void AbstractMethod()
        {
            _ID++;
        }

        public override int ID
        {
            get
            {
                return _ID + 1;
            }
        }
        public static void computerID()
        {
            var round = new Computer();
            round.AbstractMethod();
            Console.WriteLine($"Computers ID = {round.ID}");
        }
    }
}
