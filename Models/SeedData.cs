using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Pre-loads the database with base information
namespace Bookstore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BookstoreDBContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookstoreDBContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if(!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        BookID = 1,
                        Title = "Les Miserables",
                        AuthorFirstName = "Victor",
                        AuthorLastName = "Hugo",
                        Publisher = "Signet", 
                        ISBN = "978-0451419439", 
                        Category = "Fiction, Classic", 
                        Price = 9.95,
                        Pages = 1488
                    }
                );
                context.Books.AddRange(
                  new Book
                  {
                      BookID = 2,
                      Title = "Team of Rivals",
                      AuthorFirstName = "Doris Kearns",
                      AuthorLastName = "Goodwin",
                      Publisher = "Simon & Schuster",
                      ISBN = "978-0743270755",
                      Category = "Non-Fiction, Biography",
                      Price = 14.58,
                      Pages = 944
                  }
              );
                context.Books.AddRange(
                  new Book
                  {
                      BookID = 3,
                      Title = "The Snowball",
                      AuthorFirstName = "Alice",
                      AuthorLastName = "Schroeder",
                      Publisher = "Bantam",
                      ISBN = "978-0553384611",
                      Category = "Non-Fiction, Biography",
                      Price = 21.54,
                      Pages = 832
                  }
                );
                context.Books.AddRange(
                  new Book
                  {
                      BookID = 4,
                      Title = "American Ulysses",
                      AuthorFirstName = "Ronald C.",
                      AuthorLastName = "White",
                      Publisher = "Random House",
                      ISBN = "978-0812981254",
                      Category = "Non-Fiction, Biography",
                      Price = 11.61,
                      Pages = 864
                  }
                );
                context.Books.AddRange(
                  new Book
                  {
                      BookID = 5,
                      Title = "Unbroken",
                      AuthorFirstName = "Laura",
                      AuthorLastName = "Hillenbrand",
                      Publisher = "Random House",
                      ISBN = "978-0812974492",
                      Category = "Non-Fiction, Historical",
                      Price = 13.33,
                      Pages = 528
                  }
                );
                context.Books.AddRange(
                    new Book
                    {
                        BookID = 6,
                        Title = "The Great Train Robbery",
                        AuthorFirstName = "Michael",
                        AuthorLastName = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Category = "Fiction, Historical Fiction",
                        Price = 15.95,
                        Pages = 288
                    }
                );
                context.Books.AddRange(
                    new Book
                    {
                        BookID = 7,
                        Title = "Deep Work",
                        AuthorFirstName = "Cal",
                        AuthorLastName = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Category = "Non-Fiction, Self-Help",
                        Price = 14.99,
                        Pages = 304
                    }
                );
                context.Books.AddRange(
                    new Book
                    {
                        BookID = 8,
                        Title = "It's Your Ship",
                        AuthorFirstName = "Michael",
                        AuthorLastName = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Category = "Non-Fiction, Self-Help",
                        Price = 21.66,
                        Pages = 240
                    }
                );
                context.Books.AddRange(
                    new Book
                    {
                        BookID = 9,
                        Title = "The Virgin Way",
                        AuthorFirstName = "Richard",
                        AuthorLastName = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Category = "Non-Fiction, Business",
                        Price = 29.16,
                        Pages = 400
                    }
                );
                context.Books.AddRange(
                    new Book
                    {
                        BookID = 10,
                        Title = "Sycamore Row",
                        AuthorFirstName = "John",
                        AuthorLastName = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Category = "Fiction, Thrillers",
                        Price = 15.03,
                        Pages = 642
                    }
                );
                context.Books.AddRange(
                    new Book
                    {
                        BookID = 11,
                        Title = "12 Rules for Life: An Antidote to Chaos",
                        AuthorFirstName = "Jordan B.",
                        AuthorLastName = "Thoreau",
                        Publisher = "Random House",
                        ISBN = "978-0345816023",
                        Category = "Non-Fiction, Self-Help",
                        Price = 16.00,
                        Pages = 448
                    }
                ); 
                context.Books.AddRange(
                     new Book
                     {
                         BookID = 12,
                         Title = "Far From the Madding Crowd",
                         AuthorFirstName = "Thomas",
                         AuthorLastName = "Harding",
                         Publisher = "Penguin",
                         ISBN = "978-0141439655",
                         Category = "Fiction, Classic",
                         Price = 8.99,
                         Pages = 464
                     }
                 ); 
                context.Books.AddRange(
                     new Book
                     {
                         BookID = 13,
                         Title = "Walden",
                         AuthorFirstName = "Henry David",
                         AuthorLastName = "Thoreau",
                         Publisher = "Beacon Press",
                         ISBN = "978-1619493919",
                         Category = "Memoir, Classic",
                         Price = 11.37,
                         Pages = 262
                     }
                 );
                context.SaveChanges();
            }
        }
    }
}
