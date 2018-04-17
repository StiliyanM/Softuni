using System;

public class Car
{
    public Car(int hp, double fuelAmount, Tyre tyre)
    {
        this.Hp = hp;
        this.FuelAmount = fuelAmount;
        this.Tyre = tyre;
    }
    public int Hp { get; private set; }

    private double fuelAmount;

    public double FuelAmount
    {
        get { return fuelAmount; }
        private set
        {
            if(value < 0)
            {
                throw new System.ArgumentException("Out of fuel");
            }

            this.fuelAmount = value > 160 ? 160 : value;
        }
    }

    internal void Refuel(double fuel)
    {
        this.FuelAmount += fuel;
    }

    public Tyre Tyre { get;private set; }

    internal void ChangeTyre(Tyre tyre)
    {
        this.Tyre = tyre;
    }

    internal void ReduceFuelAmount(double amount)
    {
        this.FuelAmount -= amount;
    }
}