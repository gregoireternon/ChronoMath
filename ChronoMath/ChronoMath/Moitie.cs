using System;
using System.Windows.Media.Media3D;

namespace ChronoMath
{
    public class Moitie : GenericOperation
    {
        private Random rand;

        public Moitie(Random rand)
        {
            this.rand = rand;
            operation = "moitié";
            right = "";
            _answer = rand.Next(20, 1000);
            int tleft = _answer*2;
            
            Left = tleft.ToString();
        }
    }
}