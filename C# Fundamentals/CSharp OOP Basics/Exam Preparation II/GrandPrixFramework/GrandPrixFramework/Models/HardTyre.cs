public class HardTyre : Tyre
{
    public HardTyre(double hardness)
        : base(hardness)
    {
    }

    public void ChangeTyre(double tyreHardness)
    {
        this.Hardness = tyreHardness;
    }

    public override string Name => "Hard";
}