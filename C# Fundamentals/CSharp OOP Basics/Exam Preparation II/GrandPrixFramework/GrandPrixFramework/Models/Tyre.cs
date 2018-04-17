using System;

public abstract class Tyre
{
    private const int InitialValueDegradation = 100;
    private double hardness;
    private double degradation;

    protected Tyre(double hardness)
    {
        this.Hardness = hardness;
        this.Degradation = InitialValueDegradation;
    }

    public abstract string Name { get; }

    public double Degradation
    {
        get { return degradation; }
        protected set
        {
            if (value < 0 && this.Name == "Hard")
            {
                throw new ArgumentException("Blown Tyre");
            }
            if (value < 30 && this.Name == "Ultrasoft")
            {
                throw new ArgumentException("Blown Tyre");
            }
            degradation = value;
        }
    }

    public virtual void DegradateTyre()
    {
        this.Degradation -= this.Hardness;
    }

    public double Hardness
    {
        get { return hardness; }
        set { hardness = value; }
    }
}