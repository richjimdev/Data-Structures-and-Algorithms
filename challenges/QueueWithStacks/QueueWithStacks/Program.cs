using QueueWithStacks.Classes;
using StackAndQueue.Classes;
using System;

namespace QueueWithStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);

            Stack myStack = new Stack(null);
            
            QueueStack myQueue = new QueueStack(myStack);

            Console.WriteLine($"Enqueue: {node1.Value}");
            myQueue.Enqueue(node1);
            Console.WriteLine($"Enqueue: {node2.Value}");
            myQueue.Enqueue(node2);
            Console.WriteLine($"Enqueue: {node3.Value}");
            myQueue.Enqueue(node3);
            Console.WriteLine($"Enqueue: {node4.Value}");
            myQueue.Enqueue(node4);

            Console.WriteLine($"Deque: {myQueue.Dequeue().Value}");
            Console.WriteLine($"Deque: {myQueue.Dequeue().Value}");
            Console.WriteLine($"Deque: {myQueue.Dequeue().Value}");
            Console.WriteLine($"Deque: {myQueue.Dequeue().Value}");
        }
    }
}
