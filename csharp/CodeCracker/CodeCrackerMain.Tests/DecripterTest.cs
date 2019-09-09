using System;
using CodeCrackerMain;
using Xunit;

namespace CodeCrackerMain.Tests
{
    public class DecripterTest
    {
        private readonly Decripter _decripter;

        public DecripterTest()
        {
            _decripter = new Decripter();
        }

        [Fact]
        public void WhenSendALeterReturnDecripted()
        {
            //a b c d e f g h i j k l m n o p q r s t u v w x y z
            //! ) $ ( £ * % & > < @ a b c d e f g h i j k l m n o 
            string letter = "£";
            var result = _decripter.DecryptLetters(letter);
            var expected = "e";
            Assert.Equal(expected,result);
        }

        [Fact]
        public void WhenSendTwoLeterReturnDecripted()
        {
            //a b c d e f g h i j k l m n o p q r s t u v w x y z
            //! ) $ ( £ * % & > < @ a b c d e f g h i j k l m n o 
            string letter = "$!";
            var result = _decripter.DecryptLetters(letter);
            var expected = "ca";
            Assert.Equal(expected,result);
        }
        
        [Fact]
        public void WhenSendAWordReturnDecripted()
        {
            //a b c d e f g h i j k l m n o p q r s t u v w x y z
            //! ) $ ( £ * % & > < @ a b c d e f g h i j k l m n o 
            string letter = "&£aad";
            var result = _decripter.DecryptLetters(letter);
            var expected = "hello";
            Assert.Equal(expected,result);
        }

        [Fact]
        public void WhenSendALongWordReturnDecripted()
        {
            //a b c d e f g h i j k l m n o p q r s t u v w x y z
            //! ) $ ( £ * % & > < @ a b c d e f g h i j k l m n o 
            string letter = "&£aadldga(";
            var result = _decripter.DecryptLetters(letter);
            var expected = "helloworld";
            Assert.Equal(expected,result);
        }

        [Fact]
        public void WhenSendAWorngWordReturnError()
        {
            //a b c d e f g h i j k l m n o p q r s t u v w x y z
            //! ) $ ( £ * % & > < @ a b c d e f g h i j k l m n o 
            string letter = "a3adl 3";
            var result = _decripter.DecryptLetters(letter);
            var expected = "Error!";
            Assert.Equal(expected,result);
        }
    }
}
