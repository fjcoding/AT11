using System;
public class Person
{
    public string firstName ;
    public string lastName;
    public string fullName;
    
    public Person(){}

    public Person(string firstName,string lastName)
    {
        this.firstName=firstName;
        this.lastName=lastName;
    }
    
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }
    
   
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
    
    public string FullName
    {
        get { return fullName; }
        set { fullName = value; }
    }
    public string NamedOne(String firstName, String lastName)
    {
        this.fullName = firstName+" "+lastName;
        return this.FullName;
    }

    /* public Person ReturnObjectPerson(string inputFirstName, string inputLastName)
    {
        Person myperson = new Person();
        myperson.firstName = inputFirstName;
        myperson.lastName = inputLastName;
        myperson.fullName = inputFirstName + " " + inputLastName;
        return myperson;
    }*/

    /*public Person ReturnObjectPerson(string inputFullName)
    {
        Person myperson = new Person();
        myperson.firstName = inputFirstName;
        myperson.lastName = inputLastName;
        myperson.fullName = inputFirstName + " " + inputLastName;
        return myperson;
    }*/
}