namespace Employees.App
{
    using System;
    using System.Linq;

    class Engine
    {
        private readonly IServiceProvider serviceProvider;

        public Engine(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void Run()
        {
            while (true)
            {
                var args = Console.ReadLine().Split();

                var commandName = args[0];

                var commandArgs = args.Skip(1).ToArray();

                var commandParser = new CommandParser(serviceProvider);

                try
                {
                    var command = commandParser.ParseCommand(commandName);
                    var result = command.Execute(commandArgs);

                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
