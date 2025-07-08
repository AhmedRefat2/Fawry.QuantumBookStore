using QuantumBookstore.Testing;

namespace QuantumBookstore
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            var inventory = new BookInventory();
            QuantumBookStoreTest.TestAdd(inventory);
            Console.WriteLine("-----------------------");

            QuantumBookStoreTest.TestRemoveOutdatedBooks(inventory);
            Console.WriteLine("-----------------------");

            QuantumBookStoreTest.TestBuyingBooks(inventory);
            Console.WriteLine("-----------------------");
        }
    }
}
