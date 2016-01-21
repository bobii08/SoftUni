using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompareSortingAlgorithms
{
    class CompareSortingAlgorithmsProgram
    {
        static void Main()
        {
            const int Iterations = 10000;
            int[] arr = new[] { 20, 17, -5, 4, 23, 100, -20, 17, 2, 3 };
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            for (int i = 0; i < Iterations; i++)
            {
                SortingAlgorithms.InsertionSort(arr);
            }

            stopwatch.Stop();
            Console.WriteLine("Insertion sort: " + stopwatch.Elapsed.TotalMilliseconds);

            stopwatch.Restart();
            for (int i = 0; i < Iterations; i++)
            {
                SortingAlgorithms.SelectionSort(arr);
            }

            stopwatch.Stop();
            Console.WriteLine("Selection sort: " + stopwatch.Elapsed.TotalMilliseconds);

            stopwatch.Restart();
            for (int i = 0; i < Iterations; i++)
            {
                SortingAlgorithms.MergeSort(arr, 0, arr.Length - 1);
            }

            stopwatch.Stop();
            Console.WriteLine("Merge sort: " + stopwatch.Elapsed.TotalMilliseconds);
            
            stopwatch.Restart();
            for (int i = 0; i < Iterations; i++)
            {
                SortingAlgorithms.Quicksort(arr, 0, arr.Length - 1);
            }

            stopwatch.Stop();
            Console.WriteLine("Quick sort: " + stopwatch.Elapsed.TotalMilliseconds);
        }
    }
}
