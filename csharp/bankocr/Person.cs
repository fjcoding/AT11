using System.Collections.Generic;

namespace bankocr
{
    public class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Person()
        {

        }
        public Person(string inputName)
        {
            this.name = inputName;
        }
        List<Person> listPerson = new List<Person>();
        public List<Person> returnlistOfPeople(List<Person> inputListOfPerson)
        {
            foreach (var item in inputListOfPerson)
            {
                listPerson.Add(new Person(item.Name));
            }
            return listPerson;
        }
    }
}