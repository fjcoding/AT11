using System;

namespace args
{
    public class Parser
    {

        public bool verifyBooleanArgumentIsValid(string inputArgument)
        {
            BooleanArgument booleanArgument = new BooleanArgument();
            return booleanArgument.verifyIfIsValidBooleanArgument(inputArgument);
        }

        public int verifyIntegerArgumentIsValid(string inputArgument)
        {
            IntegerArgument integerArgument = new IntegerArgument();
            string[] splitArgument = inputArgument.Split(' ');
            int positionFlag = 0;
            int positionValue = 1;
            string flag = splitArgument[positionFlag];
            int value = Convert.ToInt32(splitArgument[positionValue]);
            return integerArgument.verifyIfIsValidIntegerArgument(flag, value);
        }
    }
}