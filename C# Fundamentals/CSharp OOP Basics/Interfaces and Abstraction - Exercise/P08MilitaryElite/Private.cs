public class Private : Soldier
{
    public Private(string firstName, string lastName, string id, double salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Id = id;
        Salary = salary;
    }

    public double Salary { get; set; }

    public override string ToString()
    {
        return $"{base.ToString()} Salary: {this.Salary:f2}";
    }
}
