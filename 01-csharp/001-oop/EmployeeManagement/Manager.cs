/// <summary>
/// Manager class that inherits from Employee.
/// Demonstrates Inheritance and Polymorphism (method override).
/// </summary>
public class Manager : Employee
{
    // Encapsulation: Private field with public property
    private int _teamSize;

    // Property with encapsulation
    public int TeamSize
    {
        get { return _teamSize; }
        set { _teamSize = value; }
    }

    // Constructor
    public Manager(int id, string firstName, string lastName, int age,
                  string employeeCode, string department, decimal salary, int teamSize)
        : base(id, firstName, lastName, age, employeeCode, department, salary)
    {
        TeamSize = teamSize;
    }

    // Polymorphism: Overriding the DisplayEmployeeInfo method from Employee
    public override void DisplayEmployeeInfo()
    {
        Console.WriteLine("==========================================");
        Console.WriteLine($"Manager Information");
        Console.WriteLine("==========================================");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {GetFullName()}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Employee Code: {EmployeeCode}");
        Console.WriteLine($"Department: {Department}");
        Console.WriteLine($"Salary: ${Salary:F2}");
        Console.WriteLine($"Team Size: {TeamSize} members");
        Console.WriteLine("==========================================");
    }
}
