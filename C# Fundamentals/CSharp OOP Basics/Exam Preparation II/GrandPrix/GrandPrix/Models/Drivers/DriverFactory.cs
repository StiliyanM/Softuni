using System.Linq;

public class DriverFactory
{
    static TyreFactory tyreFactory = new TyreFactory();
    public Driver CreateDriver(string[] arguments)
    {
        var type = arguments[0];

        var name = arguments[1];
        var hp = int.Parse(arguments[2]);
        var fuelAmount = double.Parse(arguments[3]);

        var tyre = tyreFactory.CreateTyre(arguments.Skip(4).ToArray());

        var car = new Car(hp,fuelAmount,tyre);

        switch (type)
        {
            case "Aggressive":
                return new AggressiveDriver(name, car);
            case "Endurance":
                return new EnduranceDriver(name, car);
            default:
                throw new System.Exception();
        }
    }
}
