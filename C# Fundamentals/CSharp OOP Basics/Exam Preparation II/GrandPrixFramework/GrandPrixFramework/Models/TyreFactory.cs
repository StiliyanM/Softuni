public class TyreFactory
{
    public Tyre CreateTyre(double hardness)
    {
        return new HardTyre(hardness);
    }
    public Tyre CreateTyre(double hardness,double grip)
    {
        return new UltrasoftTyre(hardness,grip);
    }
}
