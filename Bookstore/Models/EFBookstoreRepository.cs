using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bookstore.Models
{
    public class EFBookstoreRepository : IBookstoreRepository
    {
        private BookstoreDBContext _context;

        public EFBookstoreRepository(BookstoreDBContext context)
        {
            _context = context;
        }

        public IQueryable<Book> Books => _context.Books;         // makes the books queryable 

    }
}
