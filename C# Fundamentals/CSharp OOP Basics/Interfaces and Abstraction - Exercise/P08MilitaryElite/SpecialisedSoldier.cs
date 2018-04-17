using System;

public class SpecialisedSoldier : Private
{
    public SpecialisedSoldier(string firstName, string lastName, string id, double salary) : base(firstName, lastName, id, salary)
    {
    }

    public Corps Corps { get; set; }

    public override string ToString()
    {
        return $"{base.ToString()}" + Environment.NewLine + $"Corps: {this.Corps}";
    }
}
