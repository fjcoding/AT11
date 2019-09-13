using System;
using Xunit;

namespace CodeCracker.test
{
    public class EncryptionTest
    {
        private readonly Encryption _encryption;
        public EncryptionTest()
        {
            _encryption = new Encryption();    
        }

        [Fact]
        public void WhenInputNormalLetterReturnEncryptedLetter()
        {
            string decryptionKey =  "$)'(£*%&><@abcdefghijklmno"; 

            string letter = "a";

            var expected = "$";
            var result = _encryption.getMessageEncrypted(letter, decryptionKey);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void WhenInputNormalMessageReturnEncryptedMessage_FirstDecrptionKey()
        {
            string decryptionKey =  "$)'(£*%&><@abcdefghijklmno"; 

            string messageEncrypted = "hello world";

            var expected = "&£aad ldga(";
            var result = _encryption.getMessageEncrypted(messageEncrypted, decryptionKey);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void WhenInputNormalMessageReturnDecryptedMessage_SecondDecrptionKey()
        {
            string decryptionKey =  "$)'(£*%&><@abcdefghijklmno"; 

            string messageEncrypted = "alex";

            var expected = "$a£m";
            var result = _encryption.getMessageEncrypted(messageEncrypted, decryptionKey);

            Assert.Equal(expected, result);
        }
    }
}