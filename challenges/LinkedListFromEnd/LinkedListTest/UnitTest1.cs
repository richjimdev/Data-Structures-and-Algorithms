using System;
using Xunit;
using Day06_LinkedList.Classes;
using LinkedListFromEnd;
using static LinkedListFromEnd.Program;

namespace LinkedListTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Testing that outputs are correct based on desired index.
        /// </summary>
        /// <param name="input">Number</param>
        /// <param name="expected"></param>
        [Theory]
        [InlineData(0, "g")]
        [InlineData(1, "f")]
        [InlineData(2, "e")]
        [InlineData(3, "d")]
        [InlineData(4, "c")]
        [InlineData(5, "b")]
        [InlineData(6, "a")]
        public void InputReturnsCorrectOutput(int input, object expected)
        {
            //arrange
            Node node1 = new Node("a");
            Node node2 = new Node("b");
            Node node3 = new Node("c");
            Node node4 = new Node("d");
            Node node5 = new Node("e");
            Node node6 = new Node("f");
            Node node7 = new Node("g");
            Node[] nodeArr = { node6, node5, node4, node3, node2, node1 };

            LList list1 = new LList(node7);

            foreach (Node node in nodeArr)
                list1.Add(node);

            //Assert
            Assert.Equal(expected, FindKthElement(list1, input));
        }

        [Fact]
        public void InputOutsideOfRangeReturnsException()
        {
            //arrange
            Node node1 = new Node("a");
            Node node2 = new Node("b");
            Node node3 = new Node("c");
            Node node4 = new Node("d");
            Node node5 = new Node("e");
            Node node6 = new Node("f");
            Node node7 = new Node("g");
            Node[] nodeArr = { node6, node5, node4, node3, node2, node1 };

            LList list1 = new LList(node7);

            foreach (Node node in nodeArr)
                list1.Add(node);

            //Assert
            Assert.Throws<Exception>(() => FindKthElement(list1, 9));
        }
    }
}
