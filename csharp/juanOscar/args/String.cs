using System;

namespace args
{
    public class StringArg : Arg
    {
        private string value = "";
        public StringArg()
        {
            
        }
        public string verifyIsValidString(string inputValue)
        {
            if (inputValue != "")
                this.value = inputValue;
            return value;    
        }
    }
}