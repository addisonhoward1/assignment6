﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

// this cs file fills the database with seed data and checks for migrations

namespace Bookstore.Models
{
    public class SeedDatabase
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            BookstoreDBContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookstoreDBContext>();

            // checks to see if there is any pending migrations 
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            // if there is is not any information in the database then use the seed data below
            if (!context.Books.Any())
            {
                //Bookid's are not defined here since it is the key
                context.Books.AddRange(
                    new Book //Book #1
                    {
                        Title = "Les Miserables",
                        AuthorFirstName = "Victor",
                        AuthorLastName = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95,
                        Pagenum = 1488

                    },
                    new Book //Book 2
                    {
                        Title = "Team of Rivals",
                        AuthorFirstName = "Doris Kearns",
                        AuthorLastName = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58,
                        Pagenum = 944
                    },
                    new Book //Book 3
                    {
                        Title = "The Snowball",
                        AuthorFirstName = "Alice",
                        AuthorLastName = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54,
                        Pagenum = 832
                    },
                    new Book //Book 4
                    {
                        Title = "American Ulysses",
                        AuthorFirstName = "Ronald C.",
                        AuthorLastName = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61,
                        Pagenum = 864

                    },
                    new Book //Book 5
                    {
                        Title = "Unbroken",
                        AuthorFirstName = "Laura",
                        AuthorLastName = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33,
                        Pagenum = 528

                    },
                    new Book //Book 6
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirstName = "Michael",
                        AuthorLastName = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95,
                        Pagenum = 288

                    },
                    new Book //Book 7
                    {
                        Title = "Deep Work",
                        AuthorFirstName = "Cal",
                        AuthorLastName = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99,
                        Pagenum = 304

                    },
                    new Book //Book 8
                    {
                        Title = "It's Your Ship",
                        AuthorFirstName = "Michael",
                        AuthorLastName = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 21.66,
                        Pagenum = 240
                    },
                    new Book //Book 9
                    {
                        Title = "The Virgin Way",
                        AuthorFirstName = "Richard",
                        AuthorLastName = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16,
                        Pagenum = 400
                    },
                    new Book //Book 10
                    {
                        Title = "Sycamore Row",
                        AuthorFirstName = "John",
                        AuthorLastName = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = 15.03,
                        Pagenum = 642
                    },
                    new Book //Book 11
                    {
                        Title = "The Book Of Mormon",
                        AuthorFirstName = "Moroni",
                        AuthorLastName = "The Prophet",
                        Publisher = "Church Of Jesus Christ",
                        ISBN = "978-0385513166",
                        Classification = "Sacred-Text",
                        Category = "Historical",
                        Price = 5.75,
                        Pagenum = 772
                    },
                    new Book //Book 12
                    {
                        Title = "Grace Where You Are",
                        AuthorFirstName = "Emily Belle",
                        AuthorLastName = "Freeman",
                        Publisher = "Desert Book",
                        ISBN = "978-1629727271",
                        Classification = "Grace (Doctrines)",
                        Category = "Religious",
                        Price = 13.99,
                        Pagenum = 122
                    },
                    new Book //Book 13
                    {
                        Title = "Divine Signatures",
                        AuthorFirstName = "Gerald N.",
                        AuthorLastName = "Lund",
                        Publisher = "Desert Book",
                        ISBN = "978-1606419274",
                        Classification = "God",
                        Category = "Religious",
                        Price = 25.16,
                        Pagenum = 320
                    }
                );
                context.SaveChanges(); // needed to save the information to database
            }
        }
    }
}
