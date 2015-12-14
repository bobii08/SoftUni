using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.InterestCalculator
{
    public class InterestCalculator
    {
        private decimal money;
        private decimal interestRate;
        private int years;

        public InterestCalculator(decimal money, decimal interestRate, int years, CalculateInterest interestCalculationDelegate)
        {
            this.Money = money;
            this.InterestRate = interestRate;
            this.Years = years;
            this.InterestCalculationDelegate = interestCalculationDelegate;
        }

        public decimal Money
        {
            get { return this.money; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("money", "Money must be positive.");
                }

                this.money = value;
            }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("interest rate", "Interest rate must be positive.");
                }

                this.interestRate = value;
            }
        }

        public int Years
        {
            get { return this.years; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("years", "Years must be positive");
                }

                this.years = value;
            }
        }

        public CalculateInterest InterestCalculationDelegate;
    }
}
