using System;
using bankocr;
using Xunit;

namespace TestPerson.Tests
{
    public class TestPerson
    {
        private readonly Person _person;
        public TestPerson()
        {
            _person = new Person();    
        }
        [Fact]
        public void WhenAddFirstLastNameThenReturnFullName()
        {
            Person myPerson = new Person();
            Person result = myPerson.ReturnObjectPerson("Jhon", "Due");

            Assert.Equal("Jhon Due",result.fullName);
        }

        [Fact]
        public void WhenAddFullNameReturnFirstLastName()
        {
            Person myPerson = new Person();
            Person result = myPerson.ReturnObjectPerson("Jhon Due");

            Assert.Equal("Jhon",result.fistName);
            Assert.Equal("Due",result.lastName);
        }
    }
}