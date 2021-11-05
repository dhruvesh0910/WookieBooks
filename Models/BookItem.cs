using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WookieBooks.Models
{
    public class BookItem
    {
        public long Id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string author { get; set; }
        public string image { get; set; }
        public double price { get; set; }
    }
}
