// Name: Terel Lewis
// Date: 4/30/2023
// Application Description: Create a database with file saving capabilities


using System;
using static System.Console;
using System.Collections.Generic;
using EmployeeClassLibrary;
using EmployeePayrollLibrary;


namespace EmployeePayroll
{
    class EmployeeDemo
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            while (true)
            {
                Write("Enter Employee Id (or 0 to exit): ");
                string input = ReadLine();

                if (int.TryParse(input, out int employeeId))
                {
                    if (employeeId == 0)
                    {
                        break;
                    }

                    Employee emp = new Employee();

                    emp.EmployeeId = employeeId;

                    Write("Enter Employee Name: ");
                    emp.EmployeeName = ReadLine();

                    Write("Enter Employee Salary: ");
                    input = ReadLine();

                    if (decimal.TryParse(input, out decimal salary))
                    {
                        emp.Salary = salary;
                    }

                    employees.Add(emp);

                    while (true)
                    {
                        Write("Do you want to continue? (y/n): ");
                        string choice = ReadLine().ToLower();

                        if (choice == "y")
                        {
                            break;
                        }
                        else if (choice == "n")
                        {
                            string filePath = FileProcessor.SaveEmployeeData(employees);
                            WriteLine($"Employee data saved to: {filePath}");
                            ReadLine();
                            return;
                        }
                        else
                        {
                            WriteLine("Invalid input. Please enter 'y' or 'n'.");
                        }
                    }
                }
                else
                {
                    WriteLine("Invalid input. Please enter a valid Employee Id or 0 to exit.");
                }
            }
        }
    }
}
