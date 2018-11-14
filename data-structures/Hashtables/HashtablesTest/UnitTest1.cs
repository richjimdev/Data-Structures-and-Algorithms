using Hashtables.Classes;
using System;
using Xunit;

namespace HashtablesTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Testing that a value can be added
        /// </summary>
        /// <param name="test">Value to add</param>
        [Theory]
        [InlineData("Test")]
        [InlineData("Cat")]
        [InlineData("Dog")]
        public void CanAddToHashtable(string test)
        {
            //Arrange
            Hashtable hs = new Hashtable();

            //Act
            hs.Add(test, "value");

            //Assert
            Assert.True(hs.Contains(test));
        }

        /// <summary>
        /// Testing that a value can be found
        /// </summary>
        /// <param name="test">Value to add</param>
        [Theory]
        [InlineData("Test")]
        [InlineData("Cat")]
        [InlineData("Dog")]
        public void CanFindOnHashtable(string value)
        {
            //Arrange
            Hashtable hs = new Hashtable();

            //Act
            hs.Add("Key", value);

            //Assert
            Assert.Equal(value, hs.Find("Key"));
        }
    }
}
