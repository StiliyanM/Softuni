namespace MeTube.Web.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class UploadTubeViewModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        public string Description { get; set; }

        [Display(Name = "Youtube Link")]
        [Required]
        [RegularExpression(@"^https:\/\/www\.youtube\.com\/watch\?v=.{11}$", ErrorMessage = "{0} is invalid.")]
        public string YoutubeLink { get; set; }
    }
}
