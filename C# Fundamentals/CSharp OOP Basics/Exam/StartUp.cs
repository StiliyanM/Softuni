using System;
using System.Collections.Generic;
using System.Linq;

namespace DungeonsAndCodeWizards
{
	public class StartUp
	{
        // DO NOT rename this file's namespace or class name.
        // However, you ARE allowed to use your own namespaces (or no namespaces at all if you prefer) in other classes.

        private static List<string> builder = new List<string>();

        private enum Command
        {
            JoinParty, AddItemToPool, PickUpItem, UseItem, UseItemOn, GiveCharacterItem,
            GetStats, Attack, Heal, EndTurn, IsGameOver
        }

        static DungeonMaster master = new DungeonMaster();
		public static void Main()
		{
            string input = Console.ReadLine();

            while (!string.IsNullOrWhiteSpace(input))
            {
                try
                {
                    var commandArgs = input.Split();
                    Command command = (Command)Enum.Parse(typeof(Command), commandArgs[0]);
                    var arguments = commandArgs.Skip(1).ToArray();

                    builder.Add(ParseCommand(command,arguments));
                }
                catch (ArgumentException ax)
                {
                    builder.Add("Parameter Error: " + ax.Message);
                }
                catch (InvalidOperationException iox)
                {
                    builder.Add("Invalid Operation: " + iox.Message);
                }

                if (master.IsGameOver())
                {
                    break;
                }

                input = Console.ReadLine();
            }

            builder.Add("Final stats:");
            builder.Add(master.GetStats());

            Console.WriteLine(string.Join(Environment.NewLine,builder.Where(e => !string.IsNullOrWhiteSpace(e))));
        }

        private static string ParseCommand(Command command, string[] arguments)
        {
            switch (command)
            {
                case Command.JoinParty:
                    return master.JoinParty(arguments);
                case Command.AddItemToPool:
                    return master.AddItemToPool(arguments);
                case Command.PickUpItem:
                    return master.PickUpItem(arguments);
                case Command.UseItem:
                    return master.UseItem(arguments);
                case Command.UseItemOn:
                    return master.UseItemOn(arguments);
                case Command.GiveCharacterItem:
                    return master.GiveCharacterItem(arguments);
                case Command.GetStats:
                    return master.GetStats();
                case Command.Attack:
                    return master.Attack(arguments);
                case Command.Heal:
                    return master.Heal(arguments);
                case Command.EndTurn:
                    return master.EndTurn(arguments);
                case Command.IsGameOver:
                    master.IsGameOver();
                    return "";
                default:
                    return "";
            }
        }
    }
}