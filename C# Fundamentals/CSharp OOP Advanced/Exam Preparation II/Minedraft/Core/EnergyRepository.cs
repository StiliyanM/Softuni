public class EnergyRepository : IEnergyRepository
{
    public double EnergyStored { get; private set; }

    public void StoreEnergy(double energy)
    {
        this.EnergyStored += energy;
    }

    public bool TakeEnergy(double energyNeeded)
    {
        var diff = this.EnergyStored - energyNeeded;

        if(diff < 0)
        {
            return false;
        }

        this.EnergyStored -= energyNeeded;

        return true;
    }
}
