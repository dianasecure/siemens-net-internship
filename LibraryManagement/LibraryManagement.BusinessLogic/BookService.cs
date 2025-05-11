using LibraryManagement.DataAccess;
using LibraryManagement.Entities;

namespace LibraryManagement.BusinessLogic
{
    public class BookService
    {
        private readonly BookRepository _repository;

        public BookService()
        {
            _repository = new BookRepository();
        }

        public List<Book> GetAllBooks()
        {
            return _repository.GetAllBooks();
        }

        public void AddBook(Book book)
        {
            _repository.AddBook(book);
        }

        public void UpdateBook(Book book)
        {
            _repository.UpdateBook(book);
        }

        public void DeleteBook(int bookId)
        {
            _repository.DeleteBook(bookId);
        }

        public List<Book> SearchBooks(string title = null, string author = null)
        {
            return _repository.SearchBooks(title, author);
        }

        public bool BorrowBook(int bookId)
        {
            var book = _repository.GetBookById(bookId);
            if (book == null || book.quantity <= 0)
                return false;

            book.quantity -= 1;
            _repository.UpdateBook(book);
            return true;
        }

        public bool ReturnBook(int bookId)
        {
            var book = _repository.GetBookById(bookId);
            if (book == null || book.quantity >= book.stock)
                return false;

            book.quantity += 1;
            _repository.UpdateBook(book);
            return true;
        }

    }
}
