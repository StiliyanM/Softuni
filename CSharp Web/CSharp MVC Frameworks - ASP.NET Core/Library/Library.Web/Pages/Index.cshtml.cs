namespace Library.Web.Pages
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Services.Contracts;
    using Services.Models.Books;

    public class IndexModel : PageModel
    {
        private readonly IBookService books;

        public IndexModel(IBookService books)
        {
            this.books = books;
        }
        public IEnumerable<BookListModel> Books { get; set; }

        public void OnGet()
        {
            this.Books = books.All();

            Page();
        }
    }
}
