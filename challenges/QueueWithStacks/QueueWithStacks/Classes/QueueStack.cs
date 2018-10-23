using StackAndQueue.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.Classes
{
    /// <summary>
    /// Created a queue using two stacks to hold it's data. One stack hold everything and the second stack temporarilly holds data when Dequeing.
    /// </summary>
    public class QueueStack
    {
        public Stack A { get; set; }
        public Stack B { get; set; }

        /// <summary>
        /// Adds a node to the top of the first stack
        /// </summary>
        /// <param name="node">The node to add</param>
        public void Enqueue(Node node)
        {
            A.Push(node);
        }

        /// <summary>
        /// Removes a node from the bottom of the stack, since our qeueue requires a first in first out approach.
        /// </summary>
        /// <returns>Returns the removed Node</returns>
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

        /// <summary>
        /// Our constructor instantiates the Queue with two stacks, taking in a premade stack if desired
        /// </summary>
        /// <param name="one">First stack (can be a stack with null node as well)</param>
        public QueueStack(Stack one)
        {
            A = one;
            B = new Stack(null);
        }
    }
}
