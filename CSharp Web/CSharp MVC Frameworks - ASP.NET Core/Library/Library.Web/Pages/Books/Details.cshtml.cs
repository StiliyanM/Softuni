namespace Library.Web.Pages.Books
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Services.Contracts;

    public class DetailsModel : PageModel
    {
        private readonly IBookService books;

        public DetailsModel(IBookService books)
        {
            this.books = books;
        }

        public int Id { get; set; }

        public string ImageUrl { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public IActionResult OnGet(int id)
        {
            var model = this.books.ById(id);

            if(model == null)
            {
                return NotFound();
            }

            this.Id = id;
            this.ImageUrl = model.ImageUrl;
            this.Title = model.Title;
            this.Author = model.Author;
            this.Description = model.Description;
            this.Status = model.Status;

            return Page();
        }

        public IActionResult OnGetReturn(int id)
        {
            this.books.Return(id);

            return RedirectToPage("/Index");
        }
    }
}