using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Entities
{
    [Table("UserBooks")]
    public class UserBooks
    {
        public int id { get; set; }

        [Column("user_id")]
        public int user_id { get; set; }

        [Column("book_id")]
        public int book_id { get; set; }

        [Column("borrowed_at")]
        public DateTime borrowed_at { get; set; }

        [Column("returned_at")]
        public DateTime? returned_at { get; set; }

        public User user { get; set; }
        public Book book { get; set; }
    }
}
