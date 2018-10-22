using Day06_LinkedList.Classes;
using ReverseLList;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ReverseListReversesList()
        {
            //Arrange
            LList myList = new LList(new Node(1));

            for (int i = 2; i < 5; i++)
            {
                myList.Append(new Node(i));
            }

            Program.RichardReverse(myList);

            //Assert
            Assert.Equal(4, myList.Head.Value);
        }

        [Fact]
        public void ReverseListReversesListInProperOrder()
        {
            //Arrange
            LList myList = new LList(new Node(1));

            for (int i = 2; i < 5; i++)
            {
                myList.Append(new Node(i));
            }

            Program.RichardReverse(myList);

            //Assert
            Assert.Equal(3, myList.Head.Next.Value);
        }

        [Fact]
        public void ReverseLinkedListDoesNotBreakOnListWithOneNode()
        {
            //Arrange
            LList myList = new LList(new Node(1));

            Program.RichardReverse(myList);

            //Assert
            Assert.Equal(1, myList.Head.Value);
        }
    }
}
