using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using LibraryManagement.Entities;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace LibraryManagement.DataAccess
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserBooks> UserBooks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=librarydb;Username=postgres;Password=YOUR_PASSWORD");
            // Replace YOUR_PASSWORD with your actual PostgreSQL password
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserBooks>().ToTable("UserBooks");
            modelBuilder.Entity<UserBooks>().Property(ub => ub.user_id).HasColumnName("user_id");
            modelBuilder.Entity<UserBooks>().Property(ub => ub.book_id).HasColumnName("book_id");
            modelBuilder.Entity<UserBooks>().Property(ub => ub.borrowed_at).HasColumnName("borrowed_at");
            modelBuilder.Entity<UserBooks>().Property(ub => ub.returned_at).HasColumnName("returned_at");

            modelBuilder.Entity<UserBooks>()
                .HasOne(ub => ub.book)
                .WithMany()
                .HasForeignKey(ub => ub.book_id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserBooks>()
                .HasOne(ub => ub.user)
                .WithMany()
                .HasForeignKey(ub => ub.user_id)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
