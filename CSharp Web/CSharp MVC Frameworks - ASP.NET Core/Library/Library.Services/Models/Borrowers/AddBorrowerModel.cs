namespace Library.Services.Models.Borrowers
{
    using System.ComponentModel.DataAnnotations;

    public class AddBorrowerModel
    {
        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

    }
}
