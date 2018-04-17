using System;

public abstract class Driver
{
    protected Driver(string name, Car car)
    {
        this.Name = name;
        this.Car = car;
    }
    public string Name { get; protected set; }

    public double TotalTime { get; protected set; }

    public Car Car { get;protected set; }

    public abstract double FuelConsumptionPerKm { get; }

    public virtual double Speed => (this.Car.Hp + this.Car.Tyre.Degradation) / this.Car.FuelAmount;

    public string FailureReason { get; internal set; }

    internal void IncreaseTotalTime(double amount)
    {
        this.TotalTime += amount;
    }

    internal bool TryOvertake(Driver other, string weather)
    {
        var interval = 2;
        var diff = Math.Abs(this.TotalTime - other.TotalTime);

        var typeName = this.GetType().Name;
        var tyreType = this.Car.Tyre.Name;

        if(diff <= 3)
        if(typeName == "AggressiveDriver" && tyreType == "Ultrasoft")
        {
            interval = 3;

            if(weather == "Foggy")
            {
                this.FailureReason = "Crashed";
                return false;
            }
        }
        else if(typeName == "EnduranceDriver" && tyreType == "Hard")
        {
            interval = 3;

            if(weather == "Rainy")
            {
                this.FailureReason = "Crashed";
                return false;
            }
        }

        if(diff <= interval)
        {
            this.TotalTime -= interval;
            other.TotalTime += interval;
            return true;
        }
            return false;
    }
}
