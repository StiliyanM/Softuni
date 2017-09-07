using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Order_by_Age
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string Id { get; set; }
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            var people = new List<Person>();

            while (true)
            {
                var tokens = Console.ReadLine().Split().ToArray();
                
                if(tokens[0] == "End")
                {
                    break;
                }

                string name = tokens[0];
                string id = tokens[1];
                int age = int.Parse(tokens[2]);

                Person person = new Person();
                {
                    person.Name = name;
                    person.Age = age;
                    person.Id = id;
                }

                people.Add(person);
            }

            foreach (var person in people.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
}
