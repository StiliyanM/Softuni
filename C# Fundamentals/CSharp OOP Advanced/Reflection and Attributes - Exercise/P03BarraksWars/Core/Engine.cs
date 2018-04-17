namespace P03BarracksFactory.Core
{
    using System;
    using Contracts;
    using System.Reflection;
    using System.Linq;

    class Engine : IRunnable
    {
        private ICommandInterpreter interpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.interpreter = commandInterpreter;
        }
        
        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] data = input.Split();
                    string commandName = data[0];
                    IExecutable command = interpreter.InterpretCommand(data, commandName);

                    var assembly = Assembly.GetExecutingAssembly();

                    var type = assembly.GetTypes().FirstOrDefault(t => t.Name.ToLower() == commandName + "command");

                    var method = type.GetMethod("Execute");

                    Console.WriteLine((string)method.Invoke(command, new object[] { }));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
