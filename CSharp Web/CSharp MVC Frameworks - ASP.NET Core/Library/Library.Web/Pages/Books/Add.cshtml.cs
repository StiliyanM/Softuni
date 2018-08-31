namespace Library.Web.Pages.Books
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using System.ComponentModel.DataAnnotations;
    using Services.Contracts;
    using Library.Web.Filters;

    [Authorize]
    public class AddModel : PageModel
    {
        private readonly IBookService books;

        public AddModel(IBookService books)
        {
            this.books = books;
        }

        [BindProperty]
        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Title { get; set; }

        [BindProperty]
        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Author { get; set; }

        [Required]
        [BindProperty]
        public string Description { get; set; }

        [BindProperty]
        [Required]
        [Display(Name = "Image Url")]
        public string ImageUrl { get; set; }

        public IActionResult OnGet()
        {
           return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            this.books.Create(this.Title, this.Author, this.ImageUrl, this.Description);

            return Redirect("/");
        }

    }
}