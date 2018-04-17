using System;
using System.Collections.Generic;
using System.Linq;
namespace P12Google
{
    class StartUp
    {
        static void Main()
        {
            var people = new HashSet<Person>();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var tokens = command.Split();

                var personName = tokens[0];

                var personToAdd = people.FirstOrDefault(p => p.Name == personName);

                if(personToAdd == null)
                {
                    personToAdd = new Person(personName);
                }
                
                var name = tokens[2];
                string birthday;
                switch (tokens[1])
                {
                    case "company":
                        var department = tokens[3];
                        var salary = decimal.Parse(tokens[4]);

                        var company = new Company(name, department, salary);
                        personToAdd.Company = company;
                        break;
                    case "pokemon":
                        var type = tokens[3];
                        var pokemon = new Pokemon(name, type);

                        personToAdd.Pokemons.Add(pokemon);
                        break;
                    case "parents":
                        birthday = tokens[3];
                        var parent = new Parent(name, birthday);

                        personToAdd.Parents.Add(parent);
                        break;
                    case "children":
                        birthday = tokens[3];

                        var child = new Child(name,birthday);

                        personToAdd.Children.Add(child);
                        break;
                    case "car":
                        var model = tokens[2];
                        var speed = int.Parse(tokens[3]);

                        var car = new Car(model, speed);

                        personToAdd.Car = car;
                        break;
                }

                people.Add(personToAdd);
            }

            var line = Console.ReadLine();
            var person = people.FirstOrDefault(p => p.Name == line);

            Console.WriteLine($"{person.Name}");
            Console.WriteLine("Company:");

            if(person.Company != null)
            {
                Console.WriteLine(
    $"{person.Company.Name} {person.Company.Department} {person.Company.Salary:f2}");
            }
            Console.WriteLine("Car:");

            if(person.Car != null)
            {
                Console.WriteLine($"{person.Car.Model} {person.Car.Speed}");
            }

            Console.WriteLine("Pokemon:");

            foreach (var pokemon in person.Pokemons)
            {
                Console.WriteLine($"{pokemon.Name} {pokemon.Type}");
            }

            Console.WriteLine("Parents:");

            foreach (var parent in person.Parents)
            {
                Console.WriteLine($"{parent.Name} {parent.Birthday}");
            }

            Console.WriteLine("Children:");

            foreach (var child in person.Children)
            {
                Console.WriteLine($"{child.Name} {child.Birthday}");
            }
        }
    }
}
