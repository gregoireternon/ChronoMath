using System;

namespace ChronoMath
{
    internal class FoixDix : GenericOperation
    {
        private Random rand;

        public FoixDix(Random rand)
        {
            this.rand = rand;
            operation = "x";
            right = "10";
            int tleft = rand.Next(20, 1000);
            _answer = tleft * 10;

            Left = tleft.ToString();
        }
    }
}