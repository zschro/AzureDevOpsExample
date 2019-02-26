using System;
using Xunit;

namespace ExampleWebAppUnitTests
{
    public class ExampleWebAppTests
    {
        [Fact]
        public void PassingTest()
        {
            Assert.True(true);
        }
        [Fact]
        public void FailingTest()
        {
            Assert.True(false);
        }
    }
}
