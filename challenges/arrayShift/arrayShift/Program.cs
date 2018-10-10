using System;

namespace arrayShift
{
    class Program
    {
        static void Main(string[] args)
        {

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
