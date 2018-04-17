using System;
using System.Text;
public abstract class Harvester : Identificator
{
    public virtual string Type { get;}
    private double oreOutput;
    private double energyRequirement;
    private const string NotRegisteredMessage = "Harvester is not registered, because of it's {0}";

    public Harvester(string id, double oreOutput, double energyRequirement)
        :base(id)
    {
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    public double OreOutput
    {
        get { return oreOutput; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException(string.Format(NotRegisteredMessage,nameof(OreOutput)));
            }
            oreOutput = value;
        }
    }

    public double EnergyRequirement
    {
        get { return energyRequirement; }
        protected set
        {
            if (value < 0 || value > 20000)
            {
                throw new ArgumentException(string.Format(NotRegisteredMessage, nameof(EnergyRequirement)));
            }
            energyRequirement = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{Type} Harvester - {Id}");
        sb.AppendLine($"Ore Output: {this.OreOutput}");
        sb.AppendLine($"Energy Requirement: {this.EnergyRequirement}");

        return sb.ToString().TrimEnd();
    }

}

