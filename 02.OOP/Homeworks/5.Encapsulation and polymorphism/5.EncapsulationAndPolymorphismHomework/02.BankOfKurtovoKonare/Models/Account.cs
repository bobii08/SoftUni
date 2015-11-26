using System;
using _02.BankOfKurtovoKonare.Interfaces;

namespace _02.BankOfKurtovoKonare.Models
{
    public abstract class Account : IAccount
    {
        private decimal balance;
        private decimal interestRate;

        protected Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer { get; private set; }

        public decimal Balance
        {
            get { return this.balance; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("balance", " Balance cannot be negative!");
                }

                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("interest rate", "Interest rate cannot be negative!");
                }

                this.interestRate = value / 100;
            }
        }


        public abstract void DepositMoney(decimal amount);

        public virtual decimal CalculateInterest(int months)
        {
            return this.Balance * (1 + this.InterestRate * months);
        }

        public override string ToString()
        {
            return string.Format("Type of customer: {0}, Balance: {1}, Interest rate: {2:F2}%", this.Customer, this.Balance, (this.InterestRate * 100));
        }
    }
}
