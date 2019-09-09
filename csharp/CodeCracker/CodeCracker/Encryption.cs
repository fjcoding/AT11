using System;

namespace CodeCracker
{
    public class Encryption
    {
        string messageEncrypted;
        char [] message;
        int lengthMessage;
        int lengthAlphabet;
        private char [] alphabet = new char [26]  { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 
                                                    'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q',
                                                    'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        private char [] decryptionKey = new char [26]  { '!', ')', '"', '(', '£', '*', '%', '&',
                                                         '>', '<', '@', 'a', 'b', 'c', 'd', 'e', 'f',
                                                         'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o'};  
        
        public Encryption(){}

        public string getMessageEncrypted(string MessageEncrypted)
        {
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
            lengthAlphabet = alphabet.Length;

            for (int i = 0; i < lengthAlphabet; i++)
            {
                decryptorLetter(letterMessage, alphabet[i], i, indexMessage);
            }
        }
        private void decryptorLetter(char letterMessage, char letterAlphabet, int indexDecryptionKey, int indexMessage)
        {
            if (letterMessage.Equals(letterAlphabet))
            {
                message[indexMessage] = decryptionKey[indexDecryptionKey];
            }
        }
    }
}
