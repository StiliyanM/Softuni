using System.Collections.Generic;

namespace P13FamilyTree
{
    class Person
    {
        public string Name { get; set; }
        public string Birthday { get; set; }

        public ICollection<Person> Parents { get; set; } = new List<Person>();
        public ICollection<Person> Children { get; set; } = new List<Person>();
    }
}
