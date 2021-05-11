using System;
namespace Card_dealing
{
    public class Human : Player
    {
        public override void AbstractMethod()
        {
            _score++;
        }

        public override int ID
        {
            get
            {
                return _ID + 1;
            }
        }
        public override int Score
        {
            get
            {
                return _score;
            }
        }
        public static void increasehuman()
        {
            var round = new Human();
            round.AbstractMethod();
            Console.WriteLine($"Well done you won that round, ID = {round.ID}, Score = {round.Score}");
        }
    }
}
