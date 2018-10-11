using System;

namespace BinarySearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] inputArray = { 4, 8, 15, 16, 23, 42 };
            int value = 15;
                
            Console.WriteLine(BinarySearchMethod(inputArray, value));
        }

        public static int BinarySearchMethod(int[] arr, int num)
        {
            int start = 0;
            int end = arr.Length - 1;

            for (int i = 0; i < arr.Length / 2; i++)
            {
                int mid = (start + end) / 2;

                if (num == arr[mid])
                {
                    return mid;
                }
                else if (num > arr[mid])
                {
                    start = mid + 1;
                }
                else if (num < arr[mid])
                {
                    end = mid - 1;
                }
            }
            return -1;
        }
    }
}

