using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PerformanceOfOperations
{
    class PerformanceOfOperationsProgram
    {
        const int NumberOfElapsedTimes = 10;
        static readonly Stopwatch Stopwatch = new Stopwatch();

        static void Main()
        {
            int intValue = 4;
            int intValue2 = 5;
            long longValue = 4;
            long longValue2 = 5;
            float floatValue = 4;
            float floatValue2 = 5;
            double doubleValue = 4;
            double doubleValue2 = 5;
            decimal decimalValue = 4;
            decimal decimalValue2 = 5;
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.Add, intValue, intValue2, "Int", "Add");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.Add, longValue, longValue2, "Long", "Add");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.Add, floatValue, floatValue2, "Float", "Add");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.Add, doubleValue, doubleValue2, "Double", "Add");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.Add, decimalValue, decimalValue2, "Decimal", "Add");
            Console.WriteLine();

            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.Subtract, intValue, intValue2, "Int", "Subtract");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.Subtract, longValue, longValue2, "Long", "Subtract");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.Subtract, floatValue, floatValue2, "Float", "Subtract");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.Subtract, doubleValue, doubleValue2, "Double", "Subtract");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.Subtract, decimalValue, decimalValue2, "Decimal", "Subtract");
            Console.WriteLine();

            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.PerfromPrefixIncrementing, intValue, "Int", "++(prefix)");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.PerfromPrefixIncrementing, longValue, "Long", "++(prefix)");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.PerfromPrefixIncrementing, floatValue,"Float", "++(prefix)");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.PerfromPrefixIncrementing, doubleValue, "Double", "++(prefix)");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.PerfromPrefixIncrementing, decimalValue, "Decimal", "++(prefix)");
            Console.WriteLine();

            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.PerfromPostfixIncrementing, intValue, "Int", "++(postfix)");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.PerfromPostfixIncrementing, longValue, "Long", "++(postfix)");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.PerfromPostfixIncrementing, floatValue, "Float", "++(postfix)");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.PerfromPostfixIncrementing, doubleValue, "Double", "++(postfix)");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.PerfromPostfixIncrementing, decimalValue, "Decimal", "++(postfix)");
            Console.WriteLine();

            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.PerformPlusOneOperation, intValue, "Int", "+=1");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.PerformPlusOneOperation, longValue, "Long", "+=1");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.PerformPlusOneOperation, floatValue, "Float", "+=1");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.PerformPlusOneOperation, doubleValue, "Double", "+=1");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.PerformPlusOneOperation, decimalValue, "Decimal", "+=1");
            Console.WriteLine();

            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.Multiply, intValue, intValue2, "Int", "Multiply");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.Multiply, longValue, longValue2, "Long", "Multiply");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.Multiply, floatValue, floatValue2, "Float", "Multiply");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.Multiply, doubleValue, doubleValue2, "Double", "Multiply");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.Multiply, decimalValue, decimalValue2, "Decimal", "Multiply");
            Console.WriteLine();

            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.Divide, intValue, intValue2, "Int", "Divide");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.Divide, longValue, longValue2, "Long", "Divide");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.Divide, floatValue, floatValue2, "Float", "Divide");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.Divide, doubleValue, doubleValue2, "Double", "Divide");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.Divide, decimalValue, decimalValue2, "Decimal", "Divide");
            Console.WriteLine();

            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.CalculateSqrt, intValue, "Int", "Math.Sqrt()");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.CalculateSqrt, longValue, "Long", "Math.Sqrt()");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.CalculateSqrt, floatValue, "Float", "Math.Sqrt()");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.CalculateSqrt, doubleValue, "Double", "Math.Sqrt()");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.CalculateSqrt, decimalValue, "Decimal", "Math.Sqrt()");
            Console.WriteLine();

            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.CalculateLog, intValue, "Int", "Math.Log()");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.CalculateLog, longValue, "Long", "Math.Log()");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.CalculateLog, floatValue, "Float", "Math.Log()");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.CalculateLog, doubleValue, "Double", "Math.Log()");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.CalculateLog, decimalValue, "Decimal", "Math.Log()");
            Console.WriteLine();

            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.CalculateSin, intValue, "Int", "Math.Sin()");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.CalculateSin, longValue, "Long", "Math.Sin()");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.CalculateSin, floatValue, "Float", "Math.Sin()");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.CalculateSin, doubleValue, "Double", "Math.Sin()");
            CalculateAverageElapsedTimeOfOperation(MathCalculationsUtils.CalculateSin, decimalValue, "Decimal", "Math.Sin()");
            Console.WriteLine();
        }

        private static void CalculateAverageElapsedTimeOfOperation<T>(Action<T, T> action, 
            T firstNumber, 
            T secondNumber, 
            string dataType,
            string operationType)
        {
            double[] timeElapses = new double[NumberOfElapsedTimes];
            for (int i = 0; i < NumberOfElapsedTimes; i++)
            {
                Stopwatch.Restart();
                action(firstNumber, secondNumber);
                Stopwatch.Stop();
                timeElapses[i] = Stopwatch.Elapsed.TotalMilliseconds;
            }

            Console.WriteLine(operationType + " - " + dataType + " : " + timeElapses.Average());
        }

        private static void CalculateAverageElapsedTimeOfOperation<T>(Action<T> action,
            T firstNumber,
            string dataType,
            string operationType)
        {
            double[] timeElapses = new double[NumberOfElapsedTimes];
            for (int i = 0; i < NumberOfElapsedTimes; i++)
            {
                Stopwatch.Restart();
                action(firstNumber);
                Stopwatch.Stop();
                timeElapses[i] = Stopwatch.Elapsed.TotalMilliseconds;
            }

            Console.WriteLine(operationType + " - " + dataType + " : " + timeElapses.Average());
        }
    }
}
