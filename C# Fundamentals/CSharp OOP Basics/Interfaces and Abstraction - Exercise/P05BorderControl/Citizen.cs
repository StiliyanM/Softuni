﻿public class Citizen : IBirthable, IBuyer
{
    public Citizen(string name, int age, string id, string birthday)
    {
        Name = name;
        Age = age;
        Id = id;
        Birthday = birthday;
    }

    public string Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Birthday { get; set; }
    public int Food { get; set; }

    public void BuyFood()
    {
        this.Food += 10;
    }
}
