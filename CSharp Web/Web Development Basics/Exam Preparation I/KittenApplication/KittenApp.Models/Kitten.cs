namespace KittenApp.Models
{
    public class Kitten
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string ImageUrl { get; set; }

        public int BreedId { get; set; }
        public Breed Breed { get; set; }
    }
}
