using System;
using System.Collections.Generic;
public class DetailsPrinter
{
    private IList<Person> people;

    public DetailsPrinter(IList<Person> people)
    {
        this.people = people;
    }

    public void PrintDetails()
    {
        foreach (Person person in this.people)
        {
            Console.WriteLine(person);
        }
    }
}

