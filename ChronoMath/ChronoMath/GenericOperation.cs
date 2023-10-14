using System;

namespace ChronoMath
{
    public abstract class GenericOperation : IOperation
    {

        protected int _answer;
        public string Left { get; protected set; }

        public string right { get; protected set; }

        public string operation { get; protected set; }

        public bool Evaluate(string response)
        {
            try
            {
                return int.Parse(response) == _answer;
            }
            catch (Exception ex)
            {

            }
            return false;
        }
    }
}
