using StackAndQueue.Classes;
using System;
using Xunit;
using static StackAndQueue.Program;

namespace SnQTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Checking that a stack can be created
        /// </summary>
        [Fact]
        public void CreatingStackAddsNodeAtStackTop()
        {
            //Arrange
            Node node1 = new Node(1);
            Stack myStack = new Stack(node1);

            //Assert
            Assert.Equal(1, myStack.Top.Value);
        }

        /// <summary>
        /// Checking that a node can be pushed to stack
        /// </summary>
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

        /// <summary>
        /// Checking that Peek() works
        /// </summary>
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

        /// <summary>
        /// Checking that Pop() gives back the Node's value
        /// </summary>
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

        /// <summary>
        /// Checking that Pop removes the node from the stack
        /// </summary>
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

        /// <summary>
        /// Checking that Peek works for queues
        /// </summary>
        [Fact]
        public void QueuePeekShowsFrontNode()
        {
            //Arrange
            Node node1 = new Node(1);
            Node node2 = new Node(2);

            Queue myQueue = new Queue(node1);
            myQueue.Enqueue(node2);

            //Assert
            Assert.Equal(1, myQueue.Peek().Value);
        }

        /// <summary>
        /// Checking that enqueue adds node to queue
        /// </summary>
        [Fact]
        public void EnqueueAddsNodeToRear()
        {
            //Arrange
            Node node1 = new Node(1);
            Node node2 = new Node(2);

            Queue myQueue = new Queue(node1);
            myQueue.Enqueue(node2);

            //Assert
            Assert.Equal(2, myQueue.Rear.Value);
        }

        /// <summary>
        /// Checking that dequeue removes node from queue
        /// </summary>
        [Fact]
        public void DequeueRemovesFrontNode()
        {
            //Arrange
            Node node1 = new Node(1);
            Node node2 = new Node(2);

            Queue myQueue = new Queue(node1);
            myQueue.Enqueue(node2);
            myQueue.Dequeue();

            //Assert
            Assert.NotEqual(1, myQueue.Front.Value);
        }
    }
}
