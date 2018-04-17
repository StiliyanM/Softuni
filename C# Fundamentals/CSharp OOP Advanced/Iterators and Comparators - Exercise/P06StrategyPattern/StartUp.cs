using System;
using System.Collections.Generic;

namespace P06StrategyPattern
{
    class StartUp
    {
        static void Main()
        {
            var nameSortedPeople = new SortedSet<Person>(new NameComparer());
            var ageSortedPeople = new SortedSet<Person>(new AgeComparer());

            var peopleCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < peopleCount; i++)
            {
                var args = Console.ReadLine().Split();

                var name = args[0];
                var age = int.Parse(args[1]);

                var person = new Person(name, age);

                nameSortedPeople.Add(person);
                ageSortedPeople.Add(person);
            }

            foreach (var person in nameSortedPeople)
            {
                Console.WriteLine(person);
            }

            foreach (var person in ageSortedPeople)
            {
                Console.WriteLine(person);
            }
        }
    }
}
