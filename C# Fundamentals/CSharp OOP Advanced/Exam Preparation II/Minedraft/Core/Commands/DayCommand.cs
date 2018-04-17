using System.Collections.Generic;
using System.Text;

public class DayCommand : Command
{
    public DayCommand(IHarvesterController harvesterController, IProviderController providerController, IList<string> arguments) : base(harvesterController, providerController, arguments)
    {
    }

    public override string Execute()
    {
        var result = new StringBuilder();
        result.AppendLine(this.providerController.Produce());
        result.AppendLine(this.harvesterController.Produce());

        return result.ToString().Trim();
    }
}
