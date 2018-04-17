public class Ferrari : ICar
{
    public Ferrari(string driverName)
    {
        DriverName = driverName;
    }

    public string Model => "488-Spider";
    public string DriverName { get; set; }

    public string PushBrakes() => "Brakes!";

    public string PushGasPedal() => "Zadu6avam sA!";

    public override string ToString()
    {
        return $"{this.Model}/{this.PushBrakes()}/{this.PushGasPedal()}/{this.DriverName}";
    }

}
