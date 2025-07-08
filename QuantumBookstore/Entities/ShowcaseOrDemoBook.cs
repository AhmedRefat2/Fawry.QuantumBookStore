using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumBookstore.Entities
{
    internal class ShowcaseOrDemoBook : Book
    {

        public ShowcaseOrDemoBook(string iSBN, string title, int publishedYear, decimal price) : base(iSBN, title, publishedYear, price)
        {

        }

        public override bool IsForSale => false;
    }
}
