namespace Library.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Borrower
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        public List<MoviesBorrower> Movies { get; set; } = new List<MoviesBorrower>();

        public List<BooksBorrower> Books { get; set; } = new List<BooksBorrower>();

    }
}
