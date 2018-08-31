namespace Library.Web.Pages.Borrowers
{
    using System.ComponentModel.DataAnnotations;
    using Library.Web.Filters;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Services.Contracts;

    [Authorize]
    public class AddModel : PageModel
    {
        [BindProperty]
        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Name { get; set; }

        [BindProperty]
        [Required]
        public string Address { get; set; }

        private readonly IBorrowerService borrowers;

        public AddModel(IBorrowerService borrowers)
        {
            this.borrowers = borrowers;
        }

        public void OnGet()
        {
            Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (this.borrowers.Exists(this.Name))
            {
                this.ModelState.AddModelError(nameof(this.Name), "{0} already exists!");
                return Page();
            }

            this.borrowers.Create(this.Name, this.Address);

            return Redirect("/");
        }

    }
}