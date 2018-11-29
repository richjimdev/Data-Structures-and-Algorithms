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

            Console.WriteLine("==============================");

            string[] trip1 = { "Seattle", "LA", "Houston" };

            var result = GetEdges(graph, trip1);
            Console.WriteLine($"Result, trip is possible: {result.Item1}, price: ${result.Item2}");

            string[] trip2 = { "Seattle", "LA", "Houston", "NYC", "Miami", "Chicago", "Boise" };

            var result2 = GetEdges(graph, trip2);
            Console.WriteLine($"Result, trip is possible: {result2.Item1}, price: ${result2.Item2}");

            string[] trip3 = { "Seattle", "Boise", "Miami" };

            var result3 = GetEdges(graph, trip3);
            Console.WriteLine($"Result, trip is possible: {result3.Item1}, price: ${result3.Item2}");
        }

        public static Tuple<bool, int> GetEdges(Graph graph, string[] trip)
        {
            int total = 0;

            for (int i = 0; i < trip.Length - 1; i++)
            {
                GraphNode city = graph.Find(trip[i]);
                bool connects = false;

                foreach (var edge in city.Edges)
                {
                    if(edge.Item1 == trip[i+1])
                    {
                        connects = true;
                        total += edge.Item2;
                        Console.WriteLine($"{ city.Value} connects to {edge.Item1}!");
                    }
                }

                if (!connects)
                {
                    Console.WriteLine($"{ city.Value} does not connect to {trip[i+1]}!");
                    return new Tuple<bool, int>(false, 0);
                }
            }
            
            return new Tuple<bool, int>(true, total);
        }


    }
}
