using LibraryManagement.DataAccess;
using LibraryManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.BusinessLogic
{
    public class UserService
    {
        private readonly UserRepository _userRepository = new UserRepository();
        private readonly BookService _bookService = new BookService();

        public void AddUser(User user) => _userRepository.AddUser(user);

        public bool BorrowBook(int userId, int bookId)
        {
            bool success = _bookService.BorrowBook(bookId);
            if (success)
            {
                _userRepository.RecordBorrow(userId, bookId);
            }
            return success;
        }

        public bool ReturnBook(int userId, int bookId)
        {
            bool success = _bookService.ReturnBook(bookId);
            if (success)
            {
                _userRepository.RecordReturn(userId, bookId);
            }
            return success;
        }

        public List<Book> GetBorrowedBooks(int userId) => _userRepository.GetBorrowedBooks(userId);

        public User GetUser(string name, string surname)
        {
            return _userRepository.GetUser(name, surname);
        }
    }
}
