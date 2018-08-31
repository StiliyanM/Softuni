namespace MeTube.Web.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class LoginUserViewModel
    {
        [Required]
        [MinLength(3)]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

    }
}
