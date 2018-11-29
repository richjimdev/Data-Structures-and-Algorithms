using Graphs.Classes;
using System;
using System.Collections.Generic;

namespace Graphs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Graph graph = new Graph();
            
            graph.Add("A");
            Print(graph.Nodes);

            graph.Add("B");
            Print(graph.Nodes);

            graph.AddEdge("A", "B", 3);
            PrintEdges(graph);

            graph.Append("B", "C", 2);
            PrintEdges(graph);

            Console.WriteLine("Message: " + graph.AddEdge("G", "A", 3));
            Console.WriteLine("Message: " + graph.Add("A"));

        }

        public static void Print(IEnumerable<GraphNode> input)
        {
            foreach (GraphNode node in input)
            {
                Console.Write(node.Value + " ");
            }
            Console.WriteLine();
            Console.WriteLine("====================================");
        }

        public static void PrintEdges(Graph graph)
        {
            foreach (GraphNode node in graph.Nodes)
            {
                Console.WriteLine("Node: " + node.Value + ", neighbors: ");
                foreach (Tuple<string, int> edge in node.Edges)
                {
                    Console.Write(edge.Item1 + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("===============================");
        }

    }
}
