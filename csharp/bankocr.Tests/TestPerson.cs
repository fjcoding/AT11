using System;
using Xunit;
using bankocr;
using System.Collections.Generic;

namespace bankocr.Tests
{
    public class UnitTestPerson
    {
        public readonly Person _person;
        List<Person> personList = new List<Person>()
            {
                new Person("Luis"),
                new Person("Benita"),
                new Person("Jose"),
                new Person("Rosmery")
            };
        public UnitTestPerson()
        {
            _person = new Person();
        }

        [Fact]
        public void TestSetGetName()
        {
            Person testPerson = new Person("Luis");
            Assert.Equal("Luis", testPerson.Name);
        }

        [Fact]
        public void TestSetGetlistOfPerson()
        {
            var result = _person.returnlistOfPeople(personList);
            Assert.Equal("Luis", result[0].Name);
            Assert.Equal("Benita", result[1].Name);
            Assert.Equal("Jose", result[2].Name);
            Assert.Equal("Rosmery", result[3].Name);
        }
    }
}