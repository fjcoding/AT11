using System;
public class Person
{
    public string firstName ;
    public string lastName;
    public string fullName;
    
    public Person(){}
    public void setFirstName(string inputfirstName)
    {
       this.firstName = inputfirstName;
    }

    public string getFirstName()
    {
       return this.firstName;
    }
    
   
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
    
    public string NamedOne(String firstName, String lastName)
    {
        return firstName+" "+lastName;
    }

    public Person ReturnObjectPerson(string inputFirstName, string inputLastName)
    {
        Person myperson = new Person();
        myperson.firstName = inputFirstName;
        myperson.lastName = inputLastName;
        myperson.fullName = inputFirstName + " " + inputLastName;
        return myperson;
    }

    public Person ReturnObjectPerson(string inputFullName)
    {
        Person myperson = new Person();
        myperson.firstName = inputFirstName;
        myperson.lastName = inputLastName;
        myperson.fullName = inputFirstName + " " + inputLastName;
        return myperson;
    }
}