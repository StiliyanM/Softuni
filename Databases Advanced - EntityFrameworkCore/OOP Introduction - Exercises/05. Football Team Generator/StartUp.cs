using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StartUp
{
    static void Main()
    {
        var command = "";

        var teams = new List<Team>();

        var teamName = "";
        var playerName = "";

        while ((command = Console.ReadLine()) != "END")
        {
            var args = command.Split(';');
            try
            {
                switch (args[0])
                {
                    case "Team":
                        teamName = args.Last();
                        var teamToAdd = new Team(teamName);
                        teams.Add(teamToAdd);
                        break;

                    case "Add":

                        teamName = args[1];

                        var team = FindTeam(teams, teamName);

                        playerName = args[2];
                        var endurance = double.Parse(args[3]);
                        var sprint = double.Parse(args[4]);
                        var dribble = double.Parse(args[5]);
                        var passing = double.Parse(args[6]);
                        var shooting = double.Parse(args[7]);

                        var player = new Player(playerName, endurance, sprint, dribble, passing, shooting);

                        team.Players.Add(player);
                        break;

                    case "Remove":
                        teamName = args[1];
                        playerName = args[2];

                        var teamRemove = FindTeam(teams, teamName);
                        teamRemove.RemovePlayer(playerName);
                        break;

                    case "Rating":
                        teamName = args.Last();

                        var teamRating = FindTeam(teams, teamName);
                        teamRating.PrintRating();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }


    private static Team FindTeam(List<Team> teams, string teamName)
    {
        var team = teams.Find(t => t.Name == teamName);
        if (!teams.Any(t => t.Name == teamName))
        {
            throw new ArgumentException($"Team {teamName} does not exist.");
        }

        return team;
    }
}

