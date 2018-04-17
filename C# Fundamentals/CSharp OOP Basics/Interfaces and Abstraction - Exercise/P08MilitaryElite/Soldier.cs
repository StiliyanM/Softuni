public abstract class Soldier
{
    public string Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public override string ToString()
    {
        return $"Name: {FirstName} {LastName} Id: {Id}";
    }
}
