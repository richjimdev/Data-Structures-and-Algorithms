using System;
using Xunit;
using static FibbonaciSequence.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(3, FindFib(3));
        }
        
        [Fact]
        public void Test3()
        {
            Assert.Equal(21, FindFib(7));
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(89, FindFib(10));
        }
    }
}
