public class UltrasoftTyre : Tyre
{
    private double grip;

    public UltrasoftTyre(double hardness, double grip)
        : base(hardness)
    {
        this.Grip = grip;
    }

    public double Grip
    {
        get { return grip; }
        set { grip = value; }
    }

    public override void DegradateTyre()
    {
        base.DegradateTyre();
        this.Degradation -= this.Grip;
    }

    public void ChangeTyre(double tyreHardness, double Grip)
    {
        this.Hardness = tyreHardness;
        this.Grip = grip;
    }
    public override string Name => "Ultrasoft";
}