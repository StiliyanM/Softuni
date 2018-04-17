public abstract class Mission : IMission
{
    public Mission(double enduranceRequired, double scoreToComplete, double wearLevelDecrement)
    {
        EnduranceRequired = enduranceRequired;
        ScoreToComplete = scoreToComplete;
        WearLevelDecrement = wearLevelDecrement;
    }

    public double EnduranceRequired { get; protected set; }

    public double ScoreToComplete { get; protected set; }

    public abstract string Name { get; }

    public double WearLevelDecrement { get; protected set; }
}
