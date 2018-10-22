using Day06_LinkedList.Classes;
using System;

namespace ReverseLList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LList myList = new LList(new Node(1));

            for (int i = 2; i < 10; i++)
            {
                myList.Append(new Node(i));
            }

            Console.WriteLine("Input Linked List:");
            myList.Print();

            RichardReverse(myList);

            Console.WriteLine("Linked List, after modified in place:");
            myList.Print();
        }

        /// <summary>
        /// Takes in a linked list, and reverses it in place.
        /// </summary>
        /// <param name="LL">A Linked List</param>
        /// <returns>The same Linked List, now reversed</returns>
        public static LList RichardReverse(LList LL)
        {
            LL.Current = LL.Head.Next;
            Node prev = LL.Head;
            prev.Next = null;
            while (LL.Current != null)
            {
                Node runner = LL.Current.Next;
                LL.Current.Next = prev;
                prev = LL.Current;
                LL.Current = runner;
            }

            LL.Head = prev;
            return LL;
        }
    }
}
