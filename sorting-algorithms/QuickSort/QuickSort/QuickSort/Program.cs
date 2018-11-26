using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 5, 7, 2, 1, 30, 5, 34, 15, 23, 40, 56, 37 };

            Sort(input, 0, input.Length - 1);
        }


        static void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                // Partition the Algorithm
                int position = Partition(arr, left, right);
                // Sort the left
                Sort(arr, left, position - 1);
                // Sort the right
                Sort(arr, position + 1, right);

            }

        }

        static int Partition(int[] arr, int left, int right)
        {
            // set a pivot
            int pivot = arr[right];

            // get the index of the lower value
            int low = left - 1;

            for (int i = left; i < right; i++)
            {
                if (arr[i] <= pivot)
                {
                    low++;

                    Swap(arr, i, low);
                }

            }

            Swap(arr, right, low + 1);

            Console.WriteLine(string.Join(",", arr));

            return low + 1;
        }

        static void Swap(int[] arr, int i, int low)
        {
            int temp;
            temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }
    }
}
