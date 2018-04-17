namespace P08Inferno
{
    using Contracts;
    using System.Linq;
    using System.Reflection;
    using System;
    
    public class CommandInterpreter : ICommandInterpreter
    {
        private IWeaponRepository repo;

        public CommandInterpreter(IWeaponRepository repo)
        {
            this.repo = repo;
        }

        public ICommand ParseCommand(string commandName, string[] data)
        {
            var assembly = Assembly.GetExecutingAssembly();

            var type = assembly.GetTypes().FirstOrDefault(t => t.Name == commandName + "Command");

            if(type == null)
            {
                throw new ArgumentException("Invalid Command");
            }

            return (ICommand)Activator.CreateInstance(type, new object[] { repo, data });
        }
    }
}
