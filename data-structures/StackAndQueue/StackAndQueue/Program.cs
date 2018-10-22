using StackAndQueue.Classes;
using System;

namespace StackAndQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Creating nodes
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);

            //Creating queue
            Queue myQueue = new Queue(node1);
            myQueue.Enqueue(node2);
            myQueue.Enqueue(node3);
            myQueue.Enqueue(node4);
            myQueue.Enqueue(node5);

            //Peeking and Dequeing Queue
            Console.WriteLine("Queue:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Peek #{i}: ");
                Console.WriteLine($"{myQueue.Peek().Value}");

                Node removedNode = myQueue.Dequeue();
                Console.WriteLine(removedNode.Value);
            }

            //Creating stack
            Stack myStack = new Stack(node1);
            myStack.Push(node2);
            myStack.Push(node3);
            myStack.Push(node4);
            myStack.Push(node5);

            //Peeking and popping stack
            Console.WriteLine("==================");
            Console.WriteLine("Stack:");
            Console.WriteLine($"First peek: {myStack.Peek().Value}");
            myStack.Pop();
            Console.WriteLine($"Second peek: {myStack.Peek().Value}");
            myStack.Pop();
            Console.WriteLine($"Third peek: {myStack.Peek().Value}");
            myStack.Pop();
            Console.WriteLine($"Fourth peek: {myStack.Peek().Value}");
            myStack.Pop();
            Console.WriteLine($"Fifth peek: {myStack.Peek().Value}");
            myStack.Pop();
        }
    }
}
