using System;
using System.Collections.Generic;
using System.Text;

public class Engineer : SpecialisedSoldier
{
    public Engineer(string firstName, string lastName, string id, double salary) : base(firstName, lastName, id, salary)
    {
    }

    public List<Repair> Repairs { get; set; } = new List<Repair>();

    public override string ToString()
    {
        var sb = new StringBuilder($"{base.ToString()}" + Environment.NewLine);
        sb.AppendLine("Repairs:");
        sb.AppendLine($"  {string.Join(Environment.NewLine + "  ", this.Repairs)}");
        return sb.ToString().Trim();

    }
}
