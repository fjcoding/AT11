using System;
using Xunit;
using FizzBuzzService;
namespace FizzBuzz.Test
{
    public class FizzBuzzTest
    {
        FizzBuzzMethods _fizzBuzzMethods;
        public FizzBuzzTest()
        {
            _fizzBuzzMethods = new FizzBuzzMethods();
        }

        [Fact]
        public void TestReturnFizzForMultipleOfThree()
        {
            Assert.Equal("Fizz",_fizzBuzzMethods.returnFizzForMultipleOfThree(3));
        }

        [Fact]
        public void TestReturnBuzzForMultipleOfFive()
        {
            Assert.Equal("Buzz",_fizzBuzzMethods.returnBuzzForMultipleOfFive(5));
        }

        [Fact]
        public void TestReturnFizzBuzzForMultiplesOfThreeAndFive()
        {
            Assert.Equal("Fizz Buzz",_fizzBuzzMethods.returnFizzBuzzForMultiplesOfThreeAndFive(3,5));
        }
        
        [Fact]
        public void TestValidateThatNumberIsBetweenOneAndOneHundred()
        {
            Assert.True(_fizzBuzzMethods.validateThatNumberIsBetweenOneAndOneHundred(80));
        }

        [Fact]
        public void TestValidateMultipleOfThreeAndContainsThree()
        {
            Assert.True(_fizzBuzzMethods.validateMultipleOfThreeAndContainsThree("30"));
        }

        [Fact]
        public void TestValidateMultipleOfFiveAndContainsFive()
        {
            Assert.True(_fizzBuzzMethods.validateMultipleOfFiveAndContainsFive("55"));
        }
        
    }
}
