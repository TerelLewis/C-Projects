using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOrganizationMemberLibrary
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeId { get; set; }

        private double rate;

        public double HourlyRate
        {
            get { return rate; }
            set
            {
                if (value > 0.0)
                {
                    rate = value;

                }
                else
                    throw new OrganizationMemberException("The rate must be greater than $0.00");
            }
        }
        public double PayAmount(double hoursWorked)
        {
            return hoursWorked * rate;
        }
        public string PrintEmployeeInformation()
        {
            return $"Name is {FirstName} {LastName} and Employee Id is: {EmployeeId}";

        }
        public double hours;
    }
    
}

