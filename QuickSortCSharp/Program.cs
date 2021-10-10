using System;

namespace QuickSortCSharp
{
    class Program
    {
        private static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    QuickSort(arr, left, pivot - 1);
                }

                if (pivot + 1 < right)
                {
                    QuickSort(arr, pivot + 1, right);
                }
            }
        }
        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];

            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 8, 10, 95, 4, 1, 0, 22, 41, 109, 6, 18, -2, -1, 222, -111 };

            Console.WriteLine("Original Array: ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            QuickSort(arr, 0, arr.Length - 1);

            Console.WriteLine();
            Console.WriteLine("Sorted Array: ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
        }
    }
}
