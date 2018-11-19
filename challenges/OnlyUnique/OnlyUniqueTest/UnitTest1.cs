using OnlyUnique;
using System;
using Xunit;

namespace OnlyUniqueTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Testing true return on unique strings
        /// </summary>
        /// <param name="input">unique strings</param>
        [Theory]
        [InlineData("abcdef")]
        [InlineData("123 lmno")]
        [InlineData("$#^%!(@")]
        public void ReturnsTrueOnUniqueStrings(string input)
        {
            Assert.True(Program.Unique(input));
        }

        /// <summary>
        /// Testing false return on non unique strings
        /// </summary>
        /// <param name="input">non unqiue string</param>
        [Theory]
        [InlineData("aaaaaa")]
        [InlineData("repeat")]
        [InlineData("12 1 2")]
        public void ReturnsFalseOnNonUniqueStrings(string input)
        {
            Assert.False(Program.Unique(input));
        }
    }
}
