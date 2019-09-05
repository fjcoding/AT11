using System;

namespace args
{
    public class Parser
    {

        public bool verifyBooeanArgumentIsValid(string inputArgument)
        {
            BooleanArgument booleanArgument = new BooleanArgument();
            return booleanArgument.verifyIfIsValidBooleanArgument(inputArgument);
        }
    }
}