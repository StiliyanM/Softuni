namespace P01Vehicles
{
    public abstract class Vehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumption, int tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            if(fuelQuantity <= TankCapacity)
            {
                this.FuelQuantity = fuelQuantity;
            }

            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; set; }
        public virtual double FuelConsumption { get; set; }
        public int TankCapacity { get; set; }

        public virtual void Refuel(double fuelAmount)
        {
            if(fuelAmount <= 0)
            {
                System.Console.WriteLine("Fuel must be a positive number");
                return;
            }

            if(fuelAmount > this.TankCapacity)
            {
                System.Console.WriteLine($"Cannot fit {fuelAmount} fuel in the tank");
                return;
            }

            this.FuelQuantity += fuelAmount;
        }

        public string Drive(double distance)
        {
            var fuelNeeded = distance * this.FuelConsumption;

            if(fuelNeeded >= this.FuelQuantity)
            {
                return $"{this.GetType().Name} needs refueling";
            }
            else
            {
                this.FuelQuantity -= fuelNeeded;
                return $"{this.GetType().Name} travelled {distance} km";
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
