using Graphs.Classes;
using System;
using System.Collections.Generic;
using Xunit;

namespace GraphsTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Test that nodes can be added
        /// </summary>
        /// <param name="value">Value of node to add</param>
        /// <param name="expected">Expected result message</param>
        [Theory]
        [InlineData("A", "Node Added")]
        [InlineData("B", "Node Added")]
        [InlineData("C", "Node with that value already exists")]
        public void AddCreatesNodeInGraph(string value, string expected)
        {
            Graph graph = new Graph();
            graph.Add("C");

            string result = graph.Add(value);

            Assert.Equal(expected, result);
        }

        /// <summary>
        /// Test that edges can be added
        /// </summary>
        /// <param name="value">Node to add edge too</param>
        /// <param name="expected">Expected message</param>
        [Theory]
        [InlineData("B", "Edge Added")]
        [InlineData("C", "Edge Added")]
        [InlineData("D", "One or both input nodes do not exist")]
        public void AddEdgesCreatesEdgesInGraph(string value, string expected)
        {
            Graph graph = new Graph();
            graph.Add("A");
            graph.Add("B");
            graph.Add("C");

            string result = graph.AddEdge("A", value, 1);

            Assert.Equal(expected, result);
        }

        /// <summary>
        /// Testing that ount returns the count of nodes
        /// </summary>
        /// <param name="length">Length to test</param>
        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(1)]
        public void CountReturnsCount(int length)
        {
            Graph graph = new Graph();

            for (int i = 0; i < length; i++)
                graph.Add(i.ToString());

            Assert.Equal(length, graph.Size());
        }

        /// <summary>
        /// Tests that neighbors method returns the node's methods
        /// </summary>
        /// <param name="input">Node to test</param>
        /// <param name="expected">Count of neighbors</param>
        [Theory]
        [InlineData("A", 2)]
        [InlineData("B", 2)]
        [InlineData("C", 3)]
        public void NeighborsReturnsTotalNodeNeighbors(string input, int expected)
        {
            Graph graph = new Graph();
            graph.Add("A");
            graph.Add("B");
            graph.Add("C");
            graph.Add("D");

            graph.AddEdge("A", "B", 1);
            graph.AddEdge("B", "C", 1);
            graph.AddEdge("C", "A", 1);
            graph.AddEdge("C", "D", 1);

            List<GraphNode> result = graph.Neighbors(input);

            Assert.Equal(expected, result.Count);
        }
    }
}
