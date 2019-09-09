using System;
using Xunit;

namespace CodeCracker.test
{
    public class KeyTest
    {
        private readonly Key _key;
        public KeyTest()
        {
            _key = new Key();    
        }

        [Fact]
        public void VerifyKeyListAlphabet()
        {
            var expected = 26;
            var result = _key.getAlphabetLenght();

            Assert.Equal(expected, result);
        }
    }
}