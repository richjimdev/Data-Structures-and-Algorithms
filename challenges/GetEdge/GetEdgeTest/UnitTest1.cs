using Graphs.Classes;
using System;
using System.Collections.Generic;
using Xunit;
using static GetEdge.Program;

namespace GetEdgeTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Test that possible trips return true
        /// </summary>
        /// <param name="idx">Index of array to test</param>
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void PossibleTripsReturnTrue(int idx)
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

            string[] trip1 = { "Seattle", "LA", "Houston" };
            string[] trip2 = { "Seattle", "LA", "Houston", "NYC", "Miami" };
            string[] trip3 = { "Seattle", "LA", "Houston", "NYC", "Miami", "Chicago", "Boise" };

            string[][] holder = { trip1, trip2, trip3 };

            string[] singleTrip = holder[idx];

            var result = GetEdges(graph, singleTrip);

            Assert.True(result.Item1);
        }

        /// <summary>
        /// Not possible trips return false
        /// </summary>
        /// <param name="idx">Idx of trip</param>
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void NotPossibleTripsReturnFalse(int idx)
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

            string[] trip1 = { "Seattle", "Houston" };
            string[] trip2 = { "Seattle", "LA", "NYC" };
            string[] trip3 = { "Houston", "LA", "Miami" };

            string[][] holder = { trip1, trip2, trip3 };

            string[] singleTrip = holder[idx];

            var result = GetEdges(graph, singleTrip);

            Assert.False(result.Item1);
        }

        /// <summary>
        /// Possible trips return total price
        /// </summary>
        /// <param name="idx">Trip to select</param>
        /// <param name="price">Expected price</param>
        [Theory]
        [InlineData(0, 130)]
        [InlineData(1, 230)]
        [InlineData(2, 380)]
        public void PossibleTripsReturnTotalPrice(int idx, int price)
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

            string[] trip1 = { "Seattle", "LA", };
            string[] trip2 = { "Seattle", "LA", "Houston" };
            string[] trip3 = { "Seattle", "LA", "Houston", "NYC" };

            string[][] holder = { trip1, trip2, trip3 };

            string[] singleTrip = holder[idx];

            var result = GetEdges(graph, singleTrip);

            Assert.Equal(price, result.Item2);
        }
    }
}
