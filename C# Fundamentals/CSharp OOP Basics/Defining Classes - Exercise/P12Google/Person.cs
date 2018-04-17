using System.Collections.Generic;

namespace P12Google
{
    class Person
    {
        public Person()
        {

        }

        public Person(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        public Car Car { get; set; }
        public Company Company { get; set; }
        public ICollection<Parent> Parents { get; set; } = new List<Parent>();
        public ICollection<Pokemon> Pokemons { get; set; } = new List<Pokemon>();
        public ICollection<Child> Children { get; set; } = new List<Child>();
    }
}
