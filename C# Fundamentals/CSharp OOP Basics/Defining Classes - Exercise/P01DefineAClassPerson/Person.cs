public class Person
{
    private int age;

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Person()
    {
        this.Name = "No name";
        this.Age = 1;
    }

    public Person(int age)
        : this()
    {
        this.Age = age;

    }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public override string ToString()
    {
        return $"{this.Name} - {this.Age}";
    }
}

