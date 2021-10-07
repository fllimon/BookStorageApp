using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BookStorage
{
    class BookStorage : IBookStorage
    {
        private readonly FileManager _fManager;
        private IList<Book> _books;

        public BookStorage()
        {
            _fManager = new FileManager();
            _books = new List<Book>();
        }

        public bool AddBook(Book someBook)
        {
            bool isAddBook = false;

            if (someBook == null)
            {
                return isAddBook;
            }

            _books.Add(someBook);

            _fManager.WriteRecordInFile(_books);

            return isAddBook = true;
        }

        public bool DeleteBook(Book someBook)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetBooks()
        {
            return _fManager.GetBooksFromFile();
        }

        public bool UpdateBook(Book someBook)
        {
            throw new NotImplementedException();
        }
    }
}
