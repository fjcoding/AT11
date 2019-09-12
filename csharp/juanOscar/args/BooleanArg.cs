using System;

namespace args
{
    public class BooleanArg : Arg
    {
        private bool value = false;
        public BooleanArg()
        {
            
        }
        public bool ValidAndReturnIsValidBoolean(bool inputValue)
        {
            if (inputValue)
                this.value = inputValue;
            return value;    
        }
    }
}