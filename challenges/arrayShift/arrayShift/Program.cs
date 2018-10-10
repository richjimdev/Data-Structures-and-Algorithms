using System;

namespace arrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArr = { 2, 4, 6, 8 };
            int[] testArr2 = { 4, 8, 15, 23, 42 };

            Console.WriteLine(string.Join(",", ArrayShift(testArr, 5)));
            Console.WriteLine(string.Join(",", ArrayShift(testArr2, 16)));
        }

        static int[] ArrayShift(int[] arr, int num)
        {
            int[] newArr = new int[arr.Length + 1];
            decimal halfOfArr = newArr.Length / 2;
            int midIdx = Convert.ToInt32(Math.Ceiling(halfOfArr));
            int counter = 0;
            for (int i = 0; i < newArr.Length; i++)
            {
                if (i == midIdx)
                    newArr[i] = num;
                else
                {
                    newArr[i] = arr[counter];
                    counter++;
                }
            }
            return newArr;
        }
    }
}
