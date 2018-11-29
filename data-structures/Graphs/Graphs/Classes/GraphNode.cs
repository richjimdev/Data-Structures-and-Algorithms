using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class GraphNode
    {
        public string Value;
        public List<Tuple<string, int>> Edges = new List<Tuple<string, int>>();

        public GraphNode(string value)
        {
            Value = value;
        }
    }
}
