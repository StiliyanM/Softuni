using System;
using System.Collections.Generic;
using System.Linq;

class TeamGenerator
{
    public List<Team> Teams { get;private set; } = new List<Team>();

    public void AddTeam(string teamName)
    {
        var teamToAdd = new Team(teamName);
        Teams.Add(teamToAdd);
    }

    public void AddPlayerToTeam(Player player, string teamName)
    {
        var team = this.FindTeam(teamName);
        team.AddPlayer(player);
    }

    public void RemovePlayerFromTeam(string playerName,string teamName)
    {
        var team = FindTeam(teamName);
        var player = team.Players.FirstOrDefault(p => p.Name == playerName);
        if (player == null)
        {
            Console.WriteLine($"Player {playerName} is not in {team.Name} team.");
        }

        team.Players.Remove(player);

    }

    private Team FindTeam(string teamName)
    {
        var team = this.Teams.FirstOrDefault(t => t.Name == teamName);
        if (team == null)
        {
            throw new ArgumentException($"Team {teamName} does not exist.");
        }

        return team;

    }

    public void PrintTeamRatings(string teamName)
    {
        var team = this.FindTeam(teamName);
        team.PrintRatings();
    }
}

