// Name: Terel Lewis
// Date: 4/16/2023
// Description: Application Demo of Sales Transaction.

using System;
using static System.Console;
using SalesTransactionLibrary;


namespace SalesTransactionDemo
{
    class SalesTransactionDemo
    {
        static void Main()
        {
            SalesTransaction sales1 = new SalesTransaction("Abbott", 2000, 0.2m);
            SalesTransaction sales2 = new SalesTransaction("Bender", 4000);
            SalesTransaction sales3 = new SalesTransaction("Carter");

            WriteLine("{0} had sales totaling {1}. Commission rate is {2}; commission value is {3}.", sales1.SalespersonName, sales1.SalesAmount.ToString("F0"), sales1.CommissionRate.ToString("F1"), sales1.Commission.ToString("F0"));
            WriteLine("{0} had sales totaling {1}. Commission rate is {2}; commission value is {3}.", sales2.SalespersonName, sales2.SalesAmount.ToString("F0"), sales2.CommissionRate.ToString("F1"), sales2.Commission.ToString("F0"));
            WriteLine("{0} had sales totaling {1}. Commission rate is {2}; commission value is {3}.", sales3.SalespersonName, sales3.SalesAmount.ToString("F0"), sales3.CommissionRate.ToString("F1"), sales3.Commission.ToString("F0"));


            decimal totalSalesAmount = sales1.SalesAmount + sales2.SalesAmount + sales3.SalesAmount;
            decimal totalCommission = sales1.Commission + sales2.Commission + sales3.Commission;

            WriteLine("\nTotal Sales Amount: {0}", totalSalesAmount.ToString("C0"));
            
        }
    }

}
