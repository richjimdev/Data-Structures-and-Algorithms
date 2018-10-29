using EeneyMeeney;
using System;
using System.Collections.Generic;
using Xunit;

namespace EnneyMeeneyTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Testing that the algorythm works with any number, including higher than list count
        /// </summary>
        /// <param name="input">the number to count by</param>
        /// <param name="result">the expected result</param>
        [Theory]
        [InlineData(3, "Kendra")]
        [InlineData(1, "Suzzie")]
        [InlineData(2, "Allisa")]
        [InlineData(9, "Danul")]
        public void MethodReturnsAWinnerDependingOnInputCount(int input, string result)
        {
            //Arrange
            List<string> names = new List<string> { "Richard", "Danul", "Allisa", "Kendra", "Suzzie" };

            //Assert
            Assert.Equal(result, Program.MineyMo(names, input));
        }
    }
}
