namespace LibraryManagement.Entities
{
    public class Book
    {
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public int quantity { get; set; } // all books (books in stock + books borrowed)
        public int stock { get; set; } // books in stock
    }
}
