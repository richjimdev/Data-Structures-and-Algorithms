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


    }
}
