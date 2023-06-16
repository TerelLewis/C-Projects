using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTransactionLibrary
{
    public class SalesTransaction
    {
        // Fields
        private string salespersonName;
        private decimal salesAmount;
        private decimal commissionRate;

        //properties
        public string SalespersonName
        {
            get { return salespersonName; }
            set { salespersonName = value; }
        }

        public decimal SalesAmount
        {
            get { return salesAmount; }
            set { salesAmount = value; }
        }

        public decimal Commission
        {
            get { return SalesAmount * commissionRate; }
        }

        public decimal CommissionRate
        {
            get { return commissionRate; }
        }

        // constructors
        public SalesTransaction(string name, decimal amount = 0, decimal rate = 0)
        {
            SalespersonName = name;
            SalesAmount = amount;
            commissionRate = rate;
        }

        public SalesTransaction(string name, decimal amount)
        {
            SalespersonName = name;
            SalesAmount = amount;
            commissionRate = 0;
        }
    }
}
