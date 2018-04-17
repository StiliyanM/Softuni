using System;
using System.Linq;
using System.Reflection;
using P03BarracksFactory.Contracts;

namespace P03BarracksFactory.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private IRepository repository;
        private IUnitFactory unitFactory;

        public CommandInterpreter()
        {
        }

        public CommandInterpreter(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            var assembly = Assembly.GetExecutingAssembly();

            var type = assembly.GetTypes().FirstOrDefault(t => t.Name.ToLower() == commandName + "command");

            if (type == null)
            {
                throw new InvalidOperationException("Invalid command!");
            }
            var instance = Activator.CreateInstance(type, new object[] { data, repository, unitFactory });

            return (IExecutable)instance;
        }
    }
}