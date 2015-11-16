using System;

namespace _5.DoubleDowns
{
    class DoubleDowns
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Int32.Parse(Console.ReadLine());
            }

            int rightDiagonalCount = 0;
            int leftDiagonalCount = 0;
            int verticalCount = 0;
            for (int numberPosition = 0; numberPosition < numbers.Length - 1; numberPosition++)
            {
                int upNumber = numbers[numberPosition];
                int downNumber = numbers[numberPosition + 1];
                for (int index = 0; index < 32; index++)
                {
                    int mask = 1 << index;
                    bool check = (upNumber & mask) > 0;
                    if (check && ((downNumber & mask) > 0))
                    {
                        verticalCount++;
                    }
                    if (index < 31)
                    {
                        if (check && ((downNumber & (mask << 1)) > 0))
                        {
                            leftDiagonalCount++;
                        }
                    }
                    if (index > 0)
                    {
                        if (check && ((downNumber & (mask >> 1)) > 0))
                        {
                            rightDiagonalCount++;
                        }
                    }
                }
            }

            Console.WriteLine(rightDiagonalCount);
            Console.WriteLine(leftDiagonalCount);
            Console.WriteLine(verticalCount);
        }
    }
}

