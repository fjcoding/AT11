using System;

namespace FizzBuzzService
{
    public class FizzBuzzMethods
    {
        Multiple _multiple;
        public FizzBuzzMethods()
        {
            _multiple = new Multiple();
        }
        public string returnFizzForMultipleOfThree(int number)
        {
            string returnFizz = "No Fizz";
            if(_multiple.MultipleOfThree(number) == true)
                returnFizz = "Fizz";
            return returnFizz;
        }
        public string returnBuzzForMultipleOfFive(int number)
        {
            string returnFizz = "No Buzz";
            if(_multiple.MultipleOfFive(number) == true)
                returnFizz = "Buzz";
            return returnFizz;
        }
        public string returnFizzBuzzForMultiplesOfThreeAndFive(int numberThree, int numberFive)
        {
            string returnFizz = "No Fizz Buzz";
            if(_multiple.MultipleOfThree(numberThree) == true && _multiple.MultipleOfFive(numberFive) == true) 
                returnFizz = "Fizz Buzz";
            return returnFizz;
        }
        public bool validateThatNumberIsBetweenOneAndOneHundred(int number)
        {
            return number > 0 && number < 101;
        }
        public bool validateMultipleOfThreeAndContainsThree(string number)
        {
            return _multiple.MultipleOfThreeAndContainsThree(number);
        }
        public bool validateMultipleOfFiveAndContainsFive(string number)
        {
            return _multiple.MultipleOfFiveAndContainsFive(number);
        }
        public string returnNumberIfNotMultipleOfThree(int number)
        {
            string returnFizz = Convert.ToString(number);
            if(_multiple.MultipleOfThree(number) == true)
                returnFizz = "Fizz";
            return returnFizz;
        }
        public string returnNumberIfNotMultipleOfFive(int number)
        {
            string returnFizz = Convert.ToString(number);
            if(_multiple.MultipleOfFive(number) == true)
                returnFizz = "Buzz";
            return returnFizz;
        }
    }
}
