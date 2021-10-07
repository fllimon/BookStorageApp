using System;
using System.Collections.Generic;
using System.Text;

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
