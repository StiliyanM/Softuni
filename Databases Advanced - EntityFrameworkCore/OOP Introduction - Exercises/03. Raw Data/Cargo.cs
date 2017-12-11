public class Cargo
{
    public Cargo(string cargoType, int cargoWeight)
    {
        this.Weight = cargoWeight;
        this.Type = cargoType;
    }

    public int Weight { get; set; }
    public string Type { get; set; }
}