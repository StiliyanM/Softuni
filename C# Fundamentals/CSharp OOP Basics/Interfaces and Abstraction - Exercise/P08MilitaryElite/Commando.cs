using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Commando : SpecialisedSoldier
{
    public Commando(string firstName, string lastName, string id, double salary) : base(firstName, lastName, id, salary)
    {
    }

    public List<Mission> Missions { get; set; } = new List<Mission>();

    public override string ToString()
    {
        var sb = new StringBuilder($"{base.ToString()}" + Environment.NewLine);
        sb.AppendLine("Missions:");
        sb.AppendLine($"  {string.Join(Environment.NewLine + "  ", this.Missions)}");
        return sb.ToString().Trim();
    }
}
