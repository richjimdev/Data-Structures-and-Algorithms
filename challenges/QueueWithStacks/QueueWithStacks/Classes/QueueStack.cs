using StackAndQueue.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class QueueStack
    {
        public Stack A { get; set; }
        public Stack B { get; set; }

        public void Enqueue(Node node)
        {
            A.Push(node);
        }

        public Node Dequeue()
        {
            while (A.Top.Next != null)
            {
                B.Push(A.Pop());
            }
            Node temp = A.Pop();
            while (B.Top != null)
            {
                A.Push(B.Pop());
            }

            return temp;
        }

        public QueueStack(Stack one, Stack two)
        {
            A = one;
            B = two;
        }
    }
}
