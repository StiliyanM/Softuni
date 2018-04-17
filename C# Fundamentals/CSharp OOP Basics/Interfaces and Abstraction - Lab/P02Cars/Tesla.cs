using System.Text;
public class Tesla : ICar, IElectricCar
{
    public Tesla(string model, string color, int battery)
    {
        this.Model = model;
        this.Color = color;
        this.Battery = battery;
    }

    public int Battery { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Color} {nameof(Tesla)} {this.Model} with {this.Battery} Batteries");
        sb.AppendLine(Start());
        sb.AppendLine(Stop());

        var result = sb.ToString().TrimEnd();

        return result;
    }
}

