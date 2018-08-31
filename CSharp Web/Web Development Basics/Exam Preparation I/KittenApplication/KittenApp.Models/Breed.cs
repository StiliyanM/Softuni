namespace KittenApp.Models
{
    using System.Collections.Generic;

    public class Breed
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Kitten> Kittens { get; set; }
    }
}