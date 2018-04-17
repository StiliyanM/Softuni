using System;
using System.Collections.Generic;
using System.Linq;

public class HarvesterController : IHarvesterController
{
    public double OreProduced => this.oreProduced;

    private string mode = "Full";

    private const double HalfPercent = 0.5;
    private const double EnergyPercent = 0.2;

    private List<IHarvester> harvesters = new List<IHarvester>();

    public IReadOnlyCollection<IEntity> Entities => this.harvesters.AsReadOnly();

    private HarvesterFactory harvesterFactory;
    private IEnergyRepository energyRepository;
    private double oreProduced;

    public HarvesterController(HarvesterFactory harvesterFactory, IEnergyRepository energyRepository)
    {
        this.energyRepository = energyRepository;
        this.harvesterFactory = harvesterFactory;
    }

    public string ChangeMode(string mode)
    {
        this.mode = mode;

        List<IHarvester> reminder = new List<IHarvester>();

        foreach (var harvester in this.harvesters)
        {
            try
            {
                harvester.Broke();
            }
            catch (InvalidOperationException)
            {
                reminder.Add(harvester);
            }
        }

        foreach (var entity in reminder)
        {
            this.harvesters.Remove(entity);
        }

        return $"Mode changed to {mode}!";
    }

    public string Produce()
    {
        // Calculate required energy by harvesters
        double neededEnergy = 0;
        foreach (var harvester in this.harvesters)
        {
            if (this.mode == "Full")
            {
                neededEnergy += harvester.EnergyRequirement;
            }
            else if (this.mode == "Half")
            {
                neededEnergy += harvester.EnergyRequirement * HalfPercent;
            }
            else if (this.mode == "Energy")
            {
                neededEnergy += harvester.EnergyRequirement * EnergyPercent;
            }
        }

        // Check if all harvesters can mine
        double minedOres = 0;
        if (this.energyRepository.EnergyStored >= neededEnergy)
        {
            //mine
            this.energyRepository.TakeEnergy(neededEnergy);

            foreach (var harvester in this.harvesters)
            {
                minedOres += harvester.Produce();
            }

            // Update produced ore by mode 
            if (this.mode == "Energy")
            {
                minedOres *= 1;
            }
            else if (this.mode == "Half")
            {
                minedOres *= HalfPercent;
            }

            this.oreProduced += minedOres;
        }

        return string.Format(Constants.OreOutputToday, minedOres);
    }

    public string Register(IList<string> arguments)
    {
        var type = arguments[0];

        IHarvester harvester = harvesterFactory.GenerateHarvester(arguments);
        this.harvesters.Add(harvester);

        return string.Format(Constants.SuccessfullRegistration,
            type + "Harvester");

    }
}
