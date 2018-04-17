using System.Collections.Generic;
using System;

public class PerformanceCar : Car
{
    public PerformanceCar(string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability) : base(brand, model, yearOfProduction, horsePower + (horsePower * 50) / 100, acceleration, suspension - (suspension * 25) / 100, durability)
    {
    }

    public ICollection<string> AddOns { get; private set; } = new List<string>();

    public override string ToString()
    {
        var addOns = string.Join(", ", this.AddOns);

        if(this.AddOns.Count == 0)
        {
            addOns = "None";
        }


        return base.ToString() + Environment.NewLine +
            $"Add-ons: {addOns}";
    }

    public override void Tune(int tuneIndex, string addOn)
    {
        base.Tune(tuneIndex, addOn);

        this.AddOns.Add(addOn);
    }
}

