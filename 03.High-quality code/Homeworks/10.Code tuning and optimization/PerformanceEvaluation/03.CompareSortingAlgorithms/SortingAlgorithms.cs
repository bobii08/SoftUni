using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompareSortingAlgorithms
{
    public static class SortingAlgorithms
    {
        public static void InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int j = i + 1;

                while (j > 0)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;

                    }

                    j--;
                }
            }
        }

        public static void SelectionSort(int[] arr)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                int min_key = j;

                for (int k = j + 1; k < arr.Length; k++)
                {
                    if (arr[k] < arr[min_key])
                    {
                        min_key = k;
                    }
                }

                int tmp = arr[min_key];
                arr[min_key] = arr[j];
                arr[j] = tmp;
            }
        }

        public static void Quicksort(int[] elements, int left, int right)
        {
            int i = left, j = right;
            int pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    int tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }
        
        public static void MergeSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int mid = (end + start) / 2;
                MergeSort(arr, start, mid);
                MergeSort(arr, mid + 1, end);
                MergeArray(arr, start, mid, end);
            }
        }

        public static void MergeArray(int[] arr, int start, int mid, int end)
        {
            int[] temp = new int[end - start + 1];

            int i = start, j = mid + 1, k = 0;

            while (i <= mid && j <= end)
            {
                if (arr[i] < arr[j])
                {
                    temp[k] = arr[i];
                    k++;
                    i++;
                }
                else
                {
                    temp[k] = arr[j];
                    k++;
                    j++;
                }
            }

            while (i <= mid)
            {
                temp[k] = arr[i];
                k++;
                i++;
            }

            while (j <= end)
            {
                temp[k] = arr[j];
                k++;
                j++;
            }

            k = 0;
            i = start;
            while (k < temp.Length && i <= end)
            {
                arr[i] = temp[k];
                i++;
                k++;
            }
        }
    }
}
