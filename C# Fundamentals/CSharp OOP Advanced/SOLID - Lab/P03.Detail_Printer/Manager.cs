using System;
using System.Collections.Generic;
using System.Text;

public class Manager : Person
{
    public Manager(List<string> documents,string name) : base(name)
    {
        this.Documents = documents;
    }

    public IReadOnlyCollection<string> Documents { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString());

        sb.AppendLine(string.Join(Environment.NewLine, this.Documents));

        return sb.ToString().TrimEnd();
    }
}

