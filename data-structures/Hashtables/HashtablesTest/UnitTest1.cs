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
        /// <param name="value">Value to add</param>
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

        /// <summary>
        /// Testing that a colliding key can be added
        /// </summary>
        /// <param name="val1">First value to add</param>
        /// /// <param name="val1">Colliding value to add</param>
        [Theory]
        [InlineData("Top", "Pot")]
        [InlineData("Dog", "God")]
        [InlineData("Cool", "Loco")]
        public void CanAddCollisonsOnHashtable(string val1, string val2)
        {
            //Arrange
            Hashtable hs = new Hashtable();

            //Act
            hs.Add(val1, "Value");
            hs.Add(val2, "Value 2");

            //Assert
            Assert.Equal("Value 2" , hs.Find(val2));
        }
    }
}
