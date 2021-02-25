using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

//Model to call information stored about the books listed on the website
namespace Bookstore.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{10})$", ErrorMessage = "Please enter a valid ISBN")]
        public string ISBN { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }

    }
}
