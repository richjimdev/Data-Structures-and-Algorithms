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



    }
}
