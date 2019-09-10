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
        
        [Fact]
        public void EncryptingLetterFromTheList()
        {
            
            string letter = "helloworld";
            var result = _encripter.EncryptLetterFromList(letter);
            var expected = "&£aadldga(";
            Assert.Equal(expected,result);
        }
        [Fact]
        public void WhenSendALeterReturnChanged()
        {
            string chooseletter = "a";
            string letertochange = ":";
            string IfLetterChanged = _encripter.ChangeLetterOfEncription(chooseletter,letertochange);
            //a b c d e f g h i j k l m n o p q r s t u v w x y z
            //! ) $ ( £ * % & > < @ a b c d e f g h i j k l m n o 
            string letter = "a";
            var result = _encripter.EncryptLetterFromList(letter);
            var expected = ":";
            Assert.Equal("Letter Changed",IfLetterChanged);
            Assert.Equal(expected,result);
            
        }
         [Fact]
        public void WhenSendthreeLetersReturnChanged()
        {
            string chooseletter1 = "a";
            string letertochange1 = ":";
            string whenLetterChanged1 = _encripter.ChangeLetterOfEncription(chooseletter1,letertochange1);
             string chooseletter2 = "d";
            string letertochange2 = "_";
            string whenLetterChanged2 = _encripter.ChangeLetterOfEncription(chooseletter2,letertochange2);
             string chooseletter3 = "t";
            string letertochange3 = "+";
            string whenLetterChanged3 = _encripter.ChangeLetterOfEncription(chooseletter3,letertochange3);
            //a b c d e f g h i j k l m n o p q r s t u v w x y z
            //! ) $ ( £ * % & > < @ a b c d e f g h i j k l m n o 
            string letter = "adt";
            var result = _encripter.EncryptLetterFromList(letter);
            var expected = ":_+";
            Assert.Equal("Letter Changed",whenLetterChanged1);
            Assert.Equal("Letter Changed",whenLetterChanged2);
            Assert.Equal("Letter Changed",whenLetterChanged3);

            Assert.Equal(expected,result);
            
        }


    }
}
