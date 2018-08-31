namespace Library.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public string CoverImageUrl { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public List<BooksBorrower> Borrowers { get; set; } = new List<BooksBorrower>();
        public bool IsBorrowed { get; set; }
    }
}
