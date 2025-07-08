using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumBookstore.Errors
{
    internal class BookNotFoundException : Exception
    {
        public BookNotFoundException(string isbn)
            : base($"Book with ISBN '{isbn}' was not found.")
        {

        }
    }
}
