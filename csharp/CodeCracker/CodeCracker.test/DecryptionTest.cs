using System;
using Xunit;

namespace CodeCracker.test
{
    public class DecryptionTest
    {
        private readonly Decryption _decryption;
        public DecryptionTest()
        {
            _decryption = new Decryption();    
        }

        [Fact]
        public void WhenInputEncryptedLetterReturnDecryptedLetter()
        {
            string decryptionKey =  "$)'(£*%&><@abcdefghijklmno"; 

            string letterEncrypted = "$";

            var expected = "a";
            var result = _decryption.getMessageDecrypted(letterEncrypted, decryptionKey);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void WhenInputEncryptedMessageReturnDecryptedMessage_FirstDecrptionKey()
        {
            string decryptionKey =  "$)'(£*%&><@abcdefghijklmno"; 

            string messageEncrypted = "&£aad ldga(";

            var expected = "hello world";
            var result = _decryption.getMessageDecrypted(messageEncrypted, decryptionKey);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void WhenInputEncryptedMessageReturnDecryptedMessage_SecondDecrptionKey()
        {
            string decryptionKey =  "$)'(£*%&><@abcdefghijklmno"; 

            string messageEncrypted = "$a£m";

            var expected = "alex";
            var result = _decryption.getMessageDecrypted(messageEncrypted, decryptionKey);

            Assert.Equal(expected, result);
        }
    }
}
