// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

/* use parentheses() to call a method. ex: MyMethod()
 * can also be used to call a constructor when creating an instance. Ex: MyProject obj = new MyProject(arg1)*/

/* Use curly braces to define a block of code, as object initializers, array initializers
 * to define anonymous types, and control flow statements. */

// Use square brackets to declare arrays, index arrays, as indexers, attributes, and pointers.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/*Name: Terel Lewis
  Date: 03/15/2023
  Program: This is my first C# Program
  Written for Module1*/

namespace Module1_FirstApp
{
    class Program
    {
        // Main is the starting point for an application
        static void Main(string[] args)
        {
            // delcare and initalize variables
            int quantity = 0;
            double item_price = 0.0;
            double total_price = 0.0;

            const double OVER_BUDGET_AMOUNT = 100.00;

            // prompt user for values and capture values in variables
            Write("Enter the item price: ");
            item_price = Convert.ToDouble(ReadLine());

            Write("Enter the quantity purchased: ");
            quantity = Convert.ToInt32(ReadLine());

            // Calculate total price
            total_price = item_price * quantity;

            // IF statments 
            if (total_price > OVER_BUDGET_AMOUNT)
            {
                WriteLine("You are over budget.");
            }
            WriteLine("The total is {0}", total_price.ToString("c"));
        }
    }
}
