using System;
using System.Collections.Generic;
using System.Linq;


class StartUp
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
    }
}

