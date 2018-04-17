using System.Collections.Generic;
using System.Linq;

public class RegisterCommand : Command
{
    public RegisterCommand(IHarvesterController harvesterController, IProviderController providerController, IList<string> arguments) : base(harvesterController, providerController, arguments)
    {
    }

    public override string Execute()
    {
        var type = this.Arguments[0];

        string result = "";

        var args = this.Arguments.Skip(1).ToList();
        if (type == nameof(Harvester))
        {
           result = this.harvesterController.Register(args);
        }
        else
        {
            result = this.providerController.Register(args);
        }

        return result;
    }
}
