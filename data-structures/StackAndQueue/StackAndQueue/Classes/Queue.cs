using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
    /// <summary>
    /// A class for Queue data structure
    /// </summary>
    class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }

        public Node Peek()
        {
            return Front;
        }

        public void Enqueue(Node node)
        {
            Rear.Next = node;
            Rear = node;
        }

        public Node Dequeue()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }
    }
}
