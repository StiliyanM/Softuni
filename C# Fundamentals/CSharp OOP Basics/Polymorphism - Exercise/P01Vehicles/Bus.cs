namespace P01Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, int tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public bool WithPeople { get; set; }

        public override double FuelConsumption
        { get => this.WithPeople == true ? base.FuelConsumption + 1.4 : base.FuelConsumption;
            set => base.FuelConsumption = value; }
    }
}
