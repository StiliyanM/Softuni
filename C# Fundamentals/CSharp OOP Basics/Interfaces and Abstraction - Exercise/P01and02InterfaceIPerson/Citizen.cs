public class Citizen : IPerson, IIdentifiable,IBirthable
{
    public Citizen(string name, int age, string id, string birthdate)
    {
        Name = name;
        Age = age;
        this.Id = id;
        this.Birthdate = birthdate;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public string Id { get; set; }
    public string Birthdate { get; set; }
}
