public class PressureProvider : Provider
{
    public PressureProvider(int iD, double energyOutput) : base(iD, energyOutput * 2)
    {
        this.Durability -= 300;
    }
}
