using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WookieBooks.Models;

namespace WookieBooks
{
    public class BookRepository : IBookRepository
    {
        private BookContext context;

        public BookRepository(BookContext context)
        {
            this.context = context;
        }

        
        public void DeleteBookItem(int Id)
        {
            BookItem bookItem = context.BookItems.Find(Id);
            context.BookItems.Remove(bookItem);
        }

        public BookItem GetBookItemByID(int Id)
        {
            return context.BookItems.Find(Id);
        }

        public IEnumerable<BookItem> GetBooks()
        {
            return context.BookItems.ToList();
        }

        public void InsertBook(BookItem book)
        {
            context.BookItems.Add(book);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateBookItem(BookItem book)
        {
            context.Entry(book).State = EntityState.Modified;
        }
    }
}
