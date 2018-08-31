using System.ComponentModel.DataAnnotations;

namespace KittenApp.Web.Models
{
    public class LoginBindingModel
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [MinLength(3)]
        public string Password { get; set; }
    }
}
