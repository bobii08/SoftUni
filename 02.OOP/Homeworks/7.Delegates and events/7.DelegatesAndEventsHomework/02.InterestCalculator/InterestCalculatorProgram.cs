using System;

namespace _02.InterestCalculator
{
    public delegate string CalculateInterest(decimal money, decimal interestRate, int years);

    class InterestCalculatorProgram
    {
        private const decimal NumberOfTimesTheInterestIsCompounded = 12;

        static void Main()
        {
            CalculateInterest compoundInterestDelegate = GetCompoundInterest;
            InterestCalculator compoundInterestCalculator = new InterestCalculator(500, 5.6m, 10, compoundInterestDelegate);
            Console.WriteLine(compoundInterestCalculator.InterestCalculationDelegate(
                compoundInterestCalculator.Money,
                compoundInterestCalculator.InterestRate,
                compoundInterestCalculator.Years));

            CalculateInterest simpleInterestDelegate = GetSimpleInterest;
            InterestCalculator simpleInterestCalculator = new InterestCalculator(2500, 7.2m, 15, simpleInterestDelegate);
            Console.WriteLine(simpleInterestCalculator.InterestCalculationDelegate(
                simpleInterestCalculator.Money,
                simpleInterestCalculator.InterestRate,
                simpleInterestCalculator.Years));
        }

        private static string GetSimpleInterest(decimal money, decimal interestRate, int years)
        {
            decimal result = money * (1 + (interestRate / 100) * years);
            return string.Format("{0:F4}", result);
        }

        private static string GetCompoundInterest(decimal money, decimal interestRate, int years)
        {
            decimal result = money *
                             (decimal)Math.Pow((1 + (double)((interestRate / 100) / NumberOfTimesTheInterestIsCompounded)),
                                     (double)(years * NumberOfTimesTheInterestIsCompounded));
            return string.Format("{0:F4}", result);
        }
    }
}
