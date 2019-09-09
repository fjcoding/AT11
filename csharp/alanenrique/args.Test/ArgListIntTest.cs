using System;
using Xunit;

namespace args.Test
{
    public class ArgListIntTest
    {
        [Fact]
        public void WhenInputArgumentReturnFlagValue()
        {
            string argCut = "-d  ";
           
            ArgListInt listInt = new ArgListInt(argCut);

            var result = listInt.ValueListInt;
            var expected = 0;

            Assert.Equal(expected, result);
        }
    }
}