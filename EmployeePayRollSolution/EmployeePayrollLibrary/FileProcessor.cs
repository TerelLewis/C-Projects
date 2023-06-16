using System;
using System.Collections.Generic;
using EmployeeClassLibrary;
using System.IO;

namespace EmployeePayrollLibrary
{
    public class FileProcessor
    {
        public static string SaveEmployeeData(List<Employee> employees)
        {
            string fileName = "Employee Data.txt";
            string directoryPath = @"C:\employees\";

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (Employee emp in employees)
                {
                    sw.WriteLine(emp.ToString());
                }
            }

            return filePath;
        }

    }
}

