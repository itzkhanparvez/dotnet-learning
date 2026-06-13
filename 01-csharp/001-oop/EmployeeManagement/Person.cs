/// <summary>
/// Abstract base class representing a person.
/// Demonstrates Abstraction and Encapsulation.
/// </summary>
public abstract class Person
{
    // Encapsulation: Private fields with public properties
    private int _id;
    private string _firstName = string.Empty;
    private string _lastName = string.Empty;
    private int _age;

    // Properties with validation (Encapsulation)
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    // Constructor
    protected Person(int id, string firstName, string lastName, int age)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    // Method
    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }

    // Abstract method - demonstrates Abstraction
    // Forces derived classes to implement this method
    public abstract void DisplayInfo();
}
