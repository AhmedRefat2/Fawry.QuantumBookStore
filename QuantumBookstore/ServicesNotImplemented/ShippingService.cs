using QuantumBookstore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumBookstore.ServicesNotImplemented
{
    internal static class ShippingService
    {

        public static bool SendPaperbookWithShippingService(Book book, string address, int quantity, decimal totalPrice)
        {
            // ........... No Implementation Just now

            Console.WriteLine($"paperBook '{ book.Title}' Sended To Shipping Service But Not Implemented");
            return true;
        }
    }
}
