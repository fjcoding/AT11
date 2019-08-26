using System;

namespace bankocr
{
    public class Main
    {
        // public bool returnTrue()
        // {
        //     throw new NotImplementedException("Create a test first");
        // }

        public string verifyNumber(string stringNumber)
        {
            string result = "", number = "", intNumbers = "";
            string [] stringSplit = stringNumber.Split('\n');
            for (int column = 0; column < stringSplit[0].Length; column = column + 3)
            {
                number = "";
                result = "";
                result = stringSplit[0].Substring(column, 3);
                result += stringSplit[1].Substring(column, 3);
                result += stringSplit[2].Substring(column, 3);
                number = result;
                if (number == "     |  |")
                {
                    intNumbers += "1";
                    continue;
                }
                if (number == " _  _||_ ")
                {
                    intNumbers += "2";
                    continue;
                }
                if (number == " _  _| _|")
                {
                    intNumbers += "3";
                    continue;
                }
                if (number == "   |_|  |")
                {
                    intNumbers += "4";
                    continue;
                }
                if (number == " _ |_  _|")
                {
                    intNumbers += "5";
                    continue;
                }
                if (number == " _ |_ |_|")
                {
                    intNumbers += "6";
                    continue;
                }
                if (number == " _   |  |")
                {
                    intNumbers += "7";
                    continue;
                }
                if (number == " _ |_||_|")
                {
                    intNumbers += "8";
                    continue;
                }
                if (number == " _ |_| _|")
                {
                    intNumbers += "9";
                    continue;
                }
            }
            return intNumbers;
        }
    }
}
