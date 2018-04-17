using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class StartUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var people = new List<Person>();
        for (int i = 0; i < n; i++)
        {
            var args = Console.ReadLine().Split();
            var name = args[0];
            var age = int.Parse(args[1]);
            var person = new Person(name, age);
            people.Add(person);
        }

        foreach (var p in people.OrderBy(p => p.Name))
        {
            if (p.Age > 30)
                Console.WriteLine(p);
        }


        //Person basePerson = (Person)emptyCtor.Invoke(new object[] { });
        //Person personWithAge = (Person)ageCtor.Invoke(new object[] { age });
        //Person personWithAgeAndName = swapped ? (Person)nameAgeCtor.Invoke(new object[] { age, name }) : (Person)nameAgeCtor.Invoke(new object[] { name, age });

        //Console.WriteLine("{0} {1}", basePerson.name, basePerson.age);
        //Console.WriteLine("{0} {1}", personWithAge.name, personWithAge.age);
        //Console.WriteLine("{0} {1}", personWithAgeAndName.name, personWithAgeAndName.age);

    }
}
