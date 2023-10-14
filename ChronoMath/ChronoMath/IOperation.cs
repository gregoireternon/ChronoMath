namespace ChronoMath
{
    public interface IOperation
    {
        string Left { get; }

        string right { get; }

        string operation { get; }

        bool Evaluate(string response);
    }
}
