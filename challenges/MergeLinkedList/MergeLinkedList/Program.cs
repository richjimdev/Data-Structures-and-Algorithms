using Day06_LinkedList.Classes;
using System;

namespace MergeLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node node1 = new Node(1);
            Node node2 = new Node(12);

            LList one = new LList(node1);
            LList two = new LList(node2);


            for (int i = 3; i < 8; i++)
            {
                Node newNode = new Node(i);
                Node newNode2 = new Node(i+10);
                one.Append(newNode);
                two.Append(newNode2);
            }

            one.Print();
            two.Print();

            Merge(one, two);

            one.Print();
        }

        public static Node Merge(LList a, LList b)
        {
            a.Current = a.Head;
            b.Current = b.Head;
            while (a.Current.Next != null && b.Current.Next != null)
            {
                Node tempA = a.Current.Next;
                Node tempB = b.Current.Next;

                a.Current.Next = b.Current;
                b.Current.Next = tempA;

                a.Current = tempA;
                b.Current = tempB;
            }

            if (a.Current.Next == null)
            {
                a.Current.Next = b.Current;
            }
            else if (b.Current.Next == null)
            {
                b.Current.Next = a.Current.Next;
                a.Current.Next = b.Current;
            }
            return a.Head;
        }
    }
}
