using System;

public abstract class Provider : IProvider
{
    private const int InitialDurability = 1000;
    private double durability;

    public Provider(int id,double energyOutput)
    {
        EnergyOutput = energyOutput;
        ID = id;
        Durability = InitialDurability;
    }

    public double EnergyOutput { get; protected set; }

    public int ID { get; }

    public virtual double Durability
    {
        get
        {
            return this.durability;
        }
        protected set
        {
            if (value < 0)
            {
                throw new InvalidOperationException();
            }

            this.durability = value;
        }
    }


    public void Broke()
    {
        this.Durability -= 100;
    }

    public double Produce()
    {
        return this.EnergyOutput;
    }

    public void Repair(double val)
    {
        this.Durability += val;
    }
}