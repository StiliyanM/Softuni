using System;
using System.Collections.Generic;

namespace P05ComparingObjects
{
    class StartUp
    {
        static void Main()
        {
            string input;

            var people = new List<Person>();

            while ((input = Console.ReadLine()) != "END")
            {
                var arguments = input.Split();

                var name = arguments[0];
                var age = int.Parse(arguments[1]);
                var town = arguments[2];

                var person = new Person(name, age, town);

                people.Add(person);
            }

            var index = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine(people[index].GetMatches(people));
        }
    }
}
