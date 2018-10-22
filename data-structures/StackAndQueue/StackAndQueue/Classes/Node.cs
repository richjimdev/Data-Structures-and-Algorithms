using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
    /// <summary>
    /// Node class to hold our nodes
    /// </summary>
    public class Node
    {
        public object Value { get; set; }
        public Node Next { get; set; }

        public Node(object value)
        {
            Value = value;
        }

    }
}
