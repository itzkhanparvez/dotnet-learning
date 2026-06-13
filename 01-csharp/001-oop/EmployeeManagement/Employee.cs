/// <summary>
/// Employee class that inherits from Person.
/// Demonstrates Inheritance and Polymorphism.
/// </summary>
public class Employee : Person
{
    // Encapsulation: Private fields with public properties
    private string _employeeCode = string.Empty;
    private string _department = string.Empty;
    private decimal _salary;

    // Properties with encapsulation
    public string EmployeeCode
    {
        get { return _employeeCode; }
        set { _employeeCode = value; }
    }

    public string Department
    {
        get { return _department; }
        set { _department = value; }
    }

    public decimal Salary
    {
        get { return _salary; }
        set { _salary = value; }
    }

    // Constructor
    public Employee(int id, string firstName, string lastName, int age, 
                   string employeeCode, string department, decimal salary)
        : base(id, firstName, lastName, age)
    {
        EmployeeCode = employeeCode;
        Department = department;
        Salary = salary;
    }

    // Polymorphism: Implementing abstract method from Person
    public override void DisplayInfo()
    {
        DisplayEmployeeInfo();
    }

    // Method to display employee information
    public virtual void DisplayEmployeeInfo()
    {
        Console.WriteLine("==========================================");
        Console.WriteLine($"Employee Information");
        Console.WriteLine("==========================================");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {GetFullName()}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Employee Code: {EmployeeCode}");
        Console.WriteLine($"Department: {Department}");
        Console.WriteLine($"Salary: ${Salary:F2}");
        Console.WriteLine("==========================================");
    }
}
