using System;
using System.Diagnostics;

class Assertions
{
    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        Debug.Assert(arr != null, "The array you've passed as an argument must not be null.");
        Debug.Assert(arr.Length > 0, "The array must contain at least 1 element.");

        for (int index = 0; index < arr.Length - 1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }

        for (int i = 0; i < arr.Length - 1; i++)
        {
            Debug.Assert(arr[i].CompareTo(arr[i + 1]) <= 0, string.Format("The array is not sorted right. {0} should be before {1}", arr[i + 1], arr[i]));
        }
    }

    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        Debug.Assert(arr != null, "The array you've passed as an argument must not be null.");
        Debug.Assert(arr.Length > 0, "The array must contain at least 1 element.");

        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }

        Debug.Assert((startIndex <= minElementIndex) && (minElementIndex <= endIndex), string.Format("The index you're looking for is not in the right range. Should be between {0} and {1}", startIndex, endIndex));

        return minElementIndex;
    }

    public static int FindIndexOfElement<T>(T[] arr, T value) where T : IComparable<T>
    {
        Debug.Assert(arr != null, "The array you've passed as an argument must not be null.");
        Debug.Assert(arr.Length > 0, "The array must contain at least 1 element.");

        int resultIndex = FindIndexOfElementInGivenRangeOfIndexes(arr, value, 0, arr.Length - 1);

        if (resultIndex != -1)
        {
            Debug.Assert((0 <= resultIndex) && (resultIndex < arr.Length), string.Format("The min index is not correct. Should be between {0} and {1}", 0, arr.Length - 1));
        }

        return resultIndex;
    }

    private static int FindIndexOfElementInGivenRangeOfIndexes<T>(T[] arr, T value, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        Debug.Assert(arr != null, "The array you've passed as an argument must not be null.");
        Debug.Assert(arr.Length > 0, "The array must contain at least 1 element.");

        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                Debug.Assert((startIndex <= midIndex) && (midIndex <= endIndex), string.Format("The min index is not correct. Should be between {0} and {1}", startIndex, endIndex));

                return midIndex;
            }
            if (arr[midIndex].CompareTo(value) < 0)
            {
                startIndex = midIndex + 1;
            }
            else
            {
                endIndex = midIndex - 1;
            }
        }

        return -1;
    }

    static void Main()
    {
        int[] ints = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("array of integers = [{0}]", string.Join(", ", ints));
        SelectionSort(ints);
        Console.WriteLine("the sorted array = [{0}]", string.Join(", ", ints));

        // SelectionSort(new int[0]); // Test sorting empty array --> gives an error
        SelectionSort(new int[1]); // Test sorting single element array

        // Console.WriteLine(FindIndexOfMinElement(ints, -1000)); --> gives an error
        Console.WriteLine(FindIndexOfElement(ints, 0));
        Console.WriteLine(FindIndexOfElement(ints, 17));
        Console.WriteLine(FindIndexOfElement(ints, 3214213)); // returns -1
        // Console.WriteLine(FindIndexOfMinElement(ints, 17)); --> gives an error
        // Console.WriteLine(FindIndexOfMinElement(ints, 10)); --> gives an error
        // Console.WriteLine(FindIndexOfMinElement(ints, 1000)); --> gives an error
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        T oldX = x;
        x = y;
        y = oldX;
    }
}
