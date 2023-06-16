// Name: Terel Lewis
// Date: 4/21/2023
// Application Description: BookException Demo 

using System;
using static System.Console;
using BookExceptionLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExceptionDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[5];

            for (int i = 0; i < books.Length; i++)
            {
                WriteLine($"Enter information for book {i + 1}:");
                Write("Title: ");
                string title = ReadLine();
                Write("Author: ");
                string author = ReadLine();
                Write("Price: ");
                decimal price;
                if (!decimal.TryParse(ReadLine(), out price))
                {
                    price = 0.1M * int.MaxValue; // set price to maximum if input is invalid
                }
                Write("Number of pages: ");
                int numPages;
                if (!int.TryParse(ReadLine(), out numPages))
                {
                    numPages = int.MaxValue; // set numPages to maximum if input is invalid
                }

                try
                {
                    books[i] = new Book(title, author, price, numPages);
                }
                catch (BookException e)
                {
                    WriteLine($"Error: {e.Message}");
                    WriteLine($"Setting price to maximum allowed value.");
                    books[i] = new Book(title, author, 0.1M * numPages, numPages); // set price to maximum allowed value
                }

                WriteLine();
            }

            WriteLine("Entered and corrected book information:");
            for (int i = 0; i < books.Length; i++)
            {
                WriteLine($"Book {i + 1}:");
                WriteLine($"Title: {books[i].Title}");
                WriteLine($"Author: {books[i].Author}");
                WriteLine($"Price: {books[i].Price:C}");
                WriteLine($"Number of pages: {books[i].NumberOfPages}");
                WriteLine();
            }
        }
    }
}
