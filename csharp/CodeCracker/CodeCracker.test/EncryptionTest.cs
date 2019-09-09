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
        public void WhenInputEncryptedLetterReturnDecryptedLetter()
        {
            string letterEncrypted = "a";

            var expected = "!";
            var result = _encryption.getMessageEncrypted(letterEncrypted);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void WhenInputNormalMessageReturnEncryptedMessage()
        {
            string messageEncrypted = "hello world";

            var expected = "&£aad ldga(";
            var result = _encryption.getMessageEncrypted(messageEncrypted);

            Assert.Equal(expected, result);
        }
    }
}