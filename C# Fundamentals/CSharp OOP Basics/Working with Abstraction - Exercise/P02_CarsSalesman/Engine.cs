using System.Text;

class Engine
{
    private string model;
    private int power;
    private int displacement;
    private string efficiency;

    public string Model { get => model; set => model = value; }
    public int Power { get => power; set => power = value; }
    public int Displacement { get => displacement; set => displacement = value; }
    public string Efficiency { get => efficiency; set => efficiency = value; }

    public Engine()
    {
        this.Displacement = -1;
        this.Efficiency = "n/a";
    }

    public Engine(string model, int power)
        : this()
    {
        this.Model = model;
        this.Power = power;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"  {this.Model}:");
        sb.AppendLine($"    Power: {this.Power}");
        sb.AppendFormat("    Displacement: {0}\n",
            this.Displacement == -1 ? "n/a" : this.displacement.ToString());
        sb.AppendFormat("    Efficiency: {0}",this.Efficiency);

        return sb.ToString();
    }
}
