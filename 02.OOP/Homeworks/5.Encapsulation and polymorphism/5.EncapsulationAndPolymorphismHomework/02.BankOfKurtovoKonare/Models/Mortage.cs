using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankOfKurtovoKonare.Models
{
    public class Mortage : Account
    {
        public Mortage(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override void DepositMoney(decimal amount)
        {
            this.Balance -= amount;
        }

        public override decimal CalculateInterest(int months)
        {
            if (months <= 12 && this.Customer == Customer.Company)
            {
                return base.CalculateInterest(months) / 2;
            }
            if (months <= 6 && this.Customer == Customer.Individual)
            {
                return 0;
            }

            return base.CalculateInterest(months);
        }
    }
}
