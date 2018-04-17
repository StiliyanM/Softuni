public class UltrasoftTyre : Tyre
{
    public UltrasoftTyre(double hardness, double grip) : base(hardness)
    {
        this.Grip = grip;
    }

    public double Grip { get;private set; }
    public override string Name => "Ultrasoft";

    internal override void DegradateTyre()
    {
        base.DegradateTyre();
        base.Degradation -= this.Grip;
    }

}
