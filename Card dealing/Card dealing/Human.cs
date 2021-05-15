using System;
namespace Card_dealing
{
    public class Human : Player
    {
        internal static object player1;

        public override void AbstractMethod()
        {
            _ID++;
        }

        public override int ID
        {
            get
            {
                return _ID;
            }
        }


        public static void humanID()
        {
            var round = new Human();
            round.AbstractMethod();
            Console.WriteLine($"Humans ID = {round.ID}");
        }
    }
}
