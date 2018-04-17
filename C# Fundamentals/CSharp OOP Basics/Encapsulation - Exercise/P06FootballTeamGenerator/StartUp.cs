using System;
using System.Linq;

class StartUp
{
    static void Main()
    {
        var teamName = "";
        var playerName = "";

        var generator = new TeamGenerator();
        string input;

        while ((input = Console.ReadLine()) != "END")
        {
            var args = input.Split(';');
            var command = args[0];

            try
            {
                switch (command)
                {
                    case "Team":
                        teamName = args.Last();
                        generator.AddTeam(teamName);
                        break;
                    case "Add":
                        teamName = args[1];
                        var playerArgs = args.Skip(2).ToArray();
                        var player = ParsePlayer(playerArgs);
                        generator.AddPlayerToTeam(player, teamName);
                        break;
                    case "Remove":
                        teamName = args[1];
                        playerName = args[2];
                        generator.RemovePlayerFromTeam(playerName, teamName);
                        break;
                    case "Rating":
                        teamName = args.Last();
                        generator.PrintTeamRatings(teamName);
                        break;
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
    private static Player ParsePlayer(params string[] parameters)
    {
        var playerName = parameters[0];
        var endurance = double.Parse(parameters[1]);
        var sprint = double.Parse(parameters[2]);
        var dribble = double.Parse(parameters[3]);
        var passing = double.Parse(parameters[4]);
        var shooting = double.Parse(parameters[5]);

        var player = new Player(playerName, endurance, sprint, dribble, passing, shooting);

        return player;
    }

}

