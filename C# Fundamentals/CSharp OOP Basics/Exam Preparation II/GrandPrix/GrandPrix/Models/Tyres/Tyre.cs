using System;

public abstract class Tyre
{
    protected Tyre(double hardness)
    {
        this.Hardness = hardness;
    }
    public abstract string Name { get; }

    public double Hardness { get; protected set; }

    private double degradation = 100;

    public double Degradation
    {
        get { return degradation; }
        protected set
        {
            if(value < 0 && this.Name == "Hard")
            {
                throw new ArgumentException("Blown Tyre");
            }
            if(value < 30 && this.Name == "Ultrasoft")
            {
                throw new ArgumentException("Blown Tyre");
            }

            degradation = value;
        }
    }

    internal virtual void DegradateTyre()
    {
        this.Degradation -= this.Hardness;
    }
}