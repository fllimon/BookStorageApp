using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;


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
            bool isDeleted = false;

            if (someBook == null)
            {
                return isDeleted;
            }

            IEnumerable<Book> books = _fManager.GetBooksFromFile();

            foreach (Book book in books)
            {
                if (CompareTo(book, someBook))
                {
                    _books.Remove(someBook);
                    _fManager.WriteRecordInFile(_books);
                    
                    isDeleted = true;

                    break;
                }
            }

            return isDeleted;
        }

        public IEnumerable<Book> GetBooks()
        {
            return _fManager.GetBooksFromFile();
        }

        public bool UpdateBookByTitle(Book oldBook, Book newBook)
        {
            bool isUpdated = false;

            if (oldBook == null)
            {
                return isUpdated;
            }

            if (newBook == null)
            {
                return isUpdated;
            }

            IEnumerable<Book> books = _fManager.GetBooksFromFile();

            foreach (Book book in books)
            {
                if (book.Title == oldBook.Title)
                {
                    _books.Remove(oldBook);

                    _books.Add(newBook);
                    _fManager.WriteRecordInFile(_books);
                    isUpdated = true;

                    break;
                }
            }

            return isUpdated;
        }

        private bool CompareTo([AllowNull] Book x, [AllowNull] Book y)
        {
            bool isEqual = false;

            if ((x.Title == y.Title) && (x.Description == y.Description) &&
                (x.Author == y.Author) && (x.Price == y.Price) && (x.Year == y.Year))
            {
                return isEqual = true;
            }

            return isEqual;
        }
    }
}
