using System;
using System.Collections.Generic;
using System.Linq;


public class Team
{
    private List<Player> players;
    private string name;

    public Team(string teamName)
    {
        players = new List<Player>();

        this.Name = teamName;
    }

    public int Rating
    {
        get
        {
            int rating = 0;
             rating = (int)Math.Round(players.Average(p => p.GetAverageStats()));
            return rating;
        }
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("A name should not be empty.");

            name = value;
        }
    }

    public List<Player> Players
    {
        get { return players; }
        set { players = value; }
    }

    public void AddPlayer(Player player)
    {
        this.Players.Add(player);
    }

    public void PrintRatings()
    {
        Console.WriteLine($"{this.Name} - {this.Rating}");
    }
}

