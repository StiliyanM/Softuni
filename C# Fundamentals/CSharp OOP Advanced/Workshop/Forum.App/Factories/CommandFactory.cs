namespace Forum.App.Factories
{	
    using System;
    using System.Linq;
    using System.Reflection;

    using Contracts;

    public class CommandFactory : ICommandFactory
	{
        private IServiceProvider serviceProvider;

        public CommandFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

		public ICommand CreateCommand(string commandName)
		{
            Type commandType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == commandName + "Command");

            if (commandType == null)
            {
                throw new ArgumentException("Command not found!");
            }

            if (!typeof(ICommand).IsAssignableFrom(commandType))
            {
                throw new ArgumentException($"{commandName}Command is not an ICommand.");
            }

            ParameterInfo[] construcorParametars = commandType.GetConstructors().First().GetParameters();

            object[] arguments = new object[construcorParametars.Length];

            for (int index = 0; index < construcorParametars.Length; index++)
            {
                arguments[index] = this.serviceProvider
                    .GetService(construcorParametars[index].ParameterType);
            }

            ICommand command = (ICommand)Activator.CreateInstance(commandType, arguments);

            return command;
		}
	}
}
