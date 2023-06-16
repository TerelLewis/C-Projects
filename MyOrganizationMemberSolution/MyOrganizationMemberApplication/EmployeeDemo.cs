using System;
using static System.Console;
using MyOrganizationMemberLibrary;

namespace MyOrganizationMemberApplication
{
    public class EmployeeDemo : Employee
    {
        static void Main(string[] args)
        {
            EmployeeDemo employee1 = new EmployeeDemo();

            Write("PLease enter your first name: ");
            employee1.FirstName = ReadLine();

            Write("Enter your last name: ");
            employee1.LastName = ReadLine();

            Write("Please enter your employee id: ");
            employee1.EmployeeId = ReadLine();

            Write("Please enter your hourly rate: ");
            employee1.HourlyRate = double.Parse(ReadLine());

            Write("Please enter the hours you have worked: ");
            employee1.hours = double.Parse(ReadLine());

            WriteLine("Please review your information.......");
            WriteLine(employee1.PrintEmployeeInformation());

            WriteLine($"Your pay will be: {employee1.PayAmount(employee1.hours)}");

        }
    }
}
