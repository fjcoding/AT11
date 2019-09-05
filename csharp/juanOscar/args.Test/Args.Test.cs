using System;
using args;
using Xunit;

namespace args.Tests
{
    public class ArgsTest
    {
        private readonly Parser _parser;

        public ArgsTest()
        {
            _parser = new Parser();
        }

        [Fact]
        public void TestVerifyBooeanArgumentIsValid()
        {
            var result = _parser.verifyBooeanArgumentIsValid("-l");
            Assert.True(result, "Error... Was expected -l");
        }
    }
}
