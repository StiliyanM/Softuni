using System.Collections.Generic;

public class RepairCommand : Command
{
    public RepairCommand(IHarvesterController harvesterController, IProviderController providerController, IList<string> arguments) : base(harvesterController, providerController, arguments)
    {
    }

    public override string Execute()
    {
        var value = double.Parse(this.Arguments[0]);

        var result = this.providerController.Repair(value);

        return result;
    }
}
