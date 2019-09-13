using System;

namespace CodeCracker
{
    public class Key
    {
        private int index;
        private char character;

        public Key(){}
        public Key(int index, char character)
        {
            this.index = index;
            this.character = character;
        }
        public int getInt()
        {
            return this.character;
        }
        public char getCharacter()
        {
            return this.character;
        }
    }
}