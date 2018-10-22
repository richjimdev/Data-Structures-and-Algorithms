using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
    /// <summary>
    /// Stack data structure
    /// </summary>
    public class Stack
    {
        public Node Top { get; set; }

        public Stack(Node node)
        {
            Top = node;
        }

        public Node Peek()
        {
            try
            {
                return Top;
            }
            catch
            {
                return null;
            }
        }

        public Node Pop()
        {
            Node temp = Peek();
            Top = Top.Next;
            temp.Next = null;
            return temp;
        }

        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }
    }
}
