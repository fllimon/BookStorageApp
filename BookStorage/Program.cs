using System;

namespace BookStorage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Math", "school book", "Unknown Author", 700, "12.09.2008");
            Book book2 = new Book("History", "school book", "В.В Васильев", 500, "16.10.2000");
            BookStorage storage = new BookStorage();

            //storage.AddBook(book);
            //storage.AddBook(book2);

            var data = storage.GetAllBooks();

            Console.ReadKey();
        }
    }
}
