// Name: Terel Lewis
// Date: 3/16/2023
/* Program Description : Application that demonstrates prompting for user info,
                         performing calculations and printing out results */





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

class GreenvilleRevenue
{
    static void Main() 
    {
        // User input number of contestants at last year's competition
        WriteLine("Enter the number of contestants last year:");
        int lastYearContestants = int.Parse(Console.ReadLine());

        // User input number of contestants at this year's competition
        WriteLine("Enter the number of contestants this year:");
        int thisYearContestants = int.Parse(Console.ReadLine());

        // Console breakdown user input/ reads total number of contestants for respective year
        //WriteLine("Last year's contestants: " + lastYearContestants);
        //WriteLine("This year's contestants: " + thisYearContestants);

        // Console gives user a comparison of last year's competition to this year's competition
        WriteLine($"Last year's competition had {lastYearContestants} contestants, and this year's has {thisYearContestants} contestants.");

        // Determine revenue expected for this year's competition
        int revenueExpected = thisYearContestants * 25;
        WriteLine("Revenue expected for this year's competition: $" + revenueExpected);


        // if/else statment for thisYearContestants vs lastYearContestants
        if (thisYearContestants > lastYearContestants)
        { 
            WriteLine("This year's competition has more contestants than last year's competition");
        }
        else
        {
            WriteLine("This year's competition does not have more contestants than last year's compeition");
        }


        
       
    }
}
