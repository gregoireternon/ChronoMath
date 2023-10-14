using System;

namespace ChronoMath
{
    public class Multiplication : GenericOperation
    {
        public Multiplication(Random rand)
        {
            operation = "x";
            int tright = rand.Next(1, 10);
            int tleft = rand.Next(1, 10);
            _answer = tright * tleft;
            
            
            right = tright.ToString();

            Left = tleft.ToString();
        }
    }
}