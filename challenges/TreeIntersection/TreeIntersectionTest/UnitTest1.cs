using System;
using System.Collections.Generic;
using Tree.Classes;
using TreeIntersection;
using Xunit;

namespace TreeIntersectionTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Testing that a duplicate value on a tree will be recorded
        /// </summary>
        /// <param name="value">Value to test</param>
        [Theory]
        [InlineData(100)]
        [InlineData(50)]
        [InlineData(300)]
        public void CanFindDuplicateValues(int value)
        {
            //Arrange
            BinaryTree a = new BinaryTree(new Node(value));
            BinaryTree b = new BinaryTree(new Node(50));

            b.Root.Left = new Node(100);
            b.Root.Right = new Node(300);

            //Act
            List<string> result = Program.Intersect(a, b);

            //Assert
            Assert.Contains(value.ToString(), result);
        }


    }
}
