using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
{
    class Program
    {
        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public string ReleaseDate { get; set; }
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
            
            // transfer authors and prices in a dict 

            var authorsMoney = new Dictionary<string, decimal>();

            foreach (var book in books.OrderByDescending(x => x.Price).ThenBy(x => x.Author))
            {
                string author = book.Author;
                var price = book.Price;
                if(!authorsMoney.ContainsKey(author))
                {
                    authorsMoney[author] = 0;
                }
                authorsMoney[author] += price;
            }

            // Print result 

            foreach (var author in authorsMoney)
            {
                Console.WriteLine($"{author.Key} -> {author.Value:f2}");
            }
        }

        private static Book ReadBook()
        {
            var book = new Book();

            var tokens = Console.ReadLine().Split().ToArray();

            book.Title = tokens[0];
            book.Author = tokens[1];
            book.Publisher = tokens[2];
            book.ReleaseDate = tokens[3];
            book.ISBN = tokens[4];
            book.Price = decimal.Parse(tokens[5]);

            return book;
        }
    }
}
