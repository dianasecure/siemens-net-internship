using LibraryManagement.BusinessLogic;
using LibraryManagement.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.UI
{
    public partial class UserForm : Form
    {
        private readonly BookService _bookService = new BookService();
        private readonly UserService _userService = new UserService();
        private readonly User _currentUser;

        public UserForm(User currentUser)
        {
            _currentUser = currentUser;
            InitializeComponent();
            LoadAvailableBooks();
            LoadBorrowedBooks();
        }

        private void LoadAvailableBooks()
        {
            // books not borrowed or not yet returned by this user
            var availableBooks = _bookService.GetAllBooks()
                .Where(b => !_userService.GetBorrowedBooks(_currentUser.id).Any(ub => ub.id == b.id))
                .ToList();
            Books.DataSource = availableBooks;
        }

        private void LoadBorrowedBooks()
        {
            // books borrowed and not yet returned
            var borrowedBooks = _userService.GetBorrowedBooks(_currentUser.id);
            dataGridView1.DataSource = borrowedBooks;
        }


        private void Books_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string title = textBox2.Text;
            string author = textBox3.Text;
            var results = _bookService.SearchBooks(title, author);
            Books.DataSource = results;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            if (Books.CurrentRow?.DataBoundItem is Book selectedBook)
            {
                bool success = _userService.BorrowBook(_currentUser.id, selectedBook.id);
                if (success)
                {
                    MessageBox.Show("Book borrowed!");
                    LoadAvailableBooks();
                    LoadBorrowedBooks();
                }
                else
                {
                    MessageBox.Show("Could not borrow book.");
                }
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Book selectedBook)
            {
                bool success = _userService.ReturnBook(_currentUser.id, selectedBook.id);
                if (success)
                {
                    MessageBox.Show("Book returned!");
                    LoadAvailableBooks();
                    LoadBorrowedBooks();
                }
                else
                {
                    MessageBox.Show("Could not return book.");
                }
            }
        }

    }
}
