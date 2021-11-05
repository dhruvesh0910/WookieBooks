using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WookieBooks.Models;

namespace WookieBooks.Data
{
    public class DbInitializer
    {
        public static void Initialize(BookContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.BookItems.Any())
            {
                return;   // DB has been seeded
            }


            var books = new BookItem[]
           {
                new BookItem{title="Introduction to .Net Core", description=".Net Core is one of the great plateform to implement desktop application", author="Dhruvesh Patel" , image="Image/1.jpg", price=104.99},
                new BookItem{title="Introduction to .Net Core", description=".Net Core is one of the great plateform to implement desktop application", author="Dhruvesh Patel" , image="Image/1.jpg", price=69.99},

           };
            foreach (BookItem book in books)
            {
                context.BookItems.Add(book);
            }
            context.SaveChanges();
        }
        }
    }
