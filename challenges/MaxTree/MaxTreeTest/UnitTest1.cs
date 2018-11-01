using MaxTree;
using System;
using Tree.Classes;
using Xunit;

namespace MaxTreeTest
{
    /// <summary>
    /// Testing that our method returns the highest value, even if negative
    /// </summary>
    public class UnitTest1
    {
        [Theory]
        [InlineData(0)]
        [InlineData(2)]
        [InlineData(50)]
        [InlineData(-10)]
        public void Test1(int highest)
        {
            //Arrange
            BinaryTree tree = new BinaryTree(new Node(highest));
            tree.Root.Left = new Node(highest - 2);

            //Assert
            Assert.Equal(highest, Program.FindMax(tree.Root));
        }
    }
}
