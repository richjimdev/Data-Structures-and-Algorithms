using Day06_LinkedList.Classes;
using System;
using Xunit;
using static MergeLinkedList.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ConfirmThatMergedLinkedListHeadNodeIsSameAsFirstInputLinkedList()
        {
            LList a = new LList(new Node(1));
            LList b = new LList(new Node(2));

            //Assert
            Assert.Equal(a.Head.Value, Merge(a, b).Value);
        }

        [Fact]
        public void ConfirmThatMergedLinkedListSecondNodeIsHeadNodeOfSecondLinkedList()
        {
            LList a = new LList(new Node(1));
            LList b = new LList(new Node(2));

            //Assert
            Assert.Equal(b.Head.Value, Merge(a, b).Next.Value);
        }

        [Fact]
        public void ConfirmThatListACanBeLongerThanListB()
        {
            LList a = new LList(new Node(1));// A Head
            LList b = new LList(new Node(2)); // B head

            a.Append(new Node(3)); // 2
            a.Append(new Node(4)); // 3
            a.Append(new Node(5)); // 4
            b.Append(new Node(6));// B1

            Merge(a, b);
            
            a.Current = a.Head; // spot 1
            a.Current = a.Current.Next; // spot 2
            a.Current = a.Current.Next; //spot 3
            a.Current = a.Current.Next; // spot 4 (after merge, will be B1)

            //Assert
            Assert.Equal(6, a.Current.Value);
        }

        [Fact]
        public void ConfirmThatListBCanBeLongerThanListA()
        {
            LList a = new LList(new Node(1));// A Head
            LList b = new LList(new Node(2)); // B head

            a.Append(new Node(3)); // A2
            b.Append(new Node(4)); // 2
            b.Append(new Node(5)); // 3
            b.Append(new Node(6));// 4

            Merge(a, b);

            a.Current = a.Head; // spot 1
            a.Current = a.Current.Next; // spot 2
            a.Current = a.Current.Next; //spot 3
            a.Current = a.Current.Next; // spot 4
            a.Current = a.Current.Next; // spot 5 (same as B3)

            //Assert
            Assert.Equal(5, a.Current.Value);
        }
    }
}
