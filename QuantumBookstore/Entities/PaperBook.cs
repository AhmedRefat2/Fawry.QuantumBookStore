using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumBookstore.Entities
{
    internal class PaperBook : Book
    {

        public int CurrentStock { get; private set; } // Number of books in stock
        public PaperBook(string iSBN, string title, int publishedYear, decimal price, int currentStock) 
            : base(iSBN, title, publishedYear, price)
        {
            if (currentStock < 0)
                throw new ArgumentException("Current stock cannot be negative.");
            CurrentStock = currentStock;
        }

        public void UpdateStock(int newStock)
        {
            if (newStock < 0)
                throw new ArgumentException("Stock cannot be negative.");
            CurrentStock = newStock;
        }

        public override bool IsForSale => CurrentStock > 0; // To Handle IsforSale With No Copies of This Book

    }
}
