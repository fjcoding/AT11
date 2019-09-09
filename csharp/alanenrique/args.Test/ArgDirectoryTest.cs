using System;
using Xunit;

namespace args.Test
{
    public class ArgDirectoryTest
    {
        [Fact]
        public void WhenInputArgumentReturnFlagValue()
        {
            string argCut = "-d ";
           
            ArgDirectory directory = new ArgDirectory(argCut);

            var result = directory.ValueDirectory;
            var expected = "";

            Assert.Equal(expected, result);
        }
    }
}