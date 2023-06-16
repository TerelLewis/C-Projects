// Name: Terel Lewis
// Date: 4/21/2023
// Application Description: BookException Demo 

using System;
using static System.Console;
using BookExceptionLibrary;

namespace BookExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create books with some prices that exceed 10 cents per page
            Book book1 = new Book("The Magic of Thinking Big","David J. Schwartz", 11.99m, 228);
            Book book2 = new Book("Think and Grow Rich", "Napoleon Hill", 5.89m, 238);
            Book book3 = new Book("How to Win Friends and Influence People", "Dale Carnegie", 14.99m, 291);
            Book book4 = new Book("Acres of Diamonds", "Russell Conwell", 10.99m, 124);

            // create book array
            Book[] books = { book1, book2, book3, book4 };

            foreach (Book book in books)
            {
                WriteLine($"Creating book: {book.Title} by {book.Author}, {book.NumberOfPages} pages, ${book.Price}");

                // Calculate the price per page
                decimal pricePerPage = book.Price / book.NumberOfPages;

                // Check if the price per page exceeds 10 cents
                try
                {
                    CheckBookPricePerPage(book);
                    WriteLine($"Created book: {book}");
                }
                catch (BookException ex)
                {
                    WriteLine($"Error: {ex.Message}");
                }
            }
            WriteLine("Press any key to exit...");
            ReadKey();
        }

       public static void CheckBookPricePerPage(Book book)
       {
            decimal pricePerPage = book.Price / book.NumberOfPages;
            if (pricePerPage > 0.1m)
            {
                throw new BookException($"The price per page ${pricePerPage} exceeds the limit of $0.10.");
            }
        }
    }
}













