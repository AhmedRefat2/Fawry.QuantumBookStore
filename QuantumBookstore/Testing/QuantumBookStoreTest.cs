using QuantumBookstore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumBookstore.Testing
{
    internal static class QuantumBookStoreTest
    {
        public static BookInventory TestAdd(BookInventory inventory)
        {
            
            Console.WriteLine("Quantum book store: Starting AddBook test...");

            var paperBook = new PaperBook("123abc", "Mastering Java", 2018, 350m, 10);
            var eBook = new EBook("456efg", "LINQ Asp.NET", 2021, 200m, "PDF");
            var showcaseBook = new ShowcaseOrDemoBook("789hij", "Demo Book", 2015, 0m);

            var oldBook = new PaperBook("PB200", "Old C# Book", 2005, 100m, 5); 
            var recentBook = new EBook("EB200", "Modern C# Techniques", 2021, 250m, "EPUB");

            inventory.AddBook(paperBook);
            inventory.AddBook(eBook);
            inventory.AddBook(showcaseBook);
            inventory.AddBook(oldBook);
            inventory.AddBook(recentBook);

            Console.WriteLine("Quantum book store: Finished AddBook test.");

            return inventory;
        }


        public static void TestRemoveOutdatedBooks(BookInventory inventory)
        {
            Console.WriteLine("Quantum book store: Starting RemoveOutdatedBooks test...");

            var removed = inventory.RemoveOutdatedBooks(10);

            Console.WriteLine($"Number of books removed: {removed.Count}");

            foreach (var book in removed)
                Console.WriteLine($"Removed - {book.Title} ({book.PublishedYear})");

            Console.WriteLine("Quantum book store: Finished RemoveOutdatedBooks test.\n");
        }


        public static void TestBuyingBooks(BookInventory inventory)
        {
            Console.WriteLine("Quantum book store: Starting TestBuyingBooks...");

            try
            {
                decimal total = inventory.BuyBook("123abc", 2, "fawry1@example.com", "123 Book St."); // paper Book
                Console.WriteLine($"Paid {total:C} for PaperBook.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while buying PaperBook - {ex.Message}");
            }

       
            try
            {
                decimal total = inventory.BuyBook("456efg", 1, "fawry2@example.com", "456 st"); // Ebook
                Console.WriteLine($"Paid {total:C} for EBook.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while buying EBook - {ex.Message}");
            }

            try
            {
                inventory.BuyBook("789hij", 1, "fawry3@example.com", "notImportnat");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while buying ShowcaseBook - {ex.Message}");
            }

            Console.WriteLine("Quantum book store: Finished TestBuyingBooks.\n");
        }
    }
}
