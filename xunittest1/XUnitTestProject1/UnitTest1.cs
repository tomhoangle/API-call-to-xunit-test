using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void SuccessTest()
        {
            Assert.Equal(4, 4);
        }

        [Fact]
        public void FailTest()
        {
            Assert.Equal(4, 5);
        }
    }
}
