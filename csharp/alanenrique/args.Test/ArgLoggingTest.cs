using System;
using Xunit;

namespace args.Test
{
    public class ArgLoggingTest
    {
        [Fact]
        public void WhenInputArgumentReturnFlagValue()
        {
            string argCut = "-l  ";
           
            ArgLogging logging = new ArgLogging(argCut);

            var result = logging.ValueLogging;
            var expected = false;

            Assert.Equal(expected, result);
        }
    }
}