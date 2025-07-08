using QuantumBookstore.Entities;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumBookstore.ServicesNotImplemented
{
    internal static class MailService
    {
        public static bool SendEbookWithMailService(Book book, string address, int quantity, decimal totalPrice)
        {
            // ........... No Implementation Just now

            Console.WriteLine($"Ebook '{book.Title}' Sended To Mail Service But Not Implemented");
            return true;
        }
    }
}
