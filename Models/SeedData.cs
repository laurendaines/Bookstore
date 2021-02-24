﻿using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                        Author = "Victor Hugo", 
                        Publisher = "Signet", 
                        ISBN = "978-0451419439", 
                        Category = "Fiction, Classic", 
                        Price = 9.95
                    }
                );
                context.Books.AddRange(
                  new Book
                  {
                      BookID = 2,
                      Title = "Team of Rivals",
                      Author = "Doris Kearns Goodwin",
                      Publisher = "Simon & Schuster",
                      ISBN = "978-0743270755",
                      Category = "Non-Fiction, Biography",
                      Price = 14.58
                  }
              );
                context.Books.AddRange(
                  new Book
                  {
                      BookID = 3,
                      Title = "The Snowball",
                      Author = "Alice Schroeder",
                      Publisher = "Bantam",
                      ISBN = "978-0553384611",
                      Category = "Non-Fiction, Biography",
                      Price = 21.54
                  }
                );
                context.Books.AddRange(
                  new Book
                  {
                      BookID = 4,
                      Title = "American Ulysses",
                      Author = "Ronald C. White",
                      Publisher = "Random House",
                      ISBN = "978-0812981254",
                      Category = "Non-Fiction, Biography",
                      Price = 11.61
                  }
                );
                context.Books.AddRange(
                  new Book
                  {
                      BookID = 5,
                      Title = "Unbroken",
                      Author = "Laura Hillenbrand",
                      Publisher = "Random House",
                      ISBN = "978-0812974492",
                      Category = "Non-Fiction, Historical",
                      Price = 13.33
                  }
                );
                context.Books.AddRange(
                    new Book
                    {
                        BookID = 6,
                        Title = "The Great Train Robbery",
                        Author = "Michael Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Category = "Fiction, Historical Fiction",
                        Price = 15.95
                    }
                );
                context.Books.AddRange(
                    new Book
                    {
                        BookID = 7,
                        Title = "Deep Work",
                        Author = "Cal Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Category = "Non-Fiction, Self-Help",
                        Price = 14.99
                    }
                );
                context.Books.AddRange(
                    new Book
                    {
                        BookID = 8,
                        Title = "It's Your Ship",
                        Author = "Michael Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Category = "Non-Fiction, Self-Help",
                        Price = 21.66
                    }
                );
                context.Books.AddRange(
                    new Book
                    {
                        BookID = 9,
                        Title = "The Virgin Way",
                        Author = "Richard Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Category = "Non-Fiction, Business",
                        Price = 29.16
                    }
                );
                context.Books.AddRange(
                    new Book
                    {
                        BookID = 10,
                        Title = "Sycamore Row",
                        Author = "John Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Category = "Fiction, Thrillers",
                        Price = 15.03
                    }
                );
            }
        }
    }
}
