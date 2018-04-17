using System.Collections.Generic;
using System.Linq;
using System;
public class City
{
    private readonly List<Robot> Robots = new List<Robot>();

    private readonly List<Citizen> Citizens = new List<Citizen>();

    private readonly List<Pet> Pets = new List<Pet>();

    public List<string> Ids { get; set; } = new List<string>();

    public List<string> Birthdays { get; set; } = new List<string>();

    public void AddRobot(Robot robot)
    {
        this.Robots.Add(robot);
    }

    public void AddCitizen(Citizen citizen)
    {
        this.Citizens.Add(citizen);
    }

    public void AddPet(Pet pet)
    {
        this.Pets.Add(pet);
    }

    public string GetDetainedIds(string number)
    {
        var detained = new List<string>();

        detained.AddRange(this.Ids.Where(e => e.EndsWith(number)).ToList());

        return string.Join(Environment.NewLine, detained);
    }

    public string GetBirthdaysInYear(string year)
    {
        var birthdays = this.Birthdays
            .Where(b => b.EndsWith(year))
            .ToList();

        return string.Join(Environment.NewLine, birthdays);
    }
}
