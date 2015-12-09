using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.FractionCalculator
{
    public struct Fraction
    {
        private BigInteger numerator;
        private BigInteger denominator;

        public Fraction(BigInteger numerator, BigInteger denominator)
            : this()
        {
            BigInteger greatestCommonDivisor = this.GreatestCommonDivisor(numerator, denominator);
            this.Numerator = numerator / greatestCommonDivisor;
            this.Denominator = denominator / greatestCommonDivisor;

            if (this.Denominator < 0)
            {
                this.Numerator = numerator * (-1);
                this.Denominator = denominator * (-1);
            }
        }

        public BigInteger Numerator
        {
            get { return this.numerator; }
            private set { this.numerator = value; }
        }

        public BigInteger Denominator
        {
            get { return this.denominator; }
            private set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Denominator cannot be 0.", "denominator");
                }
                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            BigInteger num = f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator;
            BigInteger denom = f1.Denominator * f2.Denominator;
            return new Fraction(num, denom);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            BigInteger num = f1.Numerator * f2.Denominator - f2.Numerator * f1.Denominator;
            BigInteger denom = f1.Denominator - f2.Denominator;
            return new Fraction(num, denom);
        }

        public override string ToString()
        {
            decimal result = (decimal)(this.Numerator) / (decimal)this.Denominator;
            return result.ToString();
        }

        private BigInteger GreatestCommonDivisor(BigInteger numerator, BigInteger denominator)
        {
            BigInteger num = Math.Abs((long)numerator);
            BigInteger denom = Math.Abs((long)denominator);
            while (denom != 0)
            {
                BigInteger remainder = num % denom;
                num = denom;
                denom = remainder;
            }

            return num;
        }
    }
}
