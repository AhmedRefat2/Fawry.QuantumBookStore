using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumBookstore.Entities
{
    internal abstract class Book
    {

        public string ISBN { get; }
        public string Title { get; }
        public int PublishedYear { get; }
        public decimal Price { get; private set; }
        public Book(string iSBN, string title, int publishedYear, decimal price)
        {
            ISBN = iSBN;
            Title = title;
            PublishedYear = publishedYear;
            Price = price;
        }

        public void UpdatePrice(decimal newPrice)
        {
            if (newPrice < 0)
            {
                throw new ArgumentException("Price cannot be negative.");
            }
            Price = newPrice;
        }

        public virtual bool IsForSale => true;

    }
}
