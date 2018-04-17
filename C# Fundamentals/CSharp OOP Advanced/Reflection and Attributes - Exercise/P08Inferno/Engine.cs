using System;

namespace P08Inferno
{
    using Contracts;
    using System.Linq;

    public class Engine
    {
        private ICommandInterpreter interpreter;
        public Engine(ICommandInterpreter interpreter)
        {
            this.interpreter = interpreter;
        }

        public void Run()
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var args = input.Split(';');
                var commandName = args[0];
                var data = args.Skip(1).ToArray();

                ICommand command = interpreter.ParseCommand(commandName, data);

                command.Execute();

            }
        }
    }
}