using System;
using System.Collections;
using System.Collections.Generic;

public class Library : IEnumerable<Book>
{
    public Library(params Book[] books)
    {
        //Array.Sort(books, new BookComparator());
        //Array.Sort(books);
        //this.Books = new SortedSet<Book>(books);
    }

    public SortedSet<Book> Books { get; private set; } = new SortedSet<Book>();

    public IEnumerator<Book> GetEnumerator()
    {
        return new LibraryIterator(this.Books);
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

    private class LibraryIterator : IEnumerator<Book>
    {
        private IReadOnlyList<Book> books;

        private int currentIndex;

        public LibraryIterator(IEnumerable<Book> books)
        {
            this.Reset();
            this.books = new List<Book>(books);
        }

        public Book Current => this.books[currentIndex];

        object IEnumerator.Current => this.Current;

        public void Dispose() { }

        public bool MoveNext() => ++currentIndex < this.books.Count;

        public void Reset() => this.currentIndex = -1;
    }
}

