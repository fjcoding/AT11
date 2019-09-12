using System;

namespace args
{
    public class Arg
    {
        private string flag;
        public Arg()
        {

        }

        public bool verifyFlag(string inputFlag)
        {
            char sign = inputFlag[0];
            char letter = inputFlag[1];
            return sign == '-' && Char.IsLetter(letter);
        }

        public int verifyIntegerValid(string inputFlag, int inputValue)
        {
            Integer numberInteger = new Integer();
            int numberResult = 0;
            if(verifyFlag(inputFlag))
                numberResult = numberInteger.verifyIsValidNumber(inputValue);
            return numberResult;
        }

        public string verifyStringValid(string inputFlag, string inputValue)
        {
            StringArg stringObject = new StringArg();
            string stringResult = "";
            if(verifyFlag(inputFlag))
                stringResult = stringObject.verifyIsValidString(inputValue);
            return stringResult;
        }
    }
}