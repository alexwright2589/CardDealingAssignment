using System;
namespace Card_dealing
{
    //abstract class for the player which contains score and ID of the players
    public abstract class Player
    {
        public int score { get; set; }
        protected int _ID = 0;
        public abstract void IncreaseID();
        public abstract int ID { get; }
        // used to increase the score when neccessary for the computer and player
        public int increasescore(int x)
        {
            if (x > 0)
            {
                //increases it depending on if there has been a draw then more points are awarded for the next win
                for (int i = 0; i < x; i++)
                    score++;
                    return score++;
            }
            //if not a draw just increases by 1
            else
            {
                return score++;
            }
        }

    }
}
