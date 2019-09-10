using System;
using System.Collections.Generic; 

namespace CodeCracker
{
    public class Decryption
    {
        string messageDecrypted;
        char [] message;
        int lengthMessage;
        int lengthDecryptionKey;

        List<Key> alphabet = new List<Key>();
        List<Key> decryptionKey = new List<Key>();
        
        public Decryption(){}

        public string getMessageDecrypted(string MessageEncrypted, string decriptionKey)
        {
            KeyList keylist = new KeyList();

            alphabet = keylist.getAlphabet();
            decryptionKey = keylist.fillDecryptionKey(decriptionKey);

            message = MessageEncrypted.ToCharArray();

            decriptorMessage();

            messageDecrypted = new string(message);

            return messageDecrypted;
        }
        private void decriptorMessage()
        {
            lengthMessage =  message.Length;

            for (int i = 0; i < lengthMessage; i++)
            {
                finderLetterInAlphabet(message[i], i);
            }
        }
        private void finderLetterInAlphabet(char letterMessage, int indexMessage)
        {
            lengthDecryptionKey = alphabet.Count;

            for (int i = 0; i < lengthDecryptionKey; i++)
            {
                decryptorLetter(letterMessage, decryptionKey[i], alphabet[i], indexMessage);
            }
        }
        private void decryptorLetter(char letterMessage, Key letterDecryptionKey, Key leterAlphabet, int indexMessage)
        {
            if (letterMessage.Equals(letterDecryptionKey.getCharacter()))
            {
                message[indexMessage] = leterAlphabet.getCharacter();
            }
        }
    }
}
