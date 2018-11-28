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

        public void AddEdges(string a, string b)
        {
            int aIndex = FindNode(a);
            int bIndex = FindNode(b);

            if (aIndex == -1 || bIndex == -1)
                Nodes[aIndex].Edges.Add(b);

            Nodes[bIndex].Edges.Add(a);
        }

        public void Swap(string a, string b)
        {
            int aIndex = FindNode(a);
            int bIndex = FindNode(b);

            GraphNode temp = Nodes[aIndex];
            Nodes[aIndex] = Nodes[bIndex];
            Nodes[bIndex] = temp;
        }

        public void Delete(string x)
        {
            int position = FindNode(x);
            GraphNode[] temp = new GraphNode[Nodes.Length - 1];

            for (int i = 0; i < Nodes.Length; i++)
            {
                if (i < position)
                {
                    temp[i] = Nodes[i];
                }

                if (i > position)
                {
                    temp[i - 1] = Nodes[i];
                }
            }

            DeleteEdge(x);
            Nodes = temp;
            count--;
        }


    }
}
