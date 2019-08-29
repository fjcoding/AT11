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
            Person result = _person.NamedOne("Naomi","Wang");
            string expected = "Naomi Wang";
            Assert.Equal(expected, result.fullName);
        }
        [Fact]
        public void WhenIUpdateFirstNameReturnFullName()
        {
            Person person = _person.NamedOne("Naomi","Wang");
            person.setFirstName("John");
            person.setFullName();

            string expected = "John Wang";
            string result = person.getFullName();

            Assert.Equal(expected,result);
        }
        [Fact]
        public void WhenIUpdateLastNameReturnFullName()
        {
            Person person = _person.NamedOne("John","Wang");
            person.setLastName("Doe");
            person.setFullName();

            string expected = "John Doe";
            string result = person.getFullName();

            Assert.Equal(expected,result);
        }
    }
}