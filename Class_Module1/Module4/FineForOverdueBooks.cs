// Name: Terel Lewis
// Date: 4/4/2023
// Application: Fine for Overdue Books

using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FineForOverdueBooks
{
    // Main method of the application
    static void Main()
    {
        int booksCheckedOut, daysOverdue;
        string inputString;

        // prompt user to ener the number of books checked out
        WriteLine("Enter the number of books checked out: ");
        inputString = ReadLine();

        // convert user input to an integer stored in booksCheckedOut
        booksCheckedOut = Convert.ToInt32(inputString);

        // prompt user to enter number of days books overdue
        WriteLine("Enter the number of days overdue: ");
        inputString = ReadLine();

        // convert user input to an integer stored in daysOverdue
        daysOverdue = Convert.ToInt32(inputString);

        // call the CalculateFine method with user input and store the result 
        double fine = CalculateFine(booksCheckedOut, daysOverdue);

        // display the library fine to the user
        WriteLine("The library fine is: {0:C}", fine);
    }
    // method that calculates the fine for overdue books
    
    public static double CalculateFine(int booksCheckedOut, int daysOverdue)
     // define constants for fines and maximum days allowed for first week fine
    {
        const double FIRST_WEEK_FINE = 0.1;
        const double ADDITIONAL_DAYS_FINE = 0.2;
        const int MAX_FIRST_WEEK = 7;

        // calculate fine based on number of books and days overdue

        double fine = 0.0;
        // if books are returned within the first week
        if (daysOverdue <= MAX_FIRST_WEEK)
        {
            // calculate fine based on first week fine rate
            fine = booksCheckedOut * daysOverdue * FIRST_WEEK_FINE;
        }
        // if books are returned after the first week of being overdue
        else
        {
            // calculate fine rate based on maximum first week fine rate 
            fine = booksCheckedOut * MAX_FIRST_WEEK * FIRST_WEEK_FINE;

            // additional fine rate for overdue days after first week
            fine += booksCheckedOut * (daysOverdue - MAX_FIRST_WEEK) * ADDITIONAL_DAYS_FINE;
        }
        // return the total fine amount
        return fine;
    }
}

