using System;
using System.Collections.Generic;
using System.Text;

namespace BookStorage
{
    interface IBookStorage
    {
        public bool AddBook(Book someBook);

        public Book GetBook();

        public bool UpdateBook(Book someBook);

        public bool DeleteBook(Book someBook);
    }
}
