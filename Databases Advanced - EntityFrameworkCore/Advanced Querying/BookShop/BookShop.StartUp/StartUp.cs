namespace BookShop
{
    using System;
    using BookShop.Data;
    using BookShop.Initializer;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using BookShop.Models;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            using (var context = new BookShopContext())
            {
                //DbInitializer.ResetDatabase(db);
                //string result = "";
                //string input = Console.ReadLine();

                //int lengthCheck = int.Parse(input);
                //var year = int.Parse(Console.ReadLine());

                //result = GetBooksByAgeRestriction(db, command);           
                //result = GetGoldenBooks(context);
                //result = GetBooksByPrice(context);
                //result = GetBooksNotRealeasedIn(context, year);
                //result = GetBooksByCategory(context,input);
                //result = GetBooksReleasedBefore(context, input);
                //result = GetAuthorNamesEndingIn(context, input);
                //result = GetBookTitlesContaining(context, input);
                //result = GetBooksByAuthor(context, input);
                //var bookCount = CountBooks(context, lengthCheck);
                //result = CountCopiesByAuthor(context);
                //result = GetTotalProfitByCategory(context);
                //result = GetMostRecentBooks(context);
                //IncreasePrices(context);
                //Console.WriteLine($"{RemoveBooks(context)} books were deleted");
                //Console.WriteLine(result);
            }
        }

        public static int RemoveBooks(BookShopContext context)
        {
            var books = context.Books
                .Where(b => b.Copies < 4200);

            var count = books.Count();

            context.RemoveRange(books);

            context.SaveChanges();

            return count;
        }

        public static void IncreasePrices(BookShopContext context)
        {
            var books = context.Books
                .Where(b => b.ReleaseDate.Value.Year < 2010)
                .ForEachAsync(b => b.Price += 5);

            context.SaveChanges();
        }

        public static string GetMostRecentBooks(BookShopContext context)
        {
            var mostRecentBooks = context.Categories
                .OrderBy(c => c.Name)
                .Select(c => new
                {
                    CategoryName = c.Name,
                    Books = c.CategoryBooks
                            .OrderByDescending(cb => cb.Book.ReleaseDate)
                            .Select(cb => $"{cb.Book.Title} ({cb.Book.ReleaseDate.Value.Year})")
                            .Take(3)
                            .ToArray()
                });

            var sb = new StringBuilder();

            foreach (var item in mostRecentBooks)
            {
                sb.AppendLine("--" + item.CategoryName);
                sb.AppendJoin(Environment.NewLine, item.Books);
                sb.AppendLine();
            }

            return sb.ToString();
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var profitByCategory = context.Categories
                .Select(b => new
                {
                    Category = b.Name,
                    TotalProfit = b.CategoryBooks.Sum(cb => cb.Book.Price * cb.Book.Copies)
                })
                .OrderByDescending(e => e.TotalProfit)
                .ToArray();

            var result = new StringBuilder();

            foreach (var item in profitByCategory)
            {
                result.AppendLine($"{item.Category} ${item.TotalProfit:f2}");
            }

            return result.ToString();
        }

        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var copiesByAuthor = context.Books
                .GroupBy(b => b.Author)
                .Select(group => new
                {
                    FullName = group.Key.FirstName + " " + group.Key.LastName,
                    CopiesCount = group.Sum(g => g.Copies)
                })
                .OrderByDescending(g => g.CopiesCount)
                .ToArray();

            var result = new StringBuilder();

            foreach (var item in copiesByAuthor)
            {
                result.AppendLine($"{item.FullName} - {item.CopiesCount}");
            }

            return result.ToString();
        }

        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            var booksCount = context.Books
                .Where(b => b.Title.Length > lengthCheck)
                .Count();

            return booksCount;
        }

        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var booksByAuthor = context.Books
                .Where
                (b => b.Author.LastName.StartsWith(input, StringComparison.InvariantCultureIgnoreCase))
                .OrderBy(b => b.BookId)
                .Select(b => $"{b.Title} ({b.Author.FirstName} {b.Author.LastName})")
                .ToArray();

            return String.Join(Environment.NewLine, booksByAuthor);
        }

        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var titles = context.Books
                .Where(b => b.Title.IndexOf(input, StringComparison.InvariantCultureIgnoreCase) >= 0)
                .Select(b => b.Title)
                .OrderBy(t => t)
                .ToArray();

            return string.Join(Environment.NewLine, titles);
        }

        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var authorNames = context.Books
                .Where(b => Regex.IsMatch(b.Author.FirstName, $"^.+{input}$"))
                .Select(b => b.Author.FirstName + " " + b.Author.LastName)
                .OrderBy(e => e)
                .Distinct()
                .ToArray();

            var result = string.Join(Environment.NewLine, authorNames);

            return result;    
        }

        public static string GetBooksReleasedBefore(BookShopContext context, string input)
        {
            var date = DateTime.ParseExact(input, "dd-MM-yyyy", null);

            var books = context.Books
                .Where(b => b.ReleaseDate < date)
                .OrderByDescending(b => b.ReleaseDate)
                .Select(b => new
                {
                    b.Title,
                    b.EditionType,
                    b.Price
                }).ToList();

            var result = new StringBuilder();

            foreach (var b in books)
            {
                result.AppendLine($"{b.Title} - {b.EditionType} - ${b.Price:f2}");
            }

            return result.ToString();
        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            var categories = Regex.Split(input.ToLower(), @"\s");

            var titles = context.Books
                .Where(b => b.BookCategories.Any(bc => categories.Contains(bc.Category.Name.ToLower())))
                .Select(b => b.Title)
                .OrderBy(t => t)
                .ToArray();

            var result = string.Join(Environment.NewLine,titles);

            return result;
        }

        public static string GetBooksNotRealeasedIn(BookShopContext context, int year)
        {
            var books = context.Books
                .Where(b => b.ReleaseDate.Value.Year != year)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToList();

            return string.Join(Environment.NewLine, books);
        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            string result = string.Empty;

            command = command.ToLower();
            int ageRestriction = -1;
            if (Models.AgeRestriction.Minor.ToString().ToLower() == command)
            {
                ageRestriction = 0;
            }
            else if (Models.AgeRestriction.Teen.ToString().ToLower() == command)
            {
                ageRestriction = 1;
            }
            else if (Models.AgeRestriction.Adult.ToString().ToLower() == command)
            {
                ageRestriction = 2;
            }

            var bookTitles = context.Books
                .Where(b => (int)b.AgeRestriction == ageRestriction)
                .Select(b => b.Title)
                .OrderBy(t => t)
                .ToArray();

            result = String.Join(Environment.NewLine, bookTitles);

            return result;
        }

        public static string GetBooksByPrice(BookShopContext context)
        {
            var books = context.Books.Select(b => new
            {
                Title = b.Title,
                Price = b.Price
            })
            .Where(e => e.Price > 40)
            .OrderByDescending(e => e.Price)
            .ToList();

            var sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - ${book.Price:f2}");
            }

            return sb.ToString();
        }

        public static string GetGoldenBooks(BookShopContext context)
        {
            var books = context.Books.
                Where(b => b.EditionType == EditionType.Gold)
                .Where(b => b.Copies < 5000)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToList();

            return string.Join(Environment.NewLine, books);
        }
    }
}



