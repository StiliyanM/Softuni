using System;

public abstract class Ammunition : IAmmunition
{
    public Ammunition(string name, double weight)
    {
        Name = name;
        Weight = weight;
        this.WearLevel = this.Weight * 100;
    }

    public string Name { get; private set; }

    public double Weight { get; protected set; }

    public double WearLevel { get; private set; }

    public void DecreaseWearLevel(double wearAmount)
    {
        throw new NotImplementedException();
    }
}

