namespace Library.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public string CoverImageUrl { get; set; }

        public int DirectorId { get; set; }
        public Director Director { get; set; }

        public List<MoviesBorrower> Borrowers { get; set; } = new List<MoviesBorrower>();

        public bool IsBorrowed { get; set; }
    }
}
