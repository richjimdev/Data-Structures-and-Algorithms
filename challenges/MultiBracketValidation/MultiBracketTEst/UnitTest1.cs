using System;
using Xunit;
using static MultiBracketValidation.Program;

namespace MultiBracketTEst
{
    public class UnitTest1
    {
        /// <summary>
        /// Testing that a balanced input will return a true statement
        /// </summary>
        /// <param name="input">Strings to test</param>
        [Theory]
        [InlineData("{}(){}")]
        [InlineData("()[[Extra Characters]]")]
        [InlineData("{}{Code}[Fellows](())")]
        [InlineData("{{{}}}")]
        public void ReturnsTrueOnBalancedInput(string input)
        {
            //Assert
            Assert.True(MultiBracketVal(input));
        }

        /// <summary>
        /// Testing that an unbalanced input returns false
        /// </summary>
        /// <param name="input">Strings to test</param>
        [Theory]
        [InlineData("[({}]")]
        [InlineData("{(})")]
        [InlineData("{(({[{")]
        public void ReturnsFalseOnUnbalancedInput(string input)
        {
            //Assert
            Assert.False(MultiBracketVal(input));
        }

        /// <summary>
        /// In our case, we want an empty string to return false
        /// </summary>
        [Fact]
        public void ReturnFalseOnEmptyString()
        {
            //Assert
            Assert.False(MultiBracketVal(""));
        }
    }
}
