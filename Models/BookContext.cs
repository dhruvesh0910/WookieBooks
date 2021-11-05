using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WookieBooks.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options)
          : base(options)
        {
        }

        public DbSet<BookItem> BookItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BookItem>().HasData( new BookItem { Id=1, title = "Introduction to .Net Core", description = ".Net Core is one of the great plateform to implement desktop application", author = "Dhruvesh Patel", image = "Image/1.jpg", price = 104.99 });
            modelBuilder.Entity<BookItem>().HasData( new BookItem { Id=2, title = "Introduction to .Net Core", description = ".Net Core is one of the great plateform to implement desktop application", author = "Dhruvesh Patel", image = "Image/1.jpg", price = 69.99 });


        }
    }
}
