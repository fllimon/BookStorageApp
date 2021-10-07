using System.Collections.Generic;

namespace BookStorage
{
    interface IBookStorage
    {
        public bool AddBook(Book someBook);

        public IEnumerable<Book> GetBooks();

        public bool UpdateBookByTitle(Book oldBook, Book newBook);

        public bool DeleteBook(Book someBook);
    }
}
