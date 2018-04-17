public class AggressiveDriver : Driver
{
    private const double fuelConsumption = 2.7;
    private const double speedMultiplierAggresiveDriver = 1.3;

    public AggressiveDriver(string name, Car car)
        : base(name, car, fuelConsumption)
    {
    }

    public override double Speed => base.Speed * speedMultiplierAggresiveDriver;

    public override bool TryOvertake(Driver other, string weather)
    {
        if(this.Car.Tyre.Name == "Ultrasoft")
        {
            var diff = this.TotalTime - other.TotalTime;

            if (diff <= 3)
            {
                this.TotalTime -= 3;
                other.TotalTime += 3;

                if (weather == "Foggy")
                {
                    throw new System.ArgumentException("Crashed");
                }

                return true;
            }
        }

        return base.TryOvertake(other, weather);

    }
}
