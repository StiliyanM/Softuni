public class HarvesterFactory
{
    public Harvester AddHarvester(string id, double oreOutput, double energyRequirement)
    {
        return new HammerHarvester(id,oreOutput,energyRequirement);
    }

    public Harvester AddHarvester(string id, double oreOutput, double energyRequirement,int sonicFactor)
    {
        return new SonicHarvester(id, oreOutput, energyRequirement,sonicFactor);
    }

}
