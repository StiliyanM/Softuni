public class SonicHarvester : Harvester
{
    public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor) : base(id, oreOutput, energyRequirement)
    {
        this.sonicFactor = sonicFactor;

        base.EnergyRequirement /= this.sonicFactor;
    }

    private int sonicFactor;

    public override string Type => "Sonic";
}

