using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Teamwork_Projects
{
    class Program
    {
        class TeamInfo
        {
            public List<string> Members { get; set; }
            public string CreatorName { get; set; }
        }
        static void Main(string[] args)
        {
            int teamsCountToRegister = int.Parse(Console.ReadLine());

            TeamInfo teamInfo = new TeamInfo();
            var Teams = new Dictionary<string, TeamInfo>();

            string userName = string.Empty;
            string teamName = string.Empty;
            var joinedMembers = new List<string>();

            for (int i = 0; i < teamsCountToRegister; i++)
            {
                var tokens = Console.ReadLine().Split('-').ToArray();

                userName = tokens[0];
                teamName = tokens[1];

                if (!Teams.ContainsKey(teamName))
                {
                    Teams[teamName] = new TeamInfo();
                    {
                        Teams[teamName].CreatorName = string.Empty;
                        Teams[teamName].Members = new List<string>();
                    }
                    if (!joinedMembers.Contains(userName))
                    {
                        Teams[teamName].CreatorName = userName;
                        joinedMembers.Add(userName);
                        Console.WriteLine($"Team {teamName} has been created by {userName}!");
                    }
                    else
                    {
                        Console.WriteLine($"{userName} cannot create another team!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
            }


            while (true)
            {
                var tokens2 = Console.ReadLine().
                    Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (tokens2[0] == "end of assignment")
                {
                    break;
                }
                userName = tokens2[0];
                teamName = tokens2[1];

                if (!Teams.ContainsKey(teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                if (Teams.ContainsKey(teamName))
                {
                    
                    if (joinedMembers.Contains(userName))
                    {
                        Console.WriteLine($"Member {userName} cannot join team {teamName}!");
                    }
                    else
                    {
                        Teams[teamName].Members.Add(userName);

                    }

                    joinedMembers.Add(userName);
                }

            }

            var teamsToPrint = new Dictionary<string, TeamInfo>();
            var teamsToDisband = new SortedDictionary<string, TeamInfo>();

            foreach (var team in Teams)
            {
                if (team.Value.Members.Count == 0)
                {
                    if (!teamsToDisband.ContainsKey(team.Key))
                    {
                        teamsToDisband[team.Key] = new TeamInfo();
                        {
                            teamsToDisband[team.Key].CreatorName = string.Empty;
                            teamsToDisband[team.Key].Members = new List<string>();
                        }
                    }
                }
                else
                {
                    if (!teamsToPrint.ContainsKey(team.Key))
                    {
                        teamsToPrint[team.Key] = new TeamInfo();
                        {
                            teamsToPrint[team.Key].CreatorName = string.Empty;
                            teamsToPrint[team.Key].Members = new List<string>();
                        }
                    }
                    teamsToPrint[team.Key].CreatorName = Teams[team.Key].CreatorName;
                    teamsToPrint[team.Key].Members.AddRange(Teams[team.Key].Members);
                }
            }

            foreach (var team in teamsToPrint.OrderByDescending(x => x.Value.Members.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine(team.Key);
                Console.WriteLine("- " + team.Value.CreatorName);
                foreach (var member in team.Value.Members.OrderBy(x => x))
                {
                    Console.WriteLine("-- " + member);
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsToDisband)
            {
                Console.WriteLine(team.Key);
            }

        }
    }
}




