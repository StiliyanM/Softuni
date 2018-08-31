namespace Library.Services.Models.Authors
{
    using System.Collections.Generic;

    public class AuthorDetailsModel
    {
        public string Name { get; set; }

        public List<BooksByAuthorModel> Books { get; set; } = new List<BooksByAuthorModel>();
    }

    public class BooksByAuthorModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }
    }
}
