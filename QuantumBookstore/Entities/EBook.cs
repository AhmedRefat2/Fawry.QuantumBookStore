using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumBookstore.Entities
{
    internal class EBook : Book
    {
        public string FileType { get; }

        public EBook(string isbn, string title, int publishedYear, decimal price, string fileType)
            : base(isbn, title, publishedYear, price)
        {
            if (string.IsNullOrWhiteSpace(fileType))
                throw new ArgumentException("FileType is required.");
            FileType = fileType;
        }

    }
}
