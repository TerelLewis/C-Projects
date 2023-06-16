using System;


namespace EmployeeClassLibrary
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public decimal Salary { get; set; }

        public decimal CalculatePaycheck()
        {
            return Salary / 26;
        }

        public override string ToString()
        {
            return $"EmployeeId: {EmployeeId}\nEmployeeName: {EmployeeName}\nSalary: {Salary:C}\n";
        }
    }
}

