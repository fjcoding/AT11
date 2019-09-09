using System;

namespace args
{
    public class IntegerArgument
    {
        private string flag;
        private int value;
        public IntegerArgument()
        {

        }
        public int verifyIfIsValidIntegerArgument(string inputFlag, int inputValue)
        {
            int result = 0;
            int positionZeroInputFlag = 0;
            char dash = inputFlag[0];
            if (inputFlag == "-p"  && inputValue > 0)
                result = inputValue;
            return result;

        }
    }
}