using System;

namespace args
{
    public class BooleanArgument
    {
        const string flag = "-l";
        const string value = "";
        public BooleanArgument()
        {

        }
        public bool verifyIfIsValidBooleanArgument(string inputBooleanArgument)
        {
            return inputBooleanArgument == flag + value;
        }
    }
}