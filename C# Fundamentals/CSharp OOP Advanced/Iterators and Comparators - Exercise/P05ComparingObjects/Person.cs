using System;
using System.Collections.Generic;

namespace P05ComparingObjects
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }

        public string Name { get;private set; }

        public int Age { get; private set; }

        public string Town { get; private set; }

        public int CompareTo(Person other)
        {
            var result = this.Name.CompareTo(other.Name);

            if(result == 0)
            {
                result = this.Age.CompareTo(other.Age);
            }

            if(result == 0)
            {
                result = this.Town.CompareTo(other.Town);
            }

            return result;
        }

        public string GetMatches(List<Person> people)
        {
            var matchesCount = 0;

            foreach (var person in people)
            {
                if(person.CompareTo(this) == 0)
                {
                    matchesCount++;
                }               
            }

            if(matchesCount == 1)
            {
                return "No matches";
            }
            else
            {
                return $"{matchesCount} {people.Count - matchesCount} {people.Count}";
            }
        }
    }
}
