using QuantumBookstore.Entities;
using QuantumBookstore.Errors;
using QuantumBookstore.ServicesNotImplemented;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumBookstore
{
    internal class BookInventory
    {
        private readonly Dictionary<string, Book> books = [];


        // 1. AddBook
        public void AddBook(Book book)
        {
            if (books.ContainsKey(book.ISBN))
                Console.WriteLine("This book already exists in the inventory");

            books.Add(book.ISBN, book);
            Console.WriteLine($"Book '{book.Title}' added to inventory.");
        }


        // 2. Remove outdatedBooks and return it 
        public List<Book> RemoveOutdatedBooks(int maxNumberOfYears)
        {
            int currentYear = DateTime.Now.Year;
            var outdatedBooks = books.Values
                .Where(book => (currentYear - book.PublishedYear) > maxNumberOfYears)
                .ToList();

            foreach (var book in outdatedBooks)
            {
                books.Remove(book.ISBN);
                Console.WriteLine($"Removed outdated book '{book.Title}'.");
            }

            return outdatedBooks;
        }


        // 3. Buy Book
        public decimal BuyBook(string isbn, int quantity, string email, string address)
        {
            if (!books.TryGetValue(isbn, out Book? book))
                throw new BookNotFoundException(isbn);

            if (!book.IsForSale)
                throw new InvalidOperationException("This book is not for sale.");

            decimal totalPrice = book.Price * quantity;

            if (book is PaperBook paper)
            {
                if (paper.CurrentStock < quantity)
                    throw new BookOutOfStockException(isbn);

                paper.UpdateStock(paper.CurrentStock - quantity);
                ShippingService.SendPaperbookWithShippingService(book, address, quantity, totalPrice);
            }
            else if (book is EBook eBook)
                MailService.SendEbookWithMailService(book, address, quantity, totalPrice);
            else
                throw new InvalidOperationException("Unsupported book type.");

            Console.WriteLine($"Book '{book.Title}' bought successfully. Total paid: {totalPrice:C}");
            return totalPrice;
        }

    }
}
