using System;
using System.Collections.Generic; 

namespace CodeCracker
{
    public class Encryption
    {
        string messageEncrypted;
        char [] message;
        int lengthMessage;
        int lengthAlphabet;

        private List<Key> alphabet = new List<Key>();
        private List<Key> decryptionKey = new List<Key>();

        public Encryption(){}

        public string getMessageEncrypted(string MessageEncrypted, string decriptionKey)
        {
            KeyList keylist = new KeyList();

            alphabet = keylist.getAlphabet();
            decryptionKey = keylist.fillDecryptionKey(decriptionKey);

            message = MessageEncrypted.ToCharArray();

            encriptorMessage();

            messageEncrypted = new string(message);

            return messageEncrypted;
        }
        private void encriptorMessage()
        {
            lengthMessage =  message.Length;

            for (int i = 0; i < lengthMessage; i++)
            {
                finderLetterInDecryptionKey(message[i], i);
            }
        }
        private void finderLetterInDecryptionKey(char letterMessage, int indexMessage)
        {
            lengthAlphabet = alphabet.Count;

            for (int i = 0; i < lengthAlphabet; i++)
            {
                encryptLetter(letterMessage, alphabet[i].getCharacter(), decryptionKey[i], indexMessage);
            }
        }
        private void encryptLetter(char letterMessage, char letterAlphabet, Key letterDecryptionKey, int indexMessage)
        {
            if (letterMessage.Equals(letterAlphabet))
            {
                message[indexMessage] = letterDecryptionKey.getCharacter();
            }
        }
    }
}
