using System;

namespace bankocr
{
    public class Main
    {
        public string verifyNumber(string stringNumber)
        {
            string [] stringSplit = stringNumber.Split('\n');
            string result = "", number = "", intNumbers = "";
            string numberOne = "     |  |";
            string numberTwo = " _  _||_ ";
            string numberThree = " _  _| _|";
            string numberFour = "   |_|  |";
            string numberFive = " _ |_  _|";
            string numberSix = " _ |_ |_|";
            string numberSeven = " _   |  |";
            string numberEight = " _ |_||_|";
            string numberNine = " _ |_| _|";
            int subStringSize = 3;
            int rowStringSplitZero = 0;
            int rowStringSplitOne = 1;
            int rowStringSplitTwo = 2;
            int rowSize = stringSplit[rowStringSplitZero].Length;

            for (int column = 0; column < rowSize; column = column + 3)
            {
                number = "";
                result = "";
                result = stringSplit[rowStringSplitZero].Substring(column, subStringSize);
                result += stringSplit[rowStringSplitOne].Substring(column, subStringSize);
                result += stringSplit[rowStringSplitTwo].Substring(column, subStringSize);
                number = result;
                if (number.Equals(numberOne))
                {
                    intNumbers += "1";
                    continue;
                }
                if (number.Equals(numberTwo))
                {
                    intNumbers += "2";
                    continue;
                }
                if (number.Equals(numberThree))
                {
                    intNumbers += "3";
                    continue;
                }
                if (number.Equals(numberFour))
                {
                    intNumbers += "4";
                    continue;
                }
                if (number.Equals(numberFive))
                {
                    intNumbers += "5";
                    continue;
                }
                if (number.Equals(numberSix))
                {
                    intNumbers += "6";
                    continue;
                }
                if (number.Equals(numberSeven))
                {
                    intNumbers += "7";
                    continue;
                }
                if (number.Equals(numberEight))
                {
                    intNumbers += "8";
                    continue;
                }
                if (number.Equals(numberNine))
                {
                    intNumbers += "9";
                    continue;
                }
            }
            return intNumbers;
        }
    }
}
