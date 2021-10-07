using System;

namespace BookStorage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Math", "school book", "Unknown Author", 700, "12.09.2008");
            Book book2 = new Book("History", "school book", "В.В Васильев", 500, "16.10.2000");
            Book book3 = new Book("History", "school book", "A.A Васильев", 700, "16.10.2010");

            IBookStorage storage = new BookStorage();

            storage.AddBook(book);
            storage.AddBook(book2);

            //bool result = storage.DeleteBook(book3);

            bool result2 = storage.UpdateBookByTitle(book2, book3);
            //var data = storage.GetBooks();

            Console.ReadKey();
        }
    }
}
