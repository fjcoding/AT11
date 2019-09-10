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

       [Fact]
         public void EncryptingLetterFromTheList()
        {
            
            string letter = "&£aadldga(";
            var result = _decripter.EncryptLetterFromList(letter);
            var expected = "helloworld";
            Assert.Equal(expected,result);
        }
        
        [Fact]
        public void WhenSendALeterReturnChanged()
        {
            string chooseletter = "a";
            string letertochange = ":";
            string IfLetterChanged = _decripter.ChangeLetterOfEncription(chooseletter,letertochange);
            //a b c d e f g h i j k l m n o p q r s t u v w x y z
            //! ) $ ( £ * % & > < @ a b c d e f g h i j k l m n o 
            string letter = ":";
            var result = _decripter.EncryptLetterFromList(letter);
            var expected = "a";
            Assert.Equal("Letter Changed",IfLetterChanged);
            Assert.Equal(expected,result);
            
        }
        [Fact]
        public void WhenSendthreeLetersReturnChanged()
        {
            string chooseletter1 = "a";
            string letertochange1 = ":";
            string whenLetterChanged1 = _decripter.ChangeLetterOfEncription(chooseletter1,letertochange1);
             string chooseletter2 = "d";
            string letertochange2 = "_";
            string whenLetterChanged2 = _decripter.ChangeLetterOfEncription(chooseletter2,letertochange2);
             string chooseletter3 = "t";
            string letertochange3 = "+";
            string whenLetterChanged3 = _decripter.ChangeLetterOfEncription(chooseletter3,letertochange3);
            //a b c d e f g h i j k l m n o p q r s t u v w x y z
            //! ) $ ( £ * % & > < @ a b c d e f g h i j k l m n o 
            string letter = ":_+";
            var result = _decripter.EncryptLetterFromList(letter);
            var expected = "adt";
            Assert.Equal("Letter Changed",whenLetterChanged1);
            Assert.Equal("Letter Changed",whenLetterChanged2);
            Assert.Equal("Letter Changed",whenLetterChanged3);

            Assert.Equal(expected,result);
            
        }
    }
}
