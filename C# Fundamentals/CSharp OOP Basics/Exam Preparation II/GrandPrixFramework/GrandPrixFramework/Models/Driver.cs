public abstract class Driver
{
    private string name;
    private double totalTime;
    private Car car;
    private double fuelConsumptionPerKm;

    protected Driver(string name, Car car, double fuelConsumptionPerKm)
    {
        this.Name = name;
        this.Car = car;
        this.FuelConsumptionPerKm = fuelConsumptionPerKm;
    }

    public bool Failed { get; set; }

    public string FailureReason { get; set; }

    public virtual double Speed => (this.Car.Hp + this.Car.Tyre.Degradation) / this.Car.FuelAmount;

    public double FuelConsumptionPerKm
    {
        get { return fuelConsumptionPerKm; }
        set { fuelConsumptionPerKm = value; }
    }

    public Car Car
    {
        get { return car; }
        set { car = value; }
    }

    public double TotalTime
    {
        get { return totalTime; }
        set { totalTime = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public virtual bool TryOvertake(Driver other, string weather)
    {
        var diff = this.TotalTime - other.TotalTime;
        if (diff <= 2)
        {
            this.TotalTime -= 2;
            other.TotalTime += 2;

            return true;
        }

        return false;
    }

    public void Refuel(double fuelAmount)
    {
        this.Car.FuelAmount = fuelAmount;
    }

    public override string ToString()
    {
        return $"{this.Name} {(!Failed ? this.TotalTime.ToString("F3") : this.FailureReason)}";
    }
}