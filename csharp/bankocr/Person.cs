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
            this.setFullName();
        }
        public string getFirstName()
        {
            return this.firstName;
        }
        public void setLastName(string inputLastName)
        {
            this.lastName = inputLastName;
            this.setFullName();
        }
        private void setFullName()
        {
            this.fullName = this.firstName + " " + this.lastName;
        }
        public Person setFullName(string inputFullName)
        {
            int rowFirstName = 0;
            int rowLastName = 1;
            string [] fullNameSplit = inputFullName.Split(' ');

            this.setFirstName(fullNameSplit[rowFirstName]);
            this.setLastName(fullNameSplit[rowLastName]);

            return this;
        }
        public string getFullName()
        {
            return this.fullName;
        }
    }
}