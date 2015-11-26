using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankOfKurtovoKonare.Models
{
    public class Loan : Account
    {
        public Loan(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override void DepositMoney(decimal amount)
        {
            this.Balance -= amount;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer == Customer.Individual && months <=3)
            {
                return 0;
            }
            if (this.Customer == Customer.Company && months <= 2)
            {
                return 0;
            }

            return base.CalculateInterest(months);
        }
    }
}
