using System;
using System.Collections.Generic;
using System.Linq;

namespace P02Collection
{
    class StartUp
    {
        static ListyIterator<string> iterator = new ListyIterator<string>();

        private enum Command
        {
            Create, Move, Print, HasNext, PrintAll
        }
        static void Main()
        {
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                var tokens = input.Split().ToList();

                var command = tokens[0];
                var arguments = tokens.Skip(1).ToList();
                try
                {
                    ParseCommand(command, arguments);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void ParseCommand(string commandInput, List<string> arguments)
        {
            var command = Enum.Parse<Command>(commandInput);

            switch (command)
            {
                case Command.Create:
                    iterator.Create(arguments);
                    break;
                case Command.Move:
                    Console.WriteLine(iterator.Move());
                    break;
                case Command.Print:
                    iterator.Print();
                    break;
                case Command.HasNext:
                    Console.WriteLine(iterator.HasNext());
                    break;
                case Command.PrintAll:
                    Console.WriteLine(string.Join(" ", iterator));
                    break;
            }
        }
    }
}
