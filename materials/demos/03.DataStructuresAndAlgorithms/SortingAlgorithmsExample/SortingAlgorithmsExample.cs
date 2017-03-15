using System;
using System.Linq;

namespace SortingAlgorithmsExample
{
    class SortingAlgorithmsExample
    {
        static void BubbleSort(int[] arr)
        {
            for (int i = 1; i <= arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static int Partition(int[] arr, int start, int end)
        {
            int currentIndex = start;
            int pivotIndex = end - 1;
            int temp;

            for (int i = start; i < end; i++)
            {
                if (arr[i] < arr[pivotIndex])
                {
                    temp = arr[i];
                    arr[i] = arr[currentIndex];
                    arr[currentIndex] = temp;
                    ++currentIndex;
                }
            }

            temp = arr[currentIndex];
            arr[currentIndex] = arr[pivotIndex];
            arr[pivotIndex] = temp;

            return currentIndex;
        }

        static void QuickSortInternal(int[] arr, int start, int end)
        {
            int length = end - start;
            if (length < 2)
            {
                return;
            }

            int pivotIndex = Partition(arr, start, end);
            QuickSortInternal(arr, start, pivotIndex); // left
            QuickSortInternal(arr, pivotIndex + 1, end); // right
        }

        static void QuickSort(int[] arr)
        {
            QuickSortInternal(arr, 0, arr.Length);
        }

        static void Main()
        {
            //int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] input = Console.ReadLine().Split(' ');
            int[] arr = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            //BubbleSort(arr);
            QuickSort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
