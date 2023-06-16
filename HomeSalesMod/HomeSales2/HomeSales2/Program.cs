// Name: Terel Lewis
// Date: 4/2/2023
// Application Description: Creating a console application that saves salesperson data.

using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HomeSales2
{
    static void Main()
    {
        // Initialize arrays for salesperson names, allowed initials, and accumulated sales values
        string[] names = { "Danielle", "Edward", "Francis" };
        char[] initials = { 'D', 'E', 'F' };
        double[] sales = new double[3];

        // Loop until user enters "Z" for salesperson initial
        char initial;
        do
        {
            // Prompt user for salesperson initial and amount of sale
            Write("Enter salesperson initial (D, E, F, or Z): ");
            initial = Char.ToUpper(ReadKey().KeyChar); // Convert to uppercase
            WriteLine();

            if (initial != 'D' && initial != 'E' && initial != 'F' && initial != 'Z')
            {
                WriteLine("Invalid initial. Please try again.");
                continue;
            }

            if (initial != 'Z')
            {
                Write("Enter amount of sale: ");
                double amount = Double.Parse(ReadLine());

                // Update running total for the corresponding salesperson
                int index = Array.IndexOf(initials, initial);
                sales[index] += amount;
            }

        } while (initial != 'Z');

        // Display results
        for (int i = 0; i < names.Length; i++)
        {
            WriteLine("Total sales for {0}: {1:C}", names[i], sales[i]);
        }

        double grandTotal = 0.0;
        for (int i = 0; i < sales.Length; i++)
        {
            grandTotal += sales[i];
        }
        WriteLine("Grand total for all salespersons: {0:C}", grandTotal);

        // Determine salesperson with highest amount sold
        int highestIndex = Array.IndexOf(sales, sales.Max());
        WriteLine("Salesperson with highest amount sold: {0} ({1:C})", names[highestIndex], sales[highestIndex]);

        // Wait for user to press a key before closing the console window
        ReadKey();
    }
}
