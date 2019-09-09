using System;

namespace CodeCrackerMain
{
    public class Decripter
    {
        public string DecryptLetters(string input_leters)
        {
            int lengthOfCut = 1;
            string inputsLetters = input_leters;
            string stringOfLetters = "";
            //string lettercompared;
            string lettercut;
            for (int items = 0; items < inputsLetters.Length; items++)
            {   
                lettercut = inputsLetters.Substring(items, lengthOfCut);
                if(comparingLetters(lettercut).Equals("Error!"))
                    return comparingLetters(lettercut);
                stringOfLetters += comparingLetters(lettercut);
            }
            return stringOfLetters;
           
        }
        private string comparingLetters(string letter_input)
        {
            string letter = "Error!";
           
            switch (letter_input)
            {   
                case "!": letter = "a";
                break;
                case ")": letter = "b";
                break;
                case "$": letter = "c";
                break;
                case "(": letter = "d";
                break;
                case "£": letter = "e";
                break;
                case "*": letter = "f";
                break;
                case "%": letter = "g";
                break;
                case "&": letter = "h";
                break;
                case ">": letter = "i";
                break;
                case "<": letter = "j";
                break;
                case "@": letter = "k";
                break;
                case "a": letter = "l";
                break;
                case "b": letter = "m";
                break;
                case "c": letter = "n";
                break;
                case "d": letter = "o";
                break;
                case "e": letter = "p";
                break;
                case "f": letter = "q";
                break;
                case "g": letter = "r";
                break;
                case "h": letter = "s";
                break;
                case "i": letter = "t";
                break;
                case "j": letter = "u";
                break;
                case "k": letter = "v";
                break;
                case "l": letter = "w";
                break;
                case "m": letter = "x";
                break;
                case "n": letter = "y";
                break;
                case "o": letter = "z";
                break;  
            }
            return letter;

        }
    }
}
