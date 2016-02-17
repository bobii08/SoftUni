namespace _07.GenericArraySort
{
    using System;

    internal class GenericArraySort
    {
        private static void Main()
        {
            int[] numbers = { 100, 53, 2, 8, 12, 90 };
            numbers = SortArray(numbers);
            Console.WriteLine("sorted numbers: " + string.Join(", ", numbers));
            string[] strings = { "zaz", "abc", "pku", "aaa" };
            strings = SortArray(strings);
            Console.WriteLine("sorted strings: " + string.Join(", ", strings));
            DateTime[] dates = { new DateTime(2002, 8, 8), new DateTime(2005, 2, 4), new DateTime(2015, 11, 4) };
            dates = SortArray(dates);
            Console.Write("sorted dates: ");
            for (int i = 0; i < dates.Length; i++)
            {
                if (i == dates.Length - 1)
                {
                    Console.WriteLine(dates[i].ToString("M/d/yyyy h:mm:ss"));
                    break;
                }

                Console.Write(dates[i].ToString("M/d/yyyy h:mm:ss") + ", ");
            }
        }

        private static T[] SortArray<T>(T[] array) where T : IComparable
        {
            while (true)
            {
                bool hasChanged = false;
                for (int index = 0; index < array.Length - 1; index++)
                {
                    if (array[index].CompareTo(array[index + 1]) == 1)
                    {
                        Swap(ref array[index], ref array[index + 1]);
                        hasChanged = true;
                    }
                }

                if (!hasChanged)
                {
                    break;
                }
            }

            return array;
        }

        private static void Swap<T>(ref T v1, ref T v2)
        {
            T old = v1;
            v1 = v2;
            v2 = old;
        }
    }
}