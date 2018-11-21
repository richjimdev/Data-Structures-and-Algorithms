using System;

namespace InsertionSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[] { 5, 15, 1, 35, 68, 12, 3, 2 };

            Insertion(array);

        }

        /// <summary>
        /// Sort an array in place, using an insertion sorting algorithm
        /// </summary>
        /// <param name="arr">Array to sort</param>
        public static void Insertion(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i - 1;

                while (j >= 0 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = temp;

                Console.WriteLine(string.Join(",", arr));
                Console.WriteLine("====================");
            }
        }
    }
}
