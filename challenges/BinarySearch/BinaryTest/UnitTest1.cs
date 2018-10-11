using System;
using Xunit;
using BinarySearch;
using static BinarySearch.Program;

namespace BinaryTest
{
    public class UnitTest1
    {
        [Fact]
        public void MethodReturnsCorrectIndex()
        {
            int[] inputArray = { 4, 8, 15, 16, 23, 42 };
            int value = 15;
            Assert.Equal(2, BinarySearchMethod(inputArray, value));
        }

        [Fact]
        public void MethodReturnsNegativeIndexForInputNotFound()
        {
            int[] inputArray = { 4, 8, 15, 16, 23, 42 };
            int value = 25;
            Assert.Equal(-1, BinarySearchMethod(inputArray, value));
        }

        [Fact]
        public void MethodWorksWhenItemIsAtFirstIndex()
        {
            int[] inputArray = { 4, 8, 15, 16, 23, 42 };
            int value = 4;
            Assert.Equal(0, BinarySearchMethod(inputArray, value));
        }
        
        [Fact]
        public void MethodWorksWhenItemIsAtLastIndex()
        {
            int[] inputArray = { 4, 8, 15, 16, 23, 42 };
            int value = 42;
            Assert.Equal(5, BinarySearchMethod(inputArray, value));
        }
    }
}
