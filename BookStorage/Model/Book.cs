using System;

namespace BookStorage
{
    class Book
    {
        public Book(string title, string description, string author, decimal price, string year)
        {
            Title = title;
            Description = description;
            Author = author;
            Price = price;
            Year = year;
        }

        public string Title { get; }

        public string Description { get; }

        public string Author { get; }

        public decimal Price { get; }

        public string Year { get; }
    }
}
