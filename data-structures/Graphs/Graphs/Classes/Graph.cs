using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class Graph
    {
        public List<GraphNode> Nodes = new List<GraphNode>();

        /// <summary>
        /// Adds a floating node to the graph
        /// </summary>
        /// <param name="value">Value of the node to create</param>
        /// <returns>Confirmation or error message</returns>
        public string Add(string value)
        {
            if (Find(value) == null)
            {
                Nodes.Add(new GraphNode(value));
                return "Node Added";
            }
            else
                return "Node with that value already exists";
        }

        /// <summary>
        /// Finds a node in the graph
        /// </summary>
        /// <param name="value">Value of node to find</param>
        /// <returns>Found node, or null if not found</returns>
        private GraphNode Find(string value)
        {
            foreach (GraphNode node in Nodes)
            {
                if (node.Value == value)
                    return node;
            }

            return null;
        }

        /// <summary>
        /// Adds an edge between two existing nodes
        /// </summary>
        /// <param name="a">Value of first node</param>
        /// <param name="b">Value of second node</param>
        /// <param name="weight">Weight to give to edge</param>
        /// <returns>Confirmation or error message</returns>
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
                    node.Edges.Add(new Tuple<string, int>(b, weight));
                }
                if (node.Value == b)
                {
                    node.Edges.Add(new Tuple<string, int>(a, weight));
                }
            }

            return "Edge Added";
        }

        /// <summary>
        /// Adds a node and connects an edge to an existing node
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="node"></param>
        /// <param name="weight"></param>
        /// <returns></returns>
        public string Append(string parent, string node, int weight)
        {
            if (Find(parent) == null)
                return "Parent does not exist";
            Add(node);
            AddEdge(parent, node, weight);

            return "Added node and edge";
        }

        /// <summary>
        /// Returns all nodes that are connected to input node
        /// </summary>
        /// <param name="value">Node to check neighbors off</param>
        /// <returns>List of neighbor nodes</returns>
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

        /// <summary>
        /// Returns all nodes in graph (can also access using graph.Nodes)
        /// </summary>
        /// <returns>List of all nodes</returns>
        public List<GraphNode> GetNodes()
        {
            return Nodes;
        }

        /// <summary>
        /// Returns the number of nodes in Graph (Can also use graph.Nodes.Count)
        /// </summary>
        /// <returns>Number of nodes in graph</returns>
        public int Size()
        {
            return Nodes.Count;
        }
    }
}
