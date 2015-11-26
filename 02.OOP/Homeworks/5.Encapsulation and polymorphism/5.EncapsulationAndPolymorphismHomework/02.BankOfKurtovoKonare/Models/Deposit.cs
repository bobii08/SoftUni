using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.BankOfKurtovoKonare.Interfaces;

namespace _02.BankOfKurtovoKonare.Models
{
    public class Deposit : Account, IWithdrawable
    {
        public Deposit(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }

        public void Widthdraw(decimal amount)
        {
            this.Balance -= amount;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }

            return base.CalculateInterest(months);
        }
    }
}
