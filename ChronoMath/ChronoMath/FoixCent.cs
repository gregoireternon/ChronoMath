using System;
using System.Windows.Media.Media3D;

namespace ChronoMath
{
    internal class FoixCent : GenericOperation
    {
        private Random rand;

        public FoixCent(Random rand)
        {
            this.rand = rand;
            operation = "x";
            right = "100";
            int tleft = rand.Next(20, 1000);
            _answer = tleft * 100;

            Left = tleft.ToString();
        }
    }
}