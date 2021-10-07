using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BookStorage
{
    class BookStorage : IBookStorage
    {
        private readonly FileManager _fManager;
        public BookStorage()
        {
            _fManager = new FileManager();
        }

        public bool AddBook(Book someBook)
        {
            bool isAddBook = false;

            if (someBook == null)
            {
                return isAddBook;
            }

            _fManager.WriteRecordInFile(someBook);

            return isAddBook = true;
        }

        public bool DeleteBook(Book someBook)
        {
            throw new NotImplementedException();
        }

        public Book GetBooks()
        {
            return _fManager.GetBooksFromFile();
        }

        public bool UpdateBook(Book someBook)
        {
            throw new NotImplementedException();
        }
    }
}
