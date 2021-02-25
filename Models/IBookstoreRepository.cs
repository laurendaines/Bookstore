using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Creates repository for bookstore
namespace Bookstore.Models
{
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}
