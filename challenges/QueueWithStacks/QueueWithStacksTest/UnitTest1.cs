using QueueWithStacks.Classes;
using StackAndQueue.Classes;
using System;
using Xunit;

namespace QueueWithStacksTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Testing that the queue uses a first in first out approach
        /// </summary>
        [Fact]
        public void QueueFunctionsAsFIFO()
        {
            //Arrange
            Node node1 = new Node(1);
            Node node2 = new Node(2);

            Stack myStack = new Stack(node1);

            QueueStack myQueue = new QueueStack(myStack);
            myQueue.Enqueue(node2);

            //Asssert
            Assert.Equal(1, myQueue.Dequeue().Value);
        }

        /// <summary>
        /// Testing that dequeue returns null if there are no nodes in queue
        /// </summary>
        [Fact]
        public void DequeueReturnsNullIfNoNodesInQeueue()
        {
            //Arrange
            Stack myStack = new Stack(null);

            QueueStack myQueue = new QueueStack(myStack);

            //Asssert
            Assert.Null(myQueue.Dequeue());
        }

        /// <summary>
        /// Testing that enqueue adds nodes to the top of stacks, following stack's last in first out approach
        /// </summary>
        [Fact]
        public void EnqueueAddsNodeToTopOfStackA()
        {
            //Arrange
            Stack myStack = new Stack(new Node(1));

            QueueStack myQueue = new QueueStack(myStack);
            myQueue.Enqueue(new Node(2));

            //Asssert
            Assert.Equal(2, myQueue.A.Top.Value);
        }
    }
}
