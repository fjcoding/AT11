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
        public void WhenIPutFirstLastNameReturnFullName()
        {
            Person result = _person.NamedOne("Jhon", "Due");
            string expected = "Jhon Due";
            Assert.Equal(expected, result.fullName);
        }
    }
}