namespace KittenApp.Web.Models
{
    using System.ComponentModel.DataAnnotations;

    public class RegisterBindingModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [MinLength(3)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

    }
}
