using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BookStorage
{
    class BookStorage : IBookStorage
    {
        public bool AddBook(Book someBook)
        {
            bool isAddBook = false;

            if (someBook == null)
            {
                return isAddBook;
            }

            FileManager fManager = new FileManager();

            fManager.WriteRecordInFile(someBook);

            return isAddBook = true;
        }

        public bool DeleteBook(Book someBook)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public bool UpdateBook(Book someBook)
        {
            throw new NotImplementedException();
        }
    }
}
