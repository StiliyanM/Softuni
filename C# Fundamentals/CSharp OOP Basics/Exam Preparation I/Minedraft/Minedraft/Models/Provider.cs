using System;
using System.Text;

public abstract class Provider : Identificator
{
    private double energyOutput;
    public virtual string Type { get; }
    public Provider(string id, double energyOutput)
        :base(id)
    {
        this.EnergyOutput = energyOutput;
    }

    public double EnergyOutput
    {
        get { return energyOutput; }
        protected set
        {
            if (value < 0 || value >= 10000)
            {
                throw new ArgumentException($"Provider is not registered, because of it's {nameof(EnergyOutput)}");
            }
            energyOutput = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{Type} Provider - {Id}")
            .AppendLine($"Energy Output: {this.EnergyOutput}");

        return sb.ToString().TrimEnd();
    }

}

