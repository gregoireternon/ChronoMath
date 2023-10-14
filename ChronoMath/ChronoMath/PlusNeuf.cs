using System;

namespace ChronoMath
{
    public class PlusNeuf : GenericOperation
    {
        private Random rand;
        public PlusNeuf(Random rand)
        {
            this.rand = rand;
            operation = "+";
            right = "9";
            int tleft = rand.Next(82, 1000);
            _answer = tleft+9;
            Left = tleft.ToString();
        }


        
    }
}