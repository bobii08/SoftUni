using System;
using System.Collections.Generic;
using System.Text;

class ExceptionsProgram
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if (arr == null)
        {
            throw new ArgumentNullException("arr", "The array you've passed as an argument must not be null!");
        }

        if (arr.Length <= 0)
        {
            throw new ArgumentException("The array you've passed mus have at least one element", "arr");
        }

        if (startIndex < 0 || startIndex >= arr.Length)
        {
            throw new ArgumentOutOfRangeException("startIndex", string.Format("Start index must be between {0} and {1}", 0, arr.Length - 1));
        }

        if (startIndex + count > arr.Length)
        {
            throw new ArgumentOutOfRangeException("count",
                "The sum of startIndex and count must be less or equal to the array's length");
        }

        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }

        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        if (count > str.Length)
        {
            throw new ArgumentOutOfRangeException("count", "Count must not be greather than the string's length");
        }

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }

        return result.ToString();
    }

    public static void CheckPrime(int number)
    {
        if (number <= 1)
        {
            throw new ArgumentOutOfRangeException("number", "The number you've entered must be greater than 1.");
        }

        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                throw new ArgumentException(string.Format("The number {0} is not prime!", number), "number");
            }
        }
    }

    static void Main()
    {
        try
        {
            var subStr = Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(subStr);

            var ints = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(string.Join(" ", ints));

            var ints2 = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(string.Join(" ", ints2));

            var ints3 = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(string.Join(" ", ints3));
        }
        catch (ArgumentNullException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }

        try
        {
            Console.WriteLine(ExtractEnding("I love C#", 2));
            Console.WriteLine(ExtractEnding("Nakov", 4));
            Console.WriteLine(ExtractEnding("beer", 4));
            Console.WriteLine(ExtractEnding("Hi", 100));
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }

        try
        {
            CheckPrime(23);
            Console.WriteLine("23 is prime.");

            CheckPrime(33);
            Console.WriteLine("33 is prime.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.Error.WriteLine(ex.Message);            
        }
        catch (ArgumentException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
        
        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };
        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }
}
