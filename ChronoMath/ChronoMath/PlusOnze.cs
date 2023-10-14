using System;

namespace ChronoMath
{
    internal class PlusOnze : GenericOperation
    {
        private Random rand;

        public PlusOnze(Random rand)
        {
            this.rand = rand;
            operation = "+";
            right = "11";
            int tleft = rand.Next(82, 1000);
            _answer = tleft + 11;
            Left = tleft.ToString();
        }
    }
}