using System;

namespace ChronoMath
{
    internal class DoubleOp : GenericOperation
    {
        private Random rand;

        public DoubleOp(Random rand)
        {
            this.rand = rand;
            operation = "double";
            right = "";
            int tleft = rand.Next(20, 1000);
            _answer = tleft * 2;

            Left = tleft.ToString();
        }
    }
}