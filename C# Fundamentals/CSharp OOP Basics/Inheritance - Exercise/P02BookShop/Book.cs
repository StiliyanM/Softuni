
using System;
using System.Linq;

internal class Book
{
    private string author;
    private string title;
    private decimal price;

    public Book(string author, string title, decimal price)
    {
        this.Author = author;
        this.Title = title;
        this.Price = price;
    }

    public virtual decimal Price
    {
        get => price;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Price not valid!");

            price = value;
        }
    }

    public virtual string Title
    {
        get { return title; }
        set
        {
            if (value.Length < 3)
                throw new ArgumentException("Title not valid!");

            title = value;
        }
    }

    public virtual string Author
    {
        get { return author; }
        set
        {
            string[] parts = value.Split(' ',StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length == 2)
            {
                string secondName = parts[1];

                if (Char.IsDigit(secondName.First()))
                {
                    throw new ArgumentException("Author not valid!");
                }
            }
            this.author = value;
        }
    }



    public override string ToString()
    {
        return $"Type: {this.GetType().Name}" + Environment.NewLine +
            $"Title: {this.Title}" + Environment.NewLine +
            $"Author: {this.Author}" + Environment.NewLine +
            $"Price: {this.Price:f2}";
    }

}
