using System;
using System.Text;

public abstract class Car
{
    protected Car(string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability)
    {
        this.Brand = brand;
        this.Model = model;
        this.YearOfProduction = yearOfProduction;
        this.Horsepower = horsePower;
        this.Acceleration = acceleration;
        this.Suspension = suspension;
        this.Durability = durability;
    }
    public string Brand { get; protected set; }

    public string Model { get; protected set; }

    public int YearOfProduction { get; protected set; }

    public int Horsepower { get; protected set; }

    public int Acceleration { get; protected set; }

    public int Suspension { get; protected set; }

    public int Durability { get; protected set; }

    public int OverallPerfomance => (Horsepower / Acceleration) + (Suspension + Durability);

    public int EnginePerformance  => (Horsepower / Acceleration);

    public int SuspensionPerformance => (Suspension + Durability);

    public bool Parked { get; set; }

    public bool CanBeParked { get; set; } = true;

    public override string ToString()
    {
        var builder = new StringBuilder();

        builder.AppendLine($"{Brand} {Model} {YearOfProduction}")
            .AppendLine($"{Horsepower} HP, 100 m/h in {Acceleration} s")
            .AppendLine($"{Suspension} Suspension force, {Durability} Durability");

        var result = builder.ToString().TrimEnd();

        return result;
    }

    public virtual void Tune(int tuneIndex, string addOn)
    {
        this.Horsepower += tuneIndex;
        this.Suspension += tuneIndex / 2;
    }
}
