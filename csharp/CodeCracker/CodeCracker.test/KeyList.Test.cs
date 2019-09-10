using System;
using Xunit;
using System.Collections.Generic; 

namespace CodeCracker.test
{
    public class KeyListTest
    {
        private readonly KeyList _keyList;
        public KeyListTest()
        {
            _keyList = new KeyList();    
        }

        [Fact]
        public void VerifyLenghtListAlphabet()
        {
            List<Key> newdecryptionKey = _keyList.getAlphabet();

            var expected = 26;
            var result = newdecryptionKey.Count;

            Assert.Equal(expected, result);
        }
        [Fact]
        public void VerifyLenghtListDecriptionKey()
        {
            string decryptionKey =  "$)'(£*%&><@abcdefghijklmno";

            List<Key> newdecryptionKey = _keyList.fillDecryptionKey(decryptionKey);

            var expected = 26;
            var result = newdecryptionKey.Count;

            Assert.Equal(expected, result);
        }
    }
}