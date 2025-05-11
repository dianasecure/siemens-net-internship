using System.Collections.Generic;
using System.Linq;
using LibraryManagement.Entities;

namespace LibraryManagement.DataAccess
{
    public class BookRepository
    {
        public List<Book> GetAllBooks()
        {
            using var context = new LibraryContext();
            return context.Books.ToList();
        }

        public void AddBook(Book book)
        {
            using var context = new LibraryContext();
            context.Books.Add(book);
            context.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            using var context = new LibraryContext();
            context.Books.Update(book);
            context.SaveChanges();
        }

        public void DeleteBook(int bookId)
        {
            using var context = new LibraryContext();
            var book = context.Books.Find(bookId);
            if (book != null)
            {
                context.Books.Remove(book);
                context.SaveChanges();
            }
        }

        public Book GetBookById(int id)
        {
            using var context = new LibraryContext();
            return context.Books.FirstOrDefault(b => b.id == id);
        }

        public List<Book> SearchBooks(string title = null, string author = null)
        {
            using var context = new LibraryContext();
            var query = context.Books.AsQueryable();

            if (!string.IsNullOrEmpty(title))
                query = query.Where(b => b.title.Contains(title));

            if (!string.IsNullOrEmpty(author))
                query = query.Where(b => b.author.Contains(author));

            return query.ToList();
        }
    }
}
