using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 15, 1, 35, 68, 12, 3, 2 };

            Insertion(array);

        }

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
