using System;
namespace Card_dealing
{
    public abstract class Player
    {
        protected int _score = 0;
        protected int _ID = 0;
        public abstract void AbstractMethod();
        public abstract int Score { get; }
        public abstract int ID { get; }


    }
}
