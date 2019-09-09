using System;

namespace CodeCracker
{
    public class Decryption
    {
        string messageDecrypted;
        char [] message;
        int lengthMessage;
        int lengthDecryptionKey;
        private char [] alphabet = new char [26]  { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 
                                                    'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q',
                                                    'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        private char [] decryptionKey = new char [26]  { '!', ')', '"', '(', '£', '*', '%', '&',
                                                         '>', '<', '@', 'a', 'b', 'c', 'd', 'e', 'f',
                                                         'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o'};  
        
        public Decryption(){}

        public string getMessageDecrypted(string MessageEncrypted)
        {
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
            lengthDecryptionKey = decryptionKey.Length;

            for (int i = 0; i < lengthDecryptionKey; i++)
            {
                decryptorLetter(letterMessage, decryptionKey[i], i, indexMessage);
            }
        }
        private void decryptorLetter(char letterMessage, char letterDecryptionKey, int indexAlphabet, int indexMessage)
        {
            if (letterMessage.Equals(letterDecryptionKey))
            {
                message[indexMessage] = alphabet[indexAlphabet];
            }
        }
    }
}
