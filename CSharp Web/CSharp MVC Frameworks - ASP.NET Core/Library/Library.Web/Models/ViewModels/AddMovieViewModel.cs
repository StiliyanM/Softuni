namespace Library.Web.Models.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class AddMovieViewModel
    {
        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Director { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Image Url")]
        public string ImageUrl { get; set; }
    }
}
