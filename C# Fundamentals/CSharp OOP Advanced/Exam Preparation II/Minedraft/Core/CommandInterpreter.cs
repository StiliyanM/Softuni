using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class CommandInterpreter : ICommandInterpreter
{
    public CommandInterpreter(IHarvesterController harvesterController, IProviderController providerController)
    {
        HarvesterController = harvesterController;
        ProviderController = providerController;
    }

    public IHarvesterController HarvesterController { get; }

    public IProviderController ProviderController { get; }

    public string ProcessCommand(IList<string> args)
    {
        var command = args[0];

        var commandType = Assembly.GetExecutingAssembly()
            .GetTypes()
            .FirstOrDefault(t => t.Name == command + "Command");

        List<string> arguments = args.Skip(1).ToList();

        var instance = Activator.CreateInstance(commandType, new object[] {HarvesterController,ProviderController,arguments });

        string result = (string)commandType.GetMethod("Execute").Invoke(instance, null);

        return result;
    }
}