using System;

namespace ChronoMath
{
    internal class MoinsNeuf : GenericOperation
    {
        private Random rand;

        public MoinsNeuf(Random rand)
        {
            this.rand = rand;
            operation = "-";
            right = "9";
            int tleft = rand.Next(82, 1000);
            _answer = tleft - 9;
            Left = tleft.ToString();
        }
    }
}