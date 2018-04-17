using System;
using System.Collections.Generic;
using System.Text;

public class LeutenantGeneral : Private
{
    public LeutenantGeneral(string firstName, string lastName, string id, double salary) : base(firstName, lastName, id, salary)
    {
    }

    public List<Private> Privates { get; set; } = new List<Private>();

    public override string ToString()
    {
        var sb = new StringBuilder($"{base.ToString()}" + Environment.NewLine);
        sb.AppendLine("Privates:");
        sb.AppendLine($"  {string.Join(Environment.NewLine + "  ", this.Privates)}");
        return sb.ToString().Trim();
    }
}
