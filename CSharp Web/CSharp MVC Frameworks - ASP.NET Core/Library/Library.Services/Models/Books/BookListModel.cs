namespace Library.Services.Models.Books
{
    using System.ComponentModel.DataAnnotations;

    public class BookListModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int AuthorId { get; set; }

        public string Author { get; set; }

        public string Status { get; set; }

    }
}
