using System;
using bankocr;
using Xunit;

namespace TestPerson.Tests
{
    public class TestPerson
    {
       // private readonly Person _person;
        public TestPerson()
        {
          //  _person = new Person();    
        }
        [Fact]
        public void WhenAddFirstLastNameThenReturnFullName()
        {
            Person myPerson = new Person(); 
            Person result = myPerson.NamedOne("Jhon","Due");
            var expected = "Jhon Due";
            Assert.Equal(expected,result.FullName);
        }
        
        [Fact]
        public void WhenUpDateFirstName()
        {
            Person myPerson = new Person();
            myPerson.FirstName ="Ana";
            myPerson.LastName = "Wong";
            myPerson.UpdateFirstName("Jhon");
            var expected = "Jhon Wong";
            Assert.Equal(expected,myPerson.FullName);

        } 
        [Fact]
        public void WhenUpDateLasttName()
        {
            Person myPerson = new Person();
            myPerson.FirstName ="Ana";
            myPerson.LastName = "Wong";
            myPerson.UpdateLastName("Due");
            var expected = "Ana Due";
            Assert.Equal(expected,myPerson.FullName);

        } 
        [Fact]
        public void WhenUpDateFullName()
        {
            Person myPerson = new Person();
            myPerson.FirstName ="Ana";
            myPerson.LastName = "Wong";
            myPerson.UpDateFirstNameAndLastName("Alan Escalera");
            var expectedFirstName = "Alan";
            var expectedLastName = "Escalera";
            Assert.Equal(expectedFirstName,myPerson.FirstName);
            Assert.Equal(expectedLastName,myPerson.LastName);

        } 
    }
}