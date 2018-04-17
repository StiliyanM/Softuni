public class EnduranceDriver : Driver
{
    private const double FUEL_CONSUMPTION = 1.5;

    public EnduranceDriver(string name, Car car)
        : base(name, car, FUEL_CONSUMPTION)
    {
    }

    public override bool TryOvertake(Driver other, string weather)
    {
        if (this.Car.Tyre.Name == "Hard")
        {
            var diff = this.TotalTime - other.TotalTime;

            if (diff <= 3)
            {
                this.TotalTime -= 3;
                other.TotalTime += 3;

                if (weather == "Rainy")
                {
                    throw new System.ArgumentException("Crashed");
                }

                return true;
            }

        }
        return base.TryOvertake(other, weather);

    }
}