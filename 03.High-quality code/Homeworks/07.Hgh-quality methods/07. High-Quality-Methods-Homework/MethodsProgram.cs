using System;
using System.Runtime.InteropServices;

namespace Methods
{
    class MethodsProgram
    {
        static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive");
            }

            if (!IsValidTriangle(a, b, c))
            {
                throw new ArgumentException("The given sides cannot form a valid triangle");
            }

            double halfPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));

            return area;
        }

        private static bool IsValidTriangle(double a, double b, double c)
        {
            if ((a + b <= c) || (a + c <= b) || (b + c <= a))
            {
                return false;
            }

            return true;
        }

        static string PresentDigitAsWord(int number)
        {
            switch (number)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    throw new ArgumentException("Invalid digit", "number");
            }
        }

        static int FindMax(params int[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException("elements", "The array you're trying to manipulate is null");
            }

            if (elements.Length == 0)
            {
                throw new ArgumentException("The array is empty", "elements");
            }

            int max = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }

            return max;
        }

        static string FormatNumberOutput(object number, string format)
        {
            string result = string.Empty;
            if (format == "f")
            {
                result = string.Format("{0:f}", number);
            }

            if (format == "%")
            {
                result = string.Format("{0:p}", number);
            }

            if (format == "r")
            {
                result = string.Format("{0:r}", number);
            }

            return result;
        }

        static void DetermineLinePosition(double x1, double y1, double x2, double y2,
            out bool isHorizontal, out bool isVertical)
        {
            isHorizontal = false;
            isVertical = false;
            if (y1 == y2)
            {
                isHorizontal = true;
            }
            else if (x1 == x2)
            {
                isVertical = true;
            }
        }

        static double CalcDistanceBetweenTwoPointsIn2DDimension(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            return distance;
        }

        static void Main()
        {
            Console.Write("Triangle's area with sides 3, 4, 5: ");
            Console.WriteLine(CalcTriangleArea(3, 4, 5));
            Console.WriteLine();

            Console.Write("The digit 5 represented as a word: ");
            Console.WriteLine(PresentDigitAsWord(5));
            Console.WriteLine();

            Console.Write("The biggest number from the array [5, -1, 3, 2, 14, 2, 3] is: ");
            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));
            Console.WriteLine();

            Console.WriteLine(FormatNumberOutput(1.3, "f"));
            Console.WriteLine(FormatNumberOutput(0.75, "%"));
            Console.WriteLine(FormatNumberOutput(2.30, "r"));
            Console.WriteLine();

            bool horizontal, vertical;
            DetermineLinePosition(3, 1, 3, 2.5, out horizontal, out vertical);
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Console.Write("Distance: ");
            Console.WriteLine(CalcDistanceBetweenTwoPointsIn2DDimension(3, -1, 3, 2.5));
            Console.WriteLine();

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.DayOfBirth = new DateTime(1993, 3, 17);
            peter.HomeTown = "Sofia";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.DayOfBirth = new DateTime(1993, 11, 3);
            stella.PersonalInfo = "A gamer, high results";

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
