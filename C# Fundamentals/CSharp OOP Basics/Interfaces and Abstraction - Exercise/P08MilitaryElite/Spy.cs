using System;
using System.Text;

public class Spy : Soldier
{
    public Spy(string firstName, string lastName, string id, int codeNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        Id = id;
        CodeNumber = codeNumber;
    }

    public int CodeNumber { get; set; }

    public override string ToString()
    {
        return $"{base.ToString()}" + Environment.NewLine + $"Code Number: {this.CodeNumber}";

    }
}
