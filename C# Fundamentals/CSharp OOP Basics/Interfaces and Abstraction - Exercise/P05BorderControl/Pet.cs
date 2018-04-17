using System;

public class Pet : IBirthable
{
    public Pet(string name, string birthday)
    {
        Name = name;
        Birthday = birthday;
    }

    public string Name { get; set; }
    public string Birthday { get; set; }
    public string Id { get; set; }
}
