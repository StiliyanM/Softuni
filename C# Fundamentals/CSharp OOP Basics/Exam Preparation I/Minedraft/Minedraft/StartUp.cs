using System;
using System.Linq;
using System.Text;

namespace Minedraft
{
    class StartUp
    {
        static StringBuilder builder = new StringBuilder();

        static void Main()
        {
            var manager = new DraftManager();

            while (true)
            {
                var tokens = Console.ReadLine().Split();
                var command = tokens[0];

                var args = tokens.Skip(1).ToList();

                try
                {
                    ExecuteCommand(manager, command, args);
                }
                catch (ArgumentException ex)
                {
                    builder.AppendLine(ex.Message);
                }

                if (command == "Shutdown")
                {
                    break;
                }

            }

            Console.WriteLine(builder.ToString().TrimEnd());
        }

        private static void ExecuteCommand(DraftManager manager, string command, System.Collections.Generic.List<string> args)
        {
            switch (command)
            {
                case "RegisterHarvester":
                    builder.AppendLine(manager.RegisterHarvester(args));
                    break;
                case "RegisterProvider":
                    builder.AppendLine(manager.RegisterProvider(args));
                    break;
                case "Day":
                    builder.AppendLine(manager.Day());
                    break;
                case "Mode":
                    builder.AppendLine(manager.Mode(args));
                    break;
                case "Check":
                    builder.AppendLine(manager.Check(args));
                    break;
                case "Shutdown":
                    builder.AppendLine(manager.ShutDown());
                    break;
            }
        }
    }
}
