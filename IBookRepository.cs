using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WookieBooks.Models;

namespace WookieBooks
{
    interface IBookRepository
    {
        IEnumerable<BookItem> GetBooks();
        BookItem GetBookItemByID(int Id);
        void InsertBook(BookItem book);
        void DeleteBookItem(int Id);
        void UpdateBookItem(BookItem book);
        void Save();
    }
}
