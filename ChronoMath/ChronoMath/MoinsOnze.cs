using System;

namespace ChronoMath
{
    internal class MoinsOnze : GenericOperation
    {
        private Random rand;

        public MoinsOnze(Random rand)
        {
            this.rand = rand;
            operation = "-";
            right = "11";
            int tleft = rand.Next(82, 1000000);
            _answer = tleft - 11;
            Left = tleft.ToString();
        }
    }
}