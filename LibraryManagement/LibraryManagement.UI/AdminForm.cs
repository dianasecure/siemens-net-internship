using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.BusinessLogic;
using LibraryManagement.Entities;


namespace LibraryManagement.UI
{
    public partial class AdminForm : Form
    {
        private readonly BookService _bookService = new BookService();
        public AdminForm()
        {
            InitializeComponent();
        }

        private void LoadBooks()
        {
            var books = _bookService.GetAllBooks();
            Books.DataSource = books;
        }

        private void Books_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addBook_Click(object sender, EventArgs e)
        {
            var book = new Book
            {
                title = title.Text,
                author = author.Text,
                stock = int.Parse(stock.Text),
                quantity = int.Parse(stock.Text)
            };

            _bookService.AddBook(book);
            LoadBooks();

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string title = byTitle.Text;
            string author = byAuthor.Text; 
            var results = _bookService.SearchBooks(title, author);
            Books.DataSource = results;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // delete
            if (Books.SelectedRows.Count > 0)
            {
                int id = (int)Books.SelectedRows[0].Cells["Id"].Value;
                _bookService.DeleteBook(id);
                MessageBox.Show("Book deleted.");
                LoadBooks();
            }
        }
    }
}
