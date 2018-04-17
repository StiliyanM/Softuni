using System;
using System.Linq;

namespace GrandPrixFramework
{
    class Program
    {
        private enum Command
        {
            RegisterDriver, Leaderboard, CompleteLaps, Box, ChangeWeather
        }
        static void Main()
        {
            var numberOfLaps = int.Parse(Console.ReadLine());
            var trackLength = int.Parse(Console.ReadLine());

            var manager = new RaceTower();

            manager.SetTrackInfo(numberOfLaps, trackLength);

            while (true)
            {
                try
                {
                    var arguments = Console.ReadLine().Split().ToList();

                    Enum.TryParse(arguments[0], false, out Command command);

                    arguments = arguments.Skip(1).ToList();
                    switch (command)
                    {
                        case Command.RegisterDriver:

                            manager.RegisterDriver(arguments);
                            break;
                        case Command.Leaderboard:
                            Console.WriteLine(manager.GetLeaderboard());
                            break;
                        case Command.CompleteLaps:
                            Console.WriteLine(manager.CompleteLaps(arguments));
                            break;
                        case Command.Box:
                            manager.DriverBoxes(arguments);
                            break;
                        case Command.ChangeWeather:
                            manager.ChangeWeather(arguments);
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

        }
    }
}
