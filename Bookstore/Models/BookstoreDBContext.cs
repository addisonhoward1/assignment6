using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Models
{
    public class BookstoreDBContext : DbContext
    {
        public BookstoreDBContext(DbContextOptions<BookstoreDBContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }        // creates the books as objects from book
    }
}