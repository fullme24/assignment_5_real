using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignment_5_real.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public virtual void AddItem (Libro book, int quantity)
        {
            CartLine line = Lines.Where(l => l.Libro.BookID == book.BookID)
                .FirstOrDefault();
             
            if (line == null)
            {
                Lines.Add(new CartLine
                    {
                    Libro = book,
                    Quantity = quantity
                    });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public virtual void RemoveLine(Libro book)
        {
            Console.WriteLine(Lines.Count());

            Lines.RemoveAll(x => x.Libro.BookID == book.BookID);

            Console.WriteLine(Lines.Count());

            Console.WriteLine(Lines);
        }

        public virtual void Clear() => Lines.Clear();

        public decimal ComputeTotalSum() =>
            Lines.Sum(e => Convert.ToDecimal(e.Libro.BPrice * e.Quantity));

        public class CartLine
        {
            public int CartLineID { get; set; }
            public Libro Libro { get; set; }
            public int Quantity { get; set; }
        }
    }
}
