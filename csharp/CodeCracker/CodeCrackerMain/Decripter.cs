using System;
using System.Collections.Generic;

namespace CodeCrackerMain
{
    public class Decripter
    {
        Code _codelettersdep;
        List<Code> listcodeTabledep; 
         public Decripter()
        {
            _codelettersdep = new Code();
             listcodeTabledep = _codelettersdep.tableCodeLetters();
             
        }
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

         public string EncryptLetterFromList(string input_leters)
        {
            int lengthOfCut = 1;
            string inputsLetters = input_leters;
            string stringOfLetters = "";
            string lettercut;
            for (int items = 0; items < inputsLetters.Length; items++)
            {   
                lettercut = inputsLetters.Substring(items, lengthOfCut);
                if(GetLetter(lettercut).Equals("Error!"))
                    return GetLetter(lettercut);
                stringOfLetters += GetLetter(lettercut);
            }
            return stringOfLetters;
           
        }

        public string GetLetter(string letter)
        {
           
            bool found = false;
            int items = -1;

            while(found == false && items < listcodeTabledep.Count)
            {
                items++;
                if(listcodeTabledep[items].letterEncripted == letter)
                    found = true;
                
            }
            if(found)
                return listcodeTabledep[items].letterSimple;
            return "Error!";
        }
        public string ChangeLetterOfEncription(string letterSimple, string lettertoChange)
        {
            //Code tablecodetochage = new Code();
            int items = -1;
            bool found = false;

            while (found ==false && items < listcodeTabledep.Count)
            {
                items++;
                if(listcodeTabledep[items].letterSimple == letterSimple)
                    found = true;
                
            }
            if(found)
            {
                listcodeTabledep[items].letterEncripted = lettertoChange;
                return "Letter Changed";
            }
            return "Letter NO Found";
        }
    }
}
