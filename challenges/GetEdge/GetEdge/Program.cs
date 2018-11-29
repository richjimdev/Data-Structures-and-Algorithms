using Graphs.Classes;
using System;
using System.Collections.Generic;

namespace GetEdge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Graph graph = new Graph();
            graph.Add("Seattle");
            graph.Append("Seattle", "LA", 130);
            graph.Append("LA", "Houston", 100);
            graph.Append("Seattle", "Boise", 120);
            graph.Append("Boise", "Chicago", 120);
            graph.Append("Houston", "Miami", 110);
            graph.Append("Houston", "NYC", 150);
            graph.AddEdge("Chicago", "Miami", 130);
            graph.AddEdge("Chicago", "NYC", 130);
            graph.AddEdge("NYC", "Miami", 120);
            graph.AddEdge("Boise", "Houston", 100);
            graph.AddEdge("LA", "Boise", 100);

            List<GraphNode> all = graph.Nodes;
            foreach (var node in all)
            {
                Console.WriteLine(node.Value);
                var neighbors = node.Edges;
                foreach (var edge in neighbors)
                    Console.WriteLine($"{node.Value} to {edge.Item1}: ${edge.Item2}");
            }
        }


    }
}
