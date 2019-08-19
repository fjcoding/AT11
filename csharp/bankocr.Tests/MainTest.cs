using System;
using bankocr;
using Xunit;

namespace bankocr.Tests
{
    public class MainTest
    {
        private readonly Main _main;

        public MainTest()
        {
            _main = new Main();
        }

        [Fact]
        public void Test1()
        {
            var result = _main.returnTrue();
            Assert.True(result, "Result must be 'true'");
        }
    }
}
