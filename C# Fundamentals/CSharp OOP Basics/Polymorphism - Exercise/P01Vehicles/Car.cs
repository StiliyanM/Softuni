namespace P01Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption, int tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption
        { get => base.FuelConsumption + 0.9 ; set => base.FuelConsumption = value; }
    }
}
