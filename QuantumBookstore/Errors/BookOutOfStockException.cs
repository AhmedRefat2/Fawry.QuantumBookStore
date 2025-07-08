using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumBookstore.Errors
{
    internal class BookOutOfStockException : Exception
    {
        public BookOutOfStockException(string title)
            : base($"Not enough stock for '{title}'.")
        {

        }
    }
}
