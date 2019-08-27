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
        public void testScanner()
        {
            string expected = "123456789";
            string stringNumber =
           "    _  _     _  _  _  _  _ \n"+
           "  | _| _||_||_ |_   ||_||_|\n"+
           "  ||_  _|  | _||_|  ||_| _|";

           string result = _main.verifyNumber(stringNumber);
           Assert.Equal(result, expected);
        }
    }
}
