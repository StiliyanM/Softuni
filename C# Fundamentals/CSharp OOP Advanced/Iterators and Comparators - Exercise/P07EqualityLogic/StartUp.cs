using System;
using System.Collections.Generic;

namespace P06StrategyPattern
{
    class StartUp
    {
        static void Main()
        {
            var sorted = new SortedSet<Person>();
            var hash = new HashSet<Person>();

            var peopleCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < peopleCount; i++)
            {
                var args = Console.ReadLine().Split();

                var name = args[0];
                var age = int.Parse(args[1]);

                var person = new Person(name, age);

                sorted.Add(person);
                hash.Add(person);
            }

            Console.WriteLine(sorted.Count);
            Console.WriteLine(hash.Count);
        }
    }
}
