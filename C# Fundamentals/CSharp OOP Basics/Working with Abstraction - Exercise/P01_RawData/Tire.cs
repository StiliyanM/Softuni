public class Tire
{

    public Tire(double pressure, int age)
    {
        this.Pressure = pressure;
        this.Age = age;
    }

    public Tire()
    {

    }

    public int Age { get; set; }
    public double Pressure { get; set; }
}
