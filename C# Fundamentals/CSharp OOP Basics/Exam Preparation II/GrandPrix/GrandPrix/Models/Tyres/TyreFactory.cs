public class TyreFactory
{
    public Tyre CreateTyre(string[] arguments)
    {
        var type = arguments[0];
        var hardness = double.Parse(arguments[1]);

        switch (type)
        {
            case "Hard":
                return new HardTyre(hardness);
            case "Ultrasoft":
                return new UltrasoftTyre(hardness, double.Parse(arguments[2]));
            default:
                throw new System.Exception();

        }
    }
}
