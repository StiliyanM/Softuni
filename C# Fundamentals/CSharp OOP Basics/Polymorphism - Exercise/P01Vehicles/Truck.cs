namespace P01Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, int tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption
        { get => base.FuelConsumption + 1.6; set => base.FuelConsumption = value; }

        public override void Refuel(double fuelAmount)
        {
            if (fuelAmount <= 0)
            {
                System.Console.WriteLine("Fuel must be a positive number");
                return;
            }

            if (fuelAmount > this.TankCapacity)
            {
                System.Console.WriteLine($"Cannot fit {fuelAmount} fuel in the tank");
                return;
            }

            this.FuelQuantity += fuelAmount * 0.95;

        }
    }
}
