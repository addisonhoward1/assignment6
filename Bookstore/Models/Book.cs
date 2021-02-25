using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Bookstore.Models
{
    public class Book
    {
        // all the variables and key/
        [Key]
        // since BookId is a key it autoincrements 
        public int BookId { get; set; }

        [Required]
        // makes sure format of ISBN is entered correctly
        [RegularExpression("^[0-9]{3}-[0-9]{10}$", ErrorMessage = "Please enter a valid ISBN number in format the of 10 or 13 digits")]
        public string ISBN { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string AuthorFirstName { get; set; }

        [Required]
        public string AuthorLastName { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        public int Pagenum { get; set; }

        [Required]
        public string Classification { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        // user must enter the price in the correct 00.00 format
        [DataType(DataType.Currency, ErrorMessage = "Please enter a valid monetary value")]
        public double Price { get; set; }
    }
}
