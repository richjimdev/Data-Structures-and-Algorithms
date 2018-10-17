using System;
using System.Collections.Generic;
using Day06_LinkedList.Classes;

namespace LinkedListFromEnd
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static object FindKthElement(LList list, int k)
        {
            int count = 0;
            object result = null;

            list.Current = list.Head;

            while ( list.Current != null)
            {
                count++;
                list.Current = list.Current.Next;
            }
            list.Current = list.Head;

            count -= k;
            if (count < 0) throw new Exception("Invalid input number.");

            for (int i = 0; i < count - 1; i++)
            {
                list.Current = list.Current.Next;
            }

            result = list.Current.Value;
            list.Current = list.Head;

            return result;
        }
    }
}
