using LibraryManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DataAccess
{
    public class UserRepository
    {
        public void AddUser(User user)
        {
            using var context = new LibraryContext();
            context.Users.Add(user);
            context.SaveChanges();
        }

        public List<Book> GetBorrowedBooks(int userId)
        {
            using var context = new LibraryContext();
            return context.UserBooks
                .Where(ub => ub.user_id == userId && ub.returned_at == null)
                .Select(ub => ub.book)
                .ToList();
        }

        public void RecordBorrow(int userId, int bookId)
        {
            using var context = new LibraryContext();
            context.UserBooks.Add(new UserBooks
            {
                user_id = userId,
                book_id = bookId,
                borrowed_at = DateTime.UtcNow
            });
            context.SaveChanges();
        }

        public void RecordReturn(int userId, int bookId)
        {
            using var context = new LibraryContext();
            var userBook = context.UserBooks
                .FirstOrDefault(ub => ub.user_id == userId && ub.book_id == bookId && ub.returned_at == null);

            if (userBook != null)
            {
                userBook.returned_at = DateTime.UtcNow;
                context.SaveChanges();
            }
        }

        public User GetUser(string name, string surname)
        {
            using var context = new LibraryContext();
            return context.Users
                .FirstOrDefault(u => u.name == name && u.surname == surname);
        }

    }
}
