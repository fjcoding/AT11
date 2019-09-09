using System;

namespace args
{
    public class Integer : Arg
    {
        private int value = 0;
        public Integer()
        {

        }
        public int verifyIsValidNumber(int inputValue)
        {
            if (inputValue > value)
                this.value = inputValue;
            return value;    
        }
    }
}