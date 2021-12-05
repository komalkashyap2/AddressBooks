using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBooks
{
      class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book System!");
            AddressBooks.AddrBook.GetCustomer();
            AddressBooks.AddrBook.Modify();
            AddressBooks.AddrBook.ListingPeople();

        }
    }
}
