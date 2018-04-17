using System;
using System.Collections.Generic;
using System.Linq;
namespace P13FamilyTree
{
    class StartUp
    {
        static List<Person> familyTree = new List<Person>();
        static void Main()
        {
            var input = Console.ReadLine();

            var mainPerson = CreatePerson(input);

            familyTree.Add(mainPerson);
            string command;

            var person = new Person();
            while ((command = Console.ReadLine()) != "End")
            {
                var tokens = command.Split(" - ");

                if (tokens.Length == 1)
                {
                    FillMissingInfo(tokens);
                    continue;
                }

                var parentInfo = tokens[0];
                var childInfo = tokens[1];

                AddParentAndChildToFamilyTree(parentInfo, childInfo);
            }

            mainPerson = familyTree[0];

            AddRelativesToMainPerson(mainPerson);

            PrintPersonFamilyTree(mainPerson);
        }

        private static void FillMissingInfo(string[] input)
        {
            var nameAndDate = input[0].Split(" ");

            var name = nameAndDate[0] + " " + nameAndDate[1];
            var date = nameAndDate.Last();

            var people = FindPeople(name, date);

            for (int i = 0; i < people.Count; i++)
            {
                people[i].Name = name;
                people[i].Birthday = date;
            }
        }

        private static void AddParentAndChildToFamilyTree(string parentInfo, string childInfo)
        {
            var person = FindPersonByNameOrBirthday(parentInfo);
            var child = FindPersonByNameOrBirthday(childInfo);
            if (person == null)
            {
                person = CreatePerson(parentInfo);
            }

            if (child == null)
            {
                child = CreatePerson(childInfo);
            }

            familyTree.Add(person);
            familyTree.Add(child);
        }

        private static void AddRelativesToMainPerson(Person mainPerson)
        {
            familyTree.Remove(mainPerson);

            for (int i = 0; i < familyTree.Count; i += 2)
            {
                var parent = familyTree[i];
                var child = familyTree[i + 1];

                if (parent.Name == mainPerson.Name)
                {
                    mainPerson.Children.Add(child);
                }
                else if (child.Name == mainPerson.Name)
                {
                    mainPerson.Parents.Add(parent);
                }
            }
        }

        private static void PrintPersonFamilyTree(Person mainPerson)
        {
            Console.WriteLine($"{mainPerson.Name} {mainPerson.Birthday}");

            Console.WriteLine($"Parents:");

            foreach (var p in mainPerson.Parents)
            {
                Console.WriteLine($"{p.Name} {p.Birthday}");
            }

            Console.WriteLine("Children:");

            foreach (var c in mainPerson.Children)
            {
                Console.WriteLine($"{c.Name} {c.Birthday}");
            }
        }

        private static Person FindPersonByNameOrBirthday(string input)
        {
            var person = new Person();

            if (IsDate(input))
            {
                person = familyTree.FirstOrDefault(p => p.Birthday == input);
            }
            else
            {
                person = familyTree.FirstOrDefault(p => p.Name == input);
            }

            return person;
        }

        private static Person CreatePerson(string input)
        {
            var person = new Person();
            if (IsDate(input))
            {
                person.Birthday = input;
            }
            else
            {
                person.Name = input;
            }

            return person;
        }

        private static List<Person> FindPeople(string name, string date)
        {
            var people = familyTree.FindAll(e => e.Name == name || e.Birthday == date);

            return people;
        }

        private static bool IsDate(string input)
        {
            return char.IsDigit(input[0]);
        }
    }
}
