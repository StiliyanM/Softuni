namespace Library.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;

    public class Author
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Name { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();
    }
}