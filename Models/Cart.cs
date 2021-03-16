using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    //add item method
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();
        public virtual void AddItem (Book bo, int qty)
        {
            CartLine line = Lines
                .Where(b => b.Book.BookID == bo.BookID)
                .FirstOrDefault();
        
            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = bo,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        //remove item method
        public virtual void RemoveLine(Book bo) =>
            Lines.RemoveAll(x => x.Book.BookID == bo.BookID);

        //clear the cart contents
        public virtual void Clear() => Lines.Clear();

        //compute total sum
        public double ComputeTotalSum() => Lines.Sum(e => e.Book.Price * e.Quantity);

        //creating the cart line class
        public class CartLine
        {
            public int CartLineId { get; set; }
            public Book Book { get; set; }
            public int Quantity { get; set; }
            public long BookId { get; internal set; }
        }
    }
}
