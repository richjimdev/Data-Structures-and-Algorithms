using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class Graph
    {
        GraphNode[] Nodes;
        int count;

        public Graph(int size)
        {
            Nodes = new GraphNode[size];
            count = 0;
        }

        public void Add(string value)
        {
            Nodes[count++] = new GraphNode(value);
        }

        private int FindNode(string value)
        {
            for (int i = 0; i < Nodes.Length; i++)
            {
                if (Nodes[i].Value == value)
                    return i;
            }

            return -1;
        }
    }
}
