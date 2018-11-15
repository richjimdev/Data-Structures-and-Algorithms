using System;
using Xunit;
using RepeatedWord;

namespace RepeatedWordTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Testing that a repeated word is returned
        /// </summary>
        /// <param name="input"></param>
        [Theory]
        [InlineData("hi")]
        [InlineData("yes")]
        [InlineData("word")]
        public void ReturnsRepeatedWords(string input)
        {
            //Arrange
            string fullWords = $"Hello there, {input} {input} {input}";

            //Act
            string result = Program.Repeated(fullWords);

            //Assert
            Assert.Equal(input, result);
        }

        /// <summary>
        /// Testing that NO DUPLICATES is returned when no duplicates exist
        /// </summary>
        /// <param name="input">Input string</param>
        [Theory]
        [InlineData("Hello there, no repeated words here!")]
        [InlineData("")]
        [InlineData("14$@%$(*TRNAefaAE")]
        public void ReturnsNotFoundForNoRepeats(string input)
        {
            //Act
            string result = Program.Repeated(input);

            //Assert
            Assert.Equal("NO DUPLICATES", result);
        }
    }
}
