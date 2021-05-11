using System;
namespace Card_dealing
{
    public class Computer : Player
    {
        public override void AbstractMethod()
        {
            _score++;
        }

        public override int ID
        {
            get
            {
                return _ID + 2;
            }
        }
        public override int Score
        {
            get
            {
                return _score;
            }
        }
        public static void increasecomputer()
        {
            var round = new Computer();
            round.AbstractMethod();
            Console.WriteLine($"Unlucky the computer won that round, ID = {round.ID}, Score = {round.Score}");
        }
    }
}
