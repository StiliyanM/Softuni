public class Program
{
    public static void Main(string[] args)
    {
        var harvesterFactory = new HarvesterFactory();
        var providerFactory = new ProviderFactory();

        var energyRepo = new EnergyRepository();

        var harvesterController = new HarvesterController(harvesterFactory,energyRepo);

        var providerController = new ProviderController(providerFactory,energyRepo);

        var interpreter = new CommandInterpreter(harvesterController,providerController);

        var reader = new Reader();
        var writer = new Writer();

        Engine engine = new Engine(interpreter,reader,writer);

        engine.Run();
    }
}