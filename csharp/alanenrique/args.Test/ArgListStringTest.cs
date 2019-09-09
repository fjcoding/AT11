using System;
using Xunit;

namespace args.Test
{
    public class ArgListStringTest
    {
        [Fact]
        public void WhenInputArgumentReturnFlagValue()
        {
            string argCut = "-g  ";
           
            ArgListString listString = new ArgListString(argCut);

            var result = listString.ValueListString;
            var expected = "";

            Assert.Equal(expected, result);
        }
    }
}