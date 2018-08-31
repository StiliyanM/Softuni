namespace Library.Web.Pages.Books
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Services.Models;
    using Services.Contracts;

    public class StatusModel : PageModel
    {
        private readonly IBookService books;

        public StatusModel(IBookService books)
        {
            this.books = books;
        }

        public IEnumerable<HistoryModel> BookHistory { get; set; }

        public void OnGet(int id)
        {
            this.BookHistory = this.books.GetHistory(id);

            Page();
        }
    }
}