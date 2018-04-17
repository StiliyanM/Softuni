using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private List<Harvester> harvesters = new List<Harvester>();
    private List<Provider> providers = new List<Provider>();

    private HarvesterFactory harvesterFactory = new HarvesterFactory();
    private ProviderFactory providerFactory = new ProviderFactory();
    private double totalStoredEnergy;

    private double totalMinedOre = 0;

    private ModeType mode = ModeType.Full;

    public double ProvidedEnergy
    {
        get
        {
            return providers.Sum(p => p.EnergyOutput);
        }
        set
        {
            this.totalStoredEnergy = value;
        }
    }

    public string RegisterHarvester(List<string> arguments)
    {
        var type = arguments[0];
        var id = arguments[1];
        var oreOutput = double.Parse(arguments[2]);
        var energyRequirement = double.Parse(arguments[3]);

        try
        {
            if (arguments.Count == 5 && type == "Sonic")
            {
                var sonicFactor = int.Parse(arguments[4]);
                var sonicHarvester = harvesterFactory.AddHarvester(id, oreOutput, energyRequirement, sonicFactor);
                harvesters.Add(sonicHarvester);

            }
            else
            {
                var hammerHarvester = harvesterFactory.AddHarvester(id, oreOutput, energyRequirement);
                harvesters.Add(hammerHarvester);
            }

            return "Successfully registered " + $"{type} Harvester - {id}";

        }
        catch (ArgumentException ae)
        {
            return ae.Message;
        }

    }

    public string RegisterProvider(List<string> arguments)
    {
        var type = arguments[0];
        var id = arguments[1];
        var energyOutput = double.Parse(arguments[2]);

        try
        {
            if (type == "Solar")
            {
                providers.Add(providerFactory.AddProvider(type, id, energyOutput));
            }
            else if (type == "Pressure")
            {
                providers.Add(providerFactory.AddProvider(type, id, energyOutput));
            }

            return "Successfully registered " + $"{type} Provider - {id}";

        }
        catch (ArgumentException ae)
        {
            return ae.Message;
        }
    }

    public string Day()
    {
        double orePerDay = 0;
        double harvestersNeededEnergyPerDay = 0;
        double energyPerDay = providers.Sum(p => p.EnergyOutput);

        totalStoredEnergy += energyPerDay;

        harvestersNeededEnergyPerDay += harvesters.Sum(p => p.EnergyRequirement);

        if (totalStoredEnergy >= harvestersNeededEnergyPerDay)
        {
            if (mode.ToString() == "Full")
            {
                orePerDay = harvesters.Sum(p => p.OreOutput);
                totalStoredEnergy -= harvestersNeededEnergyPerDay;
            }
            else if (mode.ToString() == "Half")
            {
                orePerDay = harvesters.Sum(p => p.OreOutput) * 0.5;
                totalStoredEnergy -= harvestersNeededEnergyPerDay * 0.6;
            }

            totalMinedOre += orePerDay;
        }

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("A day has passed.");
        sb.AppendLine($"Energy Provided: {energyPerDay}");
        sb.AppendLine($"Plumbus Ore Mined: {orePerDay}");
        return sb.ToString().Trim();
    }
    public string Mode(List<string> arguments)
    {
        var isMode = Enum.TryParse(arguments[0], false, out ModeType modeType);
        this.mode = modeType;

        return $"Successfully changed working mode to {mode.ToString()} Mode";
    }

    public string Check(List<string> arguments)
    {
        var id = arguments[0];

        var harvester = this.harvesters.FirstOrDefault(h => h.Id == id);
        var provider = this.providers.FirstOrDefault(p => p.Id == id);

        if (harvester == null && provider == null)
        {
            return $"No element found with id - {id}";
        }

        if (harvester != null)
        {
            return harvester.ToString();
        }
        else
        {
            return provider.ToString();

        }
    }
    public string ShutDown()
    {
        var sb = new StringBuilder();
        sb.AppendLine("System Shutdown");
        sb.AppendLine("Total Energy Stored: " + this.totalStoredEnergy.ToString());
        sb.AppendLine("Total Mined Plumbus Ore: " + this.totalMinedOre.ToString());

        return sb.ToString().TrimEnd();
    }

}

