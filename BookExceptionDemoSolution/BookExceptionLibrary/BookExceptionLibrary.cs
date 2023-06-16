using System;



namespace BookExceptionLibrary
{
    public class Book
    {
        // Define the necessary fields for the book class
        private string title;
        private string author;
        private decimal price;
        private int numberOfPages;

        // Properties for each field
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public int NumberOfPages
        {
            get { return numberOfPages; }
            set { numberOfPages = value; }
        }



        // Constructor for the Book class that throws
        public Book(string title, string author, decimal price, int numberOfPages)
        {
            if (price / numberOfPages > 0.1M)
            {
                throw new BookException($"The price per page for {title} by {author} exceeds the limit of 10 cents.");
            }

            this.title = title;
            this.author = author;
            this.price = price;
            this.numberOfPages = numberOfPages;


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