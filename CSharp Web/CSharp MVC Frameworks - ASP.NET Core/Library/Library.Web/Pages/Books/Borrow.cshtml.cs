namespace Library.Web.Pages.Books
{
    using System;
    using System.Collections.Generic;
    using Services.Models.Borrowers;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Services.Contracts;
    using System.ComponentModel.DataAnnotations;
    using Attributes;
    public class BorrowModel : PageModel
    {
        private readonly IBorrowerService borrowers;
        private readonly IBookService books;

        public BorrowModel(IBorrowerService borrowers, IBookService books)
        {
            this.borrowers = borrowers;
            this.books = books;
        }

        [BindProperty]
        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Title { get; set; }

        [BindProperty]
        [DataType(DataType.Date)]
        [DateIsIn21Century]
        public DateTime StartDate { get; set; } = DateTime.Now;

        [BindProperty]
        [DataType(DataType.Date)]
        [AfterDate(nameof(StartDate))]
        public DateTime? EndDate { get; set; }

        [BindProperty]
        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        [Display(Name = "Borrower")]
        public string Borrower { get; set; }

        public IEnumerable<AllBorrowersModel> Borrowers { get; set; }

        public IActionResult OnGet(int id)
        {
            var book = this.books.ById(id);

            if(book == null)
            {
                return NotFound();
            }

            this.Title = book.Title;

            this.Borrowers = this.borrowers.All();

           return Page();
        }

        public IActionResult OnPost(int id)
        {
            var book = this.books.ById(id);

            this.Title = book.Title;

            this.Borrowers = this.borrowers.All();

            if(book.Status == "Borrowed")
            {
                this.ModelState.AddModelError(nameof(this.Title), "Book is not available!");
            }
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (this.books.HasBeenBorrowed(id, this.Borrower))
            {
                this.ModelState.AddModelError(nameof(this.Title), "You have already borrowed this book once!");

                return Page();
            }

            this.books.Borrow(id, this.Borrower, this.StartDate, this.EndDate);

            return RedirectToPage("/Index");
        }
    }
}