using System;
using CodeCrackerMain;
using Xunit;

namespace CodeCrackerMain.Tests
{
    public class EncripterTest
    {
        private readonly Encripter _encripter;

        public EncripterTest()
        {
            _encripter = new Encripter();
        }

        [Fact]
        public void WhenSendALeterReturnEncripted()
        {
            //a b c d e f g h i j k l m n o p q r s t u v w x y z
            //! ) $ ( £ * % & > < @ a b c d e f g h i j k l m n o 
            string letter = "e";
            var result = _encripter.EncryptALetter(letter);
            var expected = "£";
            Assert.Equal(expected,result);
        }

        [Fact]
        public void WhenSendTwoLeterReturnEncripted()
        {
            //a b c d e f g h i j k l m n o p q r s t u v w x y z
            //! ) $ ( £ * % & > < @ a b c d e f g h i j k l m n o 
            string letter = "ca";
            var result = _encripter.EncryptALetter(letter);
            var expected = "$!";
            Assert.Equal(expected,result);
        }
        
        [Fact]
        public void WhenSendAWordReturnEncripted()
        {
            //a b c d e f g h i j k l m n o p q r s t u v w x y z
            //! ) $ ( £ * % & > < @ a b c d e f g h i j k l m n o 
            string letter = "hello";
            var result = _encripter.EncryptALetter(letter);
            var expected = "&£aad";
            Assert.Equal(expected,result);
        }

        [Fact]
        public void WhenSendALongWordReturnEncripted()
        {
            //a b c d e f g h i j k l m n o p q r s t u v w x y z
            //! ) $ ( £ * % & > < @ a b c d e f g h i j k l m n o 
            string letter = "helloworld";
            var result = _encripter.EncryptALetter(letter);
            var expected = "&£aadldga(";
            Assert.Equal(expected,result);
        }

        [Fact]
        public void WhenSendAWorngWordReturnError()
        {
            //a b c d e f g h i j k l m n o p q r s t u v w x y z
            //! ) $ ( £ * % & > < @ a b c d e f g h i j k l m n o 
            string letter = "hello 1";
            var result = _encripter.EncryptALetter(letter);
            var expected = "Error!";
            Assert.Equal(expected,result);
        }
    }
}
