using System;
using Xunit;
using Day06_LinkedList.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CreateListCreatesNewListWithGivenNode()
        {
            Node node1 = new Node(5);
            LList list1 = new LList(node1);

            Assert.Equal(list1.Head.Value, node1.Value);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(67)]
        [InlineData("hi")]
        public void AddAddsNode(object value)
        {
            //Arrange
            Node node1 = new Node(1);
            Node node2 = new Node(value);

            LList list1 = new LList(node1);
            list1.Add(node2);

            //Assert
            Assert.True(list1.Includes(value));
        }

        [Theory]
        [InlineData("hi")]
        [InlineData("test")]
        [InlineData(17)]
        public void AddBeforeAddsNode(object value)
        {
            //Arrange
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(value);
            LList list2 = new LList(node1);

            list2.Add(node2);
            list2.Add(node3);

            list2.AddBefore(node4, node2);

            //Assert
            Assert.True(list2.Includes(value));
        }

        [Theory]
        [InlineData("hi")]
        [InlineData(45)]
        [InlineData("me")]
        public void AddAfterAddsNode(object value)
        {
            //Arrange
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(value);
            LList list2 = new LList(node1);

            list2.Add(node2);
            list2.Add(node3);

            list2.AddAfter(node4, node2);

            //Assert
            Assert.True(list2.Includes(value));
        }

    }
}
