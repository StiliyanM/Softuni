using System.Collections.Generic;

public abstract class Command : ICommand
{
    protected IHarvesterController harvesterController;
    protected IProviderController providerController;

    public Command(IHarvesterController harvesterController, IProviderController providerController, IList<string> arguments)
    {
        this.harvesterController = harvesterController;
        this.providerController = providerController;
        Arguments = arguments;
    }

    public IList<string> Arguments { get; }

    public abstract string Execute();
}
