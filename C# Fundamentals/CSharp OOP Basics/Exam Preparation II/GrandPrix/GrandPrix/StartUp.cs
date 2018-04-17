using System;
using System.Linq;

namespace GrandPrix
{
    class StartUp
    {
        private enum Command
        {
            RegisterDriver, Leaderboard, CompleteLaps, Box, ChangeWeather
        }

        private static RaceTower raceTower = new RaceTower();

        static void Main()
        {
            var lapsCount = int.Parse(Console.ReadLine());
            var trackLength = int.Parse(Console.ReadLine());

            raceTower.SetTrackInfo(lapsCount, trackLength);
            while (true)
            {
                var arguments = Console.ReadLine().Split().ToList();

                Enum.TryParse(arguments[0],false,out Command command);
                arguments = arguments.Skip(1).ToList();

                string output;
                switch (command)
                {
                    case Command.RegisterDriver:
                        raceTower.RegisterDriver(arguments);
                        break;
                    case Command.Leaderboard:
                        Console.WriteLine(raceTower.GetLeaderboard());
                        break;
                    case Command.CompleteLaps:
                        output = raceTower.CompleteLaps(arguments);

                        if (!string.IsNullOrWhiteSpace(output))
                        {
                            Console.WriteLine(output);
                        }
                        break;
                    case Command.Box:
                        raceTower.DriverBoxes(arguments);
                        break;
                    case Command.ChangeWeather:
                        raceTower.ChangeWeather(arguments);
                        break;
                }
            }
        }
    }
}
