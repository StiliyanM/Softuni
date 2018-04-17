using System.Collections.Generic;
using System.Text;

public class ShutdownCommand : Command
{
    public ShutdownCommand(IHarvesterController harvesterController, IProviderController providerController, IList<string> arguments) : base(harvesterController, providerController, arguments)
    {
    }

    public override string Execute()
    {
        var sb = new StringBuilder();
        sb.AppendLine("System Shutdown");
        sb.AppendLine($"Total Energy Produced: {this.providerController.TotalEnergyProduced}");
        sb.Append($"Total Mined Plumbus Ore: {this.harvesterController.OreProduced}");

        return sb.ToString();
    }
}
