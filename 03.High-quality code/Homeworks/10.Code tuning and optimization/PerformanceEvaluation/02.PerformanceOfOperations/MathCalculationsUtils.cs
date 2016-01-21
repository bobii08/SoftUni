using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PerformanceOfOperations
{
    public static class MathCalculationsUtils
    {
        private const int NumberOfIterations = 100000;

        public static void Add(int firstNumber, int secondNumber)
        {
            int result;

            for (int i = 0; i < NumberOfIterations; i++)
            {
                result = firstNumber + secondNumber;
            }
        }

        public static void Add(long firstNumber, long secondNumber)
        {
            long result;

            for (int i = 0; i < NumberOfIterations; i++)
            {
                result = firstNumber + secondNumber;
            }
        }

        public static void Add(float firstNumber, float secondNumber)
        {
            float result;

            for (int i = 0; i < NumberOfIterations; i++)
            {
                result = firstNumber + secondNumber;
            }
        }

        public static void Add(double firstNumber, double secondNumber)
        {
            double result;

            for (int i = 0; i < NumberOfIterations; i++)
            {
                result = firstNumber + secondNumber;
            }
        }

        public static void Add(decimal firstNumber, decimal secondNumber)
        {
            decimal result;

            for (int i = 0; i < NumberOfIterations; i++)
            {
                result = firstNumber + secondNumber;
            }
        }

        public static void Subtract(int firstNumber, int secondNumber)
        {
            int result;

            for (int i = 0; i < NumberOfIterations; i++)
            {
                result = firstNumber - secondNumber;
            }
        }

        public static void Subtract(long firstNumber, long secondNumber)
        {
            long result;

            for (int i = 0; i < NumberOfIterations; i++)
            {
                result = firstNumber - secondNumber;
            }
        }

        public static void Subtract(float firstNumber, float secondNumber)
        {
            float result;

            for (int i = 0; i < NumberOfIterations; i++)
            {
                result = firstNumber - secondNumber;
            }
        }

        public static void Subtract(double firstNumber, double secondNumber)
        {
            double result;

            for (int i = 0; i < NumberOfIterations; i++)
            {
                result = firstNumber - secondNumber;
            }
        }

        public static void Subtract(decimal firstNumber, decimal secondNumber)
        {
            decimal result;

            for (int i = 0; i < NumberOfIterations; i++)
            {
                result = firstNumber - secondNumber;
            }
        }

        public static void PerfromPrefixIncrementing(int firstNumber)
        {
            for (int i = 0; i < NumberOfIterations; i++)
            {
                ++firstNumber;
            }
        }

        public static void PerfromPrefixIncrementing(long firstNumber)
        {
            for (int i = 0; i < NumberOfIterations; i++)
            {
                ++firstNumber;
            }
        }

        public static void PerfromPrefixIncrementing(float firstNumber)
        {
            for (int i = 0; i < NumberOfIterations; i++)
            {
                ++firstNumber;
            }
        }

        public static void PerfromPrefixIncrementing(double firstNumber)
        {
            for (int i = 0; i < NumberOfIterations; i++)
            {
                ++firstNumber;
            }
        }

        public static void PerfromPrefixIncrementing(decimal firstNumber)
        {
            for (int i = 0; i < NumberOfIterations; i++)
            {
                ++firstNumber;
            }
        }

        public static void PerfromPostfixIncrementing(int firstNumber)
        {
            for (int i = 0; i < NumberOfIterations; i++)
            {
                firstNumber++;
            }
        }

        public static void PerfromPostfixIncrementing(long firstNumber)
        {
            for (int i = 0; i < NumberOfIterations; i++)
            {
                firstNumber++;
            }
        }

        public static void PerfromPostfixIncrementing(float firstNumber)
        {
            for (int i = 0; i < NumberOfIterations; i++)
            {
                firstNumber++;
            }
        }

        public static void PerfromPostfixIncrementing(double firstNumber)
        {
            for (int i = 0; i < NumberOfIterations; i++)
            {
                firstNumber++;
            }
        }

        public static void PerfromPostfixIncrementing(decimal firstNumber)
        {
            for (int i = 0; i < NumberOfIterations; i++)
            {
                firstNumber++;
            }
        }

        public static void PerformPlusOneOperation(int firstNumber)
        {
            for (int i = 0; i < NumberOfIterations; i++)
            {
                firstNumber += 1;
            }
        }

        public static void PerformPlusOneOperation(long firstNumber)
        {
            for (int i = 0; i < NumberOfIterations; i++)
            {
                firstNumber += 1;
            }
        }

        public static void PerformPlusOneOperation(float firstNumber)
        {
            for (int i = 0; i < NumberOfIterations; i++)
            {
                firstNumber += 1;
            }
        }

        public static void PerformPlusOneOperation(double firstNumber)
        {
            for (int i = 0; i < NumberOfIterations; i++)
            {
                firstNumber += 1;
            }
        }

        public static void PerformPlusOneOperation(decimal firstNumber)
        {
            for (int i = 0; i < NumberOfIterations; i++)
            {
                firstNumber += 1;
            }
        }

        public static void Multiply(int firstNumber, int secondNumber)
        {
            int result;
            for (int i = 0; i < NumberOfIterations; i++)
            {
                result = firstNumber * secondNumber;
            }
        }

        public static void Multiply(long firstNumber, long secondNumber)
        {
            long result;
            for (int i = 0; i < NumberOfIterations; i++)
            {
                result = firstNumber * secondNumber;
            }
        }

        public static void Multiply(float firstNumber, float secondNumber)
        {
            float result;
            for (int i = 0; i < NumberOfIterations; i++)
            {
                result = firstNumber * secondNumber;
            }
        }

        public static void Multiply(double firstNumber, double secondNumber)
        {
            double result;
            for (int i = 0; i < NumberOfIterations; i++)
            {
                result = firstNumber * secondNumber;
            }
        }

        public static void Multiply(decimal firstNumber, decimal secondNumber)
        {
            decimal result;
            for (int i = 0; i < NumberOfIterations; i++)
            {
                result = firstNumber * secondNumber;
            }
        }

        public static void Divide(int firstNumber, int secondNumber)
        {
            int result;
            for (int i = 0; i < NumberOfIterations; i++)
            {
                result = firstNumber/secondNumber;
            }
        }

        public static void Divide(long firstNumber, long secondNumber)
        {
            long result;
            for (int i = 0; i < NumberOfIterations; i++)
            {
                result = firstNumber / secondNumber;
            }
        }

        public static void Divide(float firstNumber, float secondNumber)
        {
            float result;
            for (int i = 0; i < NumberOfIterations; i++)
            {
                result = firstNumber / secondNumber;
            }
        }

        public static void Divide(double firstNumber, double secondNumber)
        {
            double result;
            for (int i = 0; i < NumberOfIterations; i++)
            {
                result = firstNumber / secondNumber;
            }
        }

        public static void Divide(decimal firstNumber, decimal secondNumber)
        {
            decimal result;
            for (int i = 0; i < NumberOfIterations; i++)
            {
                result = firstNumber / secondNumber;
            }
        }

        public static void CalculateSqrt(int number)
        {
            double numberToManipulate = (double)number;
            for (int i = 0; i < NumberOfIterations; i++)
            {
                Math.Sqrt(numberToManipulate);
            }
        }

        public static void CalculateSqrt(long number)
        {
            double numberToManipulate = (double)number;
            for (int i = 0; i < NumberOfIterations; i++)
            {
                Math.Sqrt(numberToManipulate);
            }
        }

        public static void CalculateSqrt(float number)
        {
            double numberToManipulate = (double)number;
            for (int i = 0; i < NumberOfIterations; i++)
            {
                Math.Sqrt(numberToManipulate);
            }
        }

        public static void CalculateSqrt(double number)
        {
            for (int i = 0; i < NumberOfIterations; i++)
            {
                Math.Sqrt(number);
            }
        }

        public static void CalculateSqrt(decimal number)
        {
            double numberToManipulate = (double)number;
            for (int i = 0; i < NumberOfIterations; i++)
            {
                Math.Sqrt(numberToManipulate);
            }
        }

        public static void CalculateLog(int number)
        {
            double numberToManipulate = (double)number;
            for (int i = 0; i < NumberOfIterations; i++)
            {
                Math.Log(numberToManipulate);
            }
        }

        public static void CalculateLog(long number)
        {
            double numberToManipulate = (double)number;
            for (int i = 0; i < NumberOfIterations; i++)
            {
                Math.Log(numberToManipulate);
            }
        }

        public static void CalculateLog(float number)
        {
            double numberToManipulate = (double)number;
            for (int i = 0; i < NumberOfIterations; i++)
            {
                Math.Log(numberToManipulate);
            }
        }

        public static void CalculateLog(double number)
        {
            for (int i = 0; i < NumberOfIterations; i++)
            {
                Math.Log(number);
            }
        }

        public static void CalculateLog(decimal number)
        {
            double numberToManipulate = (double)number;
            for (int i = 0; i < NumberOfIterations; i++)
            {
                Math.Log(numberToManipulate);
            }
        }

        public static void CalculateSin(int number)
        {
            double numberToManipulate = (double)number;
            for (int i = 0; i < NumberOfIterations; i++)
            {
                Math.Sin(numberToManipulate);
            }
        }

        public static void CalculateSin(long number)
        {
            double numberToManipulate = (double)number;
            for (int i = 0; i < NumberOfIterations; i++)
            {
                Math.Sin(numberToManipulate);
            }
        }

        public static void CalculateSin(float number)
        {
            double numberToManipulate = (double)number;
            for (int i = 0; i < NumberOfIterations; i++)
            {
                Math.Sin(numberToManipulate);
            }
        }

        public static void CalculateSin(double number)
        {
            for (int i = 0; i < NumberOfIterations; i++)
            {
                Math.Sin(number);
            }
        }

        public static void CalculateSin(decimal number)
        {
            double numberToManipulate = (double)number;
            for (int i = 0; i < NumberOfIterations; i++)
            {
                Math.Sin(numberToManipulate);
            }
        }
    }
}
