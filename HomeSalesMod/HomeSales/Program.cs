// Name: Terel Lewis
// Date: 4/2/2023
// Application Description: Creating a console application that saves salesperson data.


using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HomeSales
{
    static void Main()
    {
        // Initialize variables
        double dTotal = 0.0, eTotal = 0.0, fTotal = 0.0, grandTotal = 0.0;
        char initial;
        double amount;

        // Loop until user enters "Z" for salesperson initial
        do
        {
            // Prompt user for salesperson initial and amount of sale
            Console.Write("Enter salesperson initial (D, E, F, or Z): ");
            initial = Char.ToUpper(Console.ReadKey().KeyChar); // Convert to uppercase
            Console.WriteLine();

            // Nested loop for error handling
            while (initial != 'D' && initial != 'E' && initial != 'F' && initial != 'Z')
            {
                Console.WriteLine("Invalid initial. Please try again.");
                Console.Write("Enter salesperson initial (D, E, F, or Z): ");
                initial = Char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
            }

            if (initial != 'Z')
            {
                Console.Write("Enter amount of sale: ");
                amount = Double.Parse(Console.ReadLine());

                // Update running total for the corresponding salesperson
                switch (initial)
                {
                    case 'D':
                        dTotal += amount;
                        break;
                    case 'E':
                        eTotal += amount;
                        break;
                    case 'F':
                        fTotal += amount;
                        break;
                }

                // Update grand total
                grandTotal += amount;
            }
        } while (initial != 'Z');

        // Display results
        Console.WriteLine("Total sales for Danielle: {0:C}", dTotal);
        Console.WriteLine("Total sales for Edward: {0:C}", eTotal);
        Console.WriteLine("Total sales for Francis: {0:C}", fTotal);
        Console.WriteLine("Grand total for all salespersons: {0:C}", grandTotal);

        // Determine salesperson with highest amount sold
        string highestSalesperson = "";
        double highestAmount = 0.0;
        if (dTotal > highestAmount)
        {
            highestAmount = dTotal;
            highestSalesperson = "Danielle";
        }
        if (eTotal > highestAmount)
        {
            highestAmount = eTotal;
            highestSalesperson = "Edward";
        }
        if (fTotal > highestAmount)
        {
            highestAmount = fTotal;
            highestSalesperson = "Francis";
        }
        Console.WriteLine("Salesperson with highest amount sold: {0} ({1:C})", highestSalesperson, highestAmount);

        // Wait for user to press a key before closing the console window
        Console.ReadKey();
    }
}




