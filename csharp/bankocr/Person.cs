using System;
public class Person
{
    private string firstName ;
    private string lastName;
    private string fullName;
    

    public Person(){}

    //public Person(string firstName,string lastName)
    //{
     //   this.firstName=firstName;
     //   this.lastName=lastName;
    //}
    
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
    public Person NamedOne(String firstName, String lastName)
    {
        Person myperson = new Person();
        myperson.FirstName = firstName;
        myperson.LastName = lastName;
        myperson.FullName = myperson.FirstName + " " + myperson.LastName;
        return myperson;
    }

    public void UpdateFirstName(string inputFirstName)
    {
        //Person myperson = new Person();
        this.firstName = inputFirstName;
        this.fullName = inputFirstName + " " + this.LastName;
    }
    public void UpdateLastName(string inputLastName)
    {
        this.lastName = inputLastName;
        this.fullName = this.firstName + " " + this.lastName;
        
    }
    
    public void UpDateFirstNameAndLastName(string inputFullName)
    {
        
        int indexfullnamesplit = 0;
        string [] fullnamesplit = inputFullName.Split(' ');
        this.firstName = fullnamesplit[indexfullnamesplit];
        this.lastName = fullnamesplit[indexfullnamesplit+1]; 

    }
}