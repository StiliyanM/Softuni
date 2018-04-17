using System.Collections.Generic;
using System.Linq;
using System.Text;

public class InspectCommand : Command
{
    public InspectCommand(IHarvesterController harvesterController, IProviderController providerController, IList<string> arguments) : base(harvesterController, providerController, arguments)
    {
    }

    public override string Execute()
    {
        var id = int.Parse(this.Arguments[0]);

        var result = new StringBuilder();

        var provider = ((ProviderController)this.providerController)
            .Entities
            .FirstOrDefault(p => p.ID == id);

        var harvester = ((HarvesterController)this.harvesterController)
            .Entities
            .FirstOrDefault(p => p.ID == id);

        if(provider == null && harvester == null)
        {
            result.AppendLine($"No entity found with id - {id}");
        }
        else if(provider == null)
        {
            result.AppendLine(harvester.ToString());
            result.AppendLine($"Durability: {harvester.Durability}");
        }
        else
        {
            result.AppendLine(provider.ToString());
            result.AppendLine($"Durability: {provider.Durability}");
        }

        return result.ToString().TrimEnd();
    }
}
