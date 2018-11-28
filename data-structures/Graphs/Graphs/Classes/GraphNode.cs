using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class GraphNode
    {
        public string Value;
        public List<string> Edges = new List<string>();

        public GraphNode(string value)
        {
            Value = value;
        }
    }
}
