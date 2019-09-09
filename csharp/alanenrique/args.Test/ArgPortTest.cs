using System;
using Xunit;

namespace args.Test
{
    public class ArgPortTest
    {
        [Fact]
        public void WhenInputArgumentReturnFlagValue()
        {
            string argCut = "-p  ";
           
            ArgPort port = new ArgPort(argCut);

            var result = port.ValuePort;
            var expected = 0;

            Assert.Equal(expected, result);
        }
    }
}