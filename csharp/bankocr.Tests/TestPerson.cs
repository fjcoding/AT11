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
            var result = myPerson.NamedOne("Jhon","Due");
            var expected = "Jhon Due";
            Assert.Equal(expected,myPerson.fullName);
        }
        /*
        [Fact]
        public void WhenAddFullNameReturnFirstLastName()
        {
            Person myPerson = new Person();
            Person result = myPerson.ReturnObjectPerson("Jhon Due");

            Assert.Equal("Jhon",result.firstName);
            Assert.Equal("Due",result.lastName);
        } */
    }
}