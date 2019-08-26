using System;
using bankocr;
using Xunit;

namespace TestScanner.Tests
{
    public class TestScanner
    {
        private readonly Scanner _scanner;
        public TestScanner()
        {
            _scanner = new Scanner();    
        }
        [Fact]
        public void Test_input_scanner_hope()
        {
            String line1input = "qwertyuiopasdfghjklñzxcvbnm";
            String line2input = "qwertyuiopasdfghjklñzxcvbnm";       
            String line3input = "qwertyuiopasdfghjklñzxcvbnm";

            var result = _scanner.verifyLength(line1input, line2input , line3input);
            var expected = true;

            Assert.Equal(expected,result);
        }
        [Fact]
        public void Test_input_scanner_incomplete()
        {
            String line1input = "qwertyuiopasdfghjklñ";
            String line2input = "qwertyuiopasdfghjklñzxcvbnm";       
            String line3input = "q";

            var result = _scanner.verifyLength(line1input, line2input , line3input);
            var expected = false;

            Assert.Equal(expected,result);
        }
        [Fact]
        public void Test_input_scanner_empty()
        {
            String line1input = "";
            String line2input = "";       
            String line3input = "";

            var result = _scanner.verifyLength(line1input, line2input , line3input);
            var expected = false;

            Assert.Equal(expected,result);
        }
    }
}