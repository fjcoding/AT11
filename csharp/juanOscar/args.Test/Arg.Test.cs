using System;
using args;
using Xunit;

namespace args.Tests
{
    public class ArgTest
    {
        [Fact]
        public void TestVerifyFlag()
        {
            var arg = new Arg();
            Assert.True(arg.verifyFlag("-l"));
        }

        [Fact]
        public void TestVerifyIntegerValid()
        {
            var arg = new Arg();
            Assert.Equal(8080, arg.verifyIntegerValid("-p", 8080));
        }

        [Fact]
        public void TestVerifyStringValid()
        {
            var arg = new Arg();
            Assert.Equal("/usr/logserror", arg.verifyStringValid("-d", "/usr/logserror"));
        }

        [Fact]
        public void FaildTestVerifyStringValid()
        {
            var arg = new Arg();
            Assert.Equal("10", arg.verifyStringValid("-d", "/usr/logserror"));
        }
    }    
}