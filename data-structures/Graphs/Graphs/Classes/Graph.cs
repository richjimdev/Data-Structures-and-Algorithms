using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class Graph
    {
        List<GraphNode> Nodes;

        public void Add(string value)
        {
            Nodes.Add(new GraphNode(value));
        }

        private bool Exists(string value)
        {
            foreach (GraphNode node in Nodes)
            {
                if (node.Value == value)
                    return true;
            }

            return false;
        }

        public string AddEdge(string a, string b, int weight)
        {
            if (!Exists(a) || !Exists(b))
            {
                return "Input nodes do not exist";
            }

            foreach (GraphNode node in Nodes)
            {
                if (node.Value == a)
                {
                    node.Edges.Add(new Tuple<string, int>(a, weight));
                }
                if (node.Value == b)
                {
                    node.Edges.Add(new Tuple<string, int>(b, weight));
                }
            }

            return "Edge Added";
        }

        public string Append(string parent, string node, int weight)
        {
            if (!Exists(parent))
                return "Parent does no exist";
            Add(node);
            AddEdge(parent, node, weight);

            return "Added node and edge";
        }
    }
}
