using System.Collections.Generic;

public class ModeCommand : Command
{
    public ModeCommand(IHarvesterController harvesterController, IProviderController providerController, IList<string> arguments) : base(harvesterController, providerController, arguments)
    {
    }

    public override string Execute()
    {
        var mode = this.Arguments[0];

        var result = this.harvesterController.ChangeMode(mode);

        return result;
    }
}
