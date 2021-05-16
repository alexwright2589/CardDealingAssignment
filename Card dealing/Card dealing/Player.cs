using System;
namespace Card_dealing
{
    public abstract class Player
    {
        public int score { get; set; }
        protected int _ID = 0;
        public abstract void AbstractMethod();
        public abstract int ID { get; }

        public int increasescore(int x)
        {
            if (x > 0)
            {
                score++;
                return score++;
            }
            else
            {
                return score++;
            }
        }

    }
}
