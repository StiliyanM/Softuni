using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Book_Library_Modification
{
    class Program
    {
        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime ReleaseDate { get; set; }
            public string ISBN { get; set; }
            public decimal Price { get; set; }
        }

        class Library
        {
            public string Name { get; set; }
            public List<Book> Books { get; set; }
        }

        static void Main(string[] args)
        {
            var library = new Library();

            int n = int.Parse(Console.ReadLine());

            var books = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                Book book = ReadBook();
                books.Add(book);
            }

            var date = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

            foreach (var book in books.OrderBy(x => x.ReleaseDate).ThenBy(y => y.Title))
            {
                var d = book.ReleaseDate;

                if(d > date)
                    Console.WriteLine($"{book.Title} -> {book.ReleaseDate.ToString("dd.MM.yyyy")}");
            }
        }


        private static Book ReadBook()
        {
            var book = new Book();

            var tokens = Console.ReadLine().Split().ToArray();

            book.Title = tokens[0];
            book.Author = tokens[1];
            book.Publisher = tokens[2];
            book.ReleaseDate = DateTime.ParseExact(tokens[3],"d.M.yyyy",CultureInfo.InvariantCulture);
            book.ISBN = tokens[4];
            book.Price = decimal.Parse(tokens[5]);

            return book;
        }
    }

}
