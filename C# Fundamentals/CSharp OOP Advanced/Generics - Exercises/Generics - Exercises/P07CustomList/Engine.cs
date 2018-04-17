using System;
using System.Linq;

namespace P07CustomList
{
    internal class Engine
    {
        private CommandInterpreter interpreter;

        public Engine(CommandInterpreter interpreter)
        {
            this.interpreter = interpreter;
        }

        public void Run()
        {
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                var tokens = input.Split();

                var commandInput = tokens.First();
                var command = ParseCommand(commandInput);
                var args = tokens.Skip(1).ToArray();

                interpreter.InterpretCommand(command,args);
            }
        }

        private Command ParseCommand(string commandInput)
        {
            var isValid = Enum.TryParse<Command>(commandInput, out Command command);

            if (!isValid)
            {
                throw new ArgumentException("Invalid command!");
            }

            return command;
        }
    }
}