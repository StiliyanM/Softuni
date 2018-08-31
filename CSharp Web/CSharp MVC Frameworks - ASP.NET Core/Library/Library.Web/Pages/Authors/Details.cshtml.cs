namespace Library.Web.Pages.Authors
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Services.Contracts;
    using Services.Models.Authors;

    public class DetailsModel : PageModel
    {
        private readonly IAuthorService authors;

        public DetailsModel(IAuthorService authors)
        {
            this.authors = authors;
        }

        public AuthorDetailsModel AuthorDetails { get; set; }

        public IActionResult OnGet(int id)
        {
            if (!this.authors.Exists(id))
            {
                return NotFound();
            }

            this.AuthorDetails = authors.Details(id);

            return Page();
        }
    }
}