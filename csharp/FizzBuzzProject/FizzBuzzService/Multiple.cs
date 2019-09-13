using System;
namespace FizzBuzzService
{
    public class Multiple
    {
        public bool MultipleOfThree(int number)
        {
            return number % 3 == 0;
        }

        public bool MultipleOfFive(int number)
        {
            return number % 5 == 0;
        }

        public bool MultipleOfThreeAndContainsThree(string number)
        {
            int numberParse = int.Parse(number);
            if(MultipleOfThree(numberParse))
                return number.Contains("3");
            return false;                            
        }
        public bool MultipleOfFiveAndContainsFive(string number)
        {
            int numberParse = int.Parse(number);
            if(MultipleOfFive(numberParse))
                return number.Contains("5");
            return false;                            
        }
    }
}