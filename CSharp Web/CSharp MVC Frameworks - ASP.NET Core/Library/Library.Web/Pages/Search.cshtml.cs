namespace Library.Web.Pages
{
    using Library.Web.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Services.Contracts;
    using Services.Models.Authors;
    using Services.Models.Books;
    using System.Collections.Generic;
    using System.Linq;
    using Services.Models;
    using System;

    public class SearchModel : PageModel
    {
        private readonly IBookService books;
        private readonly IAuthorService authors;
        private readonly IMovieService movies;
        private readonly IDirectorService directors;

        public SearchModel(IBookService books, IAuthorService authors, IMovieService movies, IDirectorService directors)
        {
            this.books = books;
            this.authors = authors;
            this.movies = movies;
            this.directors = directors;
            this.SearchResults = new List<SearchResultModel>();
        }

        public List<SearchResultModel> SearchResults { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public void OnGet()
        {
            if(this.SearchTerm == null)
            {
                this.SearchTerm = string.Empty;
                return;
            }

            AddSearchResults(authors.Search(SearchTerm));
            AddSearchResults(books.Search(SearchTerm));
            AddSearchResults(movies.Search(SearchTerm));
            AddSearchResults(directors.Search(SearchTerm));

            Page();
        }

        private void AddSearchResults(IEnumerable<SearchViewModel> results)
        {
            this.SearchResults
                .AddRange(results
                            .Select(e => new SearchResultModel
                            {
                                Id = e.Id,
                                Result = e.SearchResult
                                .Replace(this.SearchTerm, $@"<strong class=""text-danger"">{this.SearchTerm}</strong>"),
                                Type = e.Type
                            }));
        }
    }
}