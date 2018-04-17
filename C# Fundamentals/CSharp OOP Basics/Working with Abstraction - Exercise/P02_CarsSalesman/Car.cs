using System.Text;

class Car
{
    public string Model { get; set; }

    public Engine Engine { get; set; }

    public int Weight { get; set; }

    public string Color { get; set; }

    public Car()
    {
        this.Weight = -1;
        this.Color = "n/a";
    }
    public Car(string model, Engine engine)
        : this()
    {
        this.Model = model;
        this.Engine = engine;
    }


    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.Model}:");
        sb.AppendLine($"{this.Engine}");
        sb.AppendFormat("  Weight: {0}\n", this.Weight == -1 ? "n/a" : this.Weight.ToString());
        sb.AppendFormat("  Color: {0}", this.Color);

        return sb.ToString();
    }
}