using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class Graph
    {
        public List<GraphNode> Nodes = new List<GraphNode>();

        public void Add(string value)
        {
            Nodes.Add(new GraphNode(value));
        }

        private GraphNode Find(string value)
        {
            foreach (GraphNode node in Nodes)
            {
                if (node.Value == value)
                    return node;
            }

            return null;
        }

        public string AddEdge(string a, string b, int weight)
        {
            if (Find(a) == null || Find(b) ==null)
            {
                return "One or both input nodes do not exist";
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
            if (Find(parent) == null)
                return "Parent does no exist";
            Add(node);
            AddEdge(parent, node, weight);

            return "Added node and edge";
        }

        public List<GraphNode> Neighbors(string value)
        {
            GraphNode root = Find(value);

            if (root == null)
                throw new Exception("Node does not exist");

            List<GraphNode> neighbors = new List<GraphNode>();

            foreach (Tuple<string, int> edge in root.Edges)
            {
                GraphNode node = Find(edge.Item1);
                neighbors.Add(node);
            }

            return neighbors;
        }

        public List<GraphNode> GetNodes()
        {
            return Nodes;
        }

        public int Size()
        {
            return Nodes.Count;
        }
    }
}
