using System;
using System.Collections.Generic;
using Tree.Classes;
using Xunit;

namespace TreeTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 4, 5)]
        [InlineData(6, 7, 8)]
        public void PreOrderReturnRootValueAtFirstIndex(int a, int b, int c)
        {
            //Arrange
            BinaryTree tree = new BinaryTree(new Node(a));
            tree.Root.Left = new Node(b);
            tree.Root.Right = new Node(c);

            List<Node> result = tree.PreOrder(tree.Root);

            //Assert
            Assert.Equal(a, result[0].Value);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 4, 5)]
        [InlineData(6, 7, 8)]
        public void InOrderReturnRootValueAtSecondIndex(int a, int b, int c)
        {
            //Arrange
            BinaryTree tree = new BinaryTree(new Node(a));
            tree.Root.Left = new Node(b);
            tree.Root.Right = new Node(c);

            List<Node> result = tree.InOrder(tree.Root);

            //Assert
            Assert.Equal(a, result[1].Value);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 4, 5)]
        [InlineData(6, 7, 8)]
        public void PostOrderReturnRootValueAtThirdIndex(int a, int b, int c)
        {
            //Arrange
            BinaryTree tree = new BinaryTree(new Node(a));
            tree.Root.Left = new Node(b);
            tree.Root.Right = new Node(c);

            List<Node> result = tree.PostOrder(tree.Root);

            //Assert
            Assert.Equal(a, result[2].Value);
        }

        [Fact]
        public void BinarySearchTreeAddAddsSmallerNodeToLeft()
        {
            //Arrange
            BinarySearchTree searchTree = new BinarySearchTree(new Node(100));

            searchTree.Add(new Node(50), searchTree.Root);

            //Assert
            Assert.Equal(50, searchTree.Root.Left.Value);
        }

        [Fact]
        public void BinarySearchTreeAddAddsBiggerNodeToRight()
        {
            //Arrange
            BinarySearchTree searchTree = new BinarySearchTree(new Node(100));

            searchTree.Add(new Node(150), searchTree.Root);

            //Assert
            Assert.Equal(150, searchTree.Root.Right.Value);
        }

        [Fact]
        public void BinarySearchTreeAddingExistingValueThrowsException()
        {
            //Arrange
            BinarySearchTree searchTree = new BinarySearchTree(new Node(100));

            try
            {
                searchTree.Add(new Node(150), searchTree.Root);
            }
            catch (Exception e)
            {
                string message = e.Message;
                //Assert
                Assert.Equal("Value already exists in tree.", message);
            }
            //Node searchResult = searchTree.Search(new Node(50), searchTree.Root);

        }

        [Theory]
        [InlineData(50)]
        [InlineData(150)]
        public void BinarySearchSearchFindsExistingValues(int val)
        {
            //Arrange
            BinarySearchTree searchTree = new BinarySearchTree(new Node(100));

            searchTree.Add(new Node(50), searchTree.Root);
            searchTree.Add(new Node(150), searchTree.Root);

            //Assert
            Assert.Equal(val, searchTree.Search(val, searchTree.Root).Value);
        }

        [Fact]
        public void BinarySearchSearchReturnsNullIfValueNotFound()
        {
            //Arrange
            BinarySearchTree searchTree = new BinarySearchTree(new Node(100));

            searchTree.Add(new Node(150), searchTree.Root);

            //Assert
            Assert.Null(searchTree.Search(123, searchTree.Root));
        }
    }
}
