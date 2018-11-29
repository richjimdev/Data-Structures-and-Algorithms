using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 8, 3, 2, 9, 7, 1, 5, 4, 6 };

            MergeSorter(myArray);
        }

        /// <summary>
        /// Sorts an array using a merge sort algorithm
        /// </summary>
        /// <param name="myArray">Array to sort</param>
        static void MergeSorter(int[] myArray)
        {
            if (myArray.Length > 1)
            {
                //establishing sizes of each half of the array
                int leftSize = myArray.Length / 2;
                int rightSize = myArray.Length - leftSize;

                // put the first half in one array (left)
                int[] left = new int[leftSize];
                Array.Copy(myArray, 0, left, 0, leftSize);

                // put the second half in another array (right)
                int[] right = new int[rightSize];
                Array.Copy(myArray, myArray.Length / 2, right, 0, rightSize);

                MergeSorter(left);
                MergeSorter(right);
                Merge(left, right, myArray);

            }

            Console.WriteLine(string.Join(",", myArray));

        }

        /// <summary>
        /// Helper fuction. Merges, sorts, and rejoins array.
        /// </summary>
        /// <param name="left">Left partition</param>
        /// <param name="right">Right partition</param>
        /// <param name="arr">Array to sort</param>
        /// <returns></returns>
        static int[] Merge(int[] left, int[] right, int[] arr)
        {
            // left pointer
            int i = 0;
            // right pointer
            int j = 0;
            // end array pointer
            int k = 0;

            // confirm that each array being compared still has pointers
            while (i < left.Length && j < right.Length)
            {
                // if the value of left array is less than the value of the right array
                if (left[i] <= right[j])
                {
                    // populate the main array with lower value
                    arr[k] = left[i];
                    // immediately increment i.
                    i++;
                }
                else
                {
                    // put the value of the right array into the main array
                    arr[k] = right[j];
                    // increment the pointer of the right
                    j++;
                }
                // increment the pointer in the main array
                k++;
            }


            if (i == left.Length)
            {
                // copy right array into main array
                Array.Copy(right, j, arr, k, right.Length - j);
            }
            else
            {
                // copy left array into main array
                Array.Copy(left, i, arr, k, left.Length - i);
            }

            return arr;

        }
    }
}
