using StackAndQueue.Classes;
using System;
using Xunit;
using static StackAndQueue.Program;

namespace SnQTest
{
    public class UnitTest1
    {
        [Fact]
        public void CreatingStackAddsNodeAtStackTop()
        {
            //Arrange
            Node node1 = new Node(1);
            Stack myStack = new Stack(node1);

            //Assert
            Assert.Equal(1, myStack.Top.Value);
        }

        [Fact]
        public void StackPushNodeAddsNodeToTopOfStack()
        {
            //Arrange
            Node node1 = new Node(1);
            Node node2 = new Node(2);

            Stack myStack = new Stack(node1);
            myStack.Push(node2);

            //Assert
            Assert.Equal(2, myStack.Top.Value);
        }

        [Fact]
        public void PeekShowsTopNodeOfStack()
        {
            //Arrange
            Node node1 = new Node(1);
            Node node2 = new Node(2);

            Stack myStack = new Stack(node1);
            myStack.Push(node2);

            //Assert
            Assert.Equal(2, myStack.Peek().Value);
        }

        [Fact]
        public void PopGrabsTopNodeFromStackAndGivesBackItsValue()
        {
            //Arrange
            Node node1 = new Node(1);
            Node node2 = new Node(2);

            Stack myStack = new Stack(node1);
            myStack.Push(node2);

            //Assert
            Assert.Equal(2, myStack.Pop().Value);
        }

        [Fact]
        public void PopRemovesTopNodeFromStack()
        {
            //Arrange
            Node node1 = new Node(1);
            Node node2 = new Node(2);

            Stack myStack = new Stack(node1);
            myStack.Push(node2);
            myStack.Pop();

            //Assert
            Assert.Equal(1, myStack.Top.Value);
        }
    }
}
