using System;

namespace CodeCrackerMain
{
    public class Encripter
    {
        public string EncryptALetter(string input_leters)
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
                case "a": letter="!";
                break;
                case "b": letter=")";
                break;
                case "c": letter="$";
                break;
                case "d": letter="(";
                break;
                case "e": letter="£";
                break;
                case "f": letter="*";
                break;
                case "g": letter="%";
                break;
                case "h": letter="&";
                break;
                case "i": letter=">";
                break;
                case "j": letter="<";
                break;
                case "k": letter="@";
                break;
                case "l": letter="a";
                break;
                case "m": letter="b";
                break;
                case "n": letter="c";
                break;
                case "o": letter="d";
                break;
                case "p": letter="e";
                break;
                case "q": letter="f";
                break;
                case "r": letter="g";
                break;
                case "s": letter="h";
                break;
                case "t": letter="i";
                break;
                case "u": letter="j";
                break;
                case "v": letter="k";
                break;
                case "w": letter="l";
                break;
                case "x": letter="m";
                break;
                case "y": letter="n";
                break;
                case "z": letter="o";
                break;  
            }
            return letter;

        }
    }
}
