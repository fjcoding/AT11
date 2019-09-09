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
            string letterEncrypted = "!";

            var expected = "a";
            var result = _decryption.getMessageDecrypted(letterEncrypted);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void WhenInputEncryptedMessageReturnDecryptedMessage()
        {
            string messageEncrypted = "&£aad ldga(";

            var expected = "hello world";
            var result = _decryption.getMessageDecrypted(messageEncrypted);

            Assert.Equal(expected, result);
        }
    }
}
