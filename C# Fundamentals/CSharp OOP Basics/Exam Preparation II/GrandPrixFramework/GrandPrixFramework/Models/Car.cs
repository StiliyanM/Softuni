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
         set
        {
            if(value > 160)
            {
                value = 160;
            }

            if(value < 0)
            {
                throw new System.ArgumentException("Out of fuel");
            }
            fuelAmount = value;
        }
    }

    public Tyre Tyre { get; set; }
}