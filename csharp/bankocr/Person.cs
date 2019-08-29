using System;

namespace bankocr
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public string fullName;
        public Person NamedOne(string inputFirstName, string inputLastName)
        {
            Person person = new Person();
            person.firstName = inputFirstName;
            person.lastName = inputLastName;
            person.fullName = person.firstName + " " + person.lastName;

            return person;
        }

        public void setFirstName(string inputFirstName)
        {
            this.firstName = inputFirstName;
        }
        public void setLastName(string inputLastName)
        {
            this.lastName = inputLastName;
        }
        public void setFullName()
        {
            this.fullName = this.firstName + " " + this.lastName;
        }
        public string getFullName()
        {
            return this.fullName;
        }
    }
}