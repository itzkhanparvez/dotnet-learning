// Employee Management System - Demonstrating OOP Concepts

// Create a list to store employees
List<Employee> employees = new List<Employee>();

// Adding employees to the list
Employee e1 = new Employee(
    id: 101,
    firstName: "John",
    lastName: "Doe",
    age: 30,
    employeeCode: "EMP001",
    department: "Engineering",
    salary: 75000
);

Employee e2 = new Employee(
    id: 102,
    firstName: "Jane",
    lastName: "Smith",
    age: 28,
    employeeCode: "EMP002",
    department: "Marketing",
    salary: 65000
);

Manager m1 = new Manager(
    id: 103,
    firstName: "Michael",
    lastName: "Johnson",
    age: 35,
    employeeCode: "MGR001",
    department: "Engineering",
    salary: 95000,
    teamSize: 5
);

Manager m2 = new Manager(
    id: 104,
    firstName: "Sarah",
    lastName: "Williams",
    age: 32,
    employeeCode: "MGR002",
    department: "Sales",
    salary: 85000,
    teamSize: 8
);

// Adding employees to the list
employees.Add(e1);
employees.Add(e2);
employees.Add(m1);
employees.Add(m2);

// Looping through employees and calling overridden methods
Console.WriteLine("\n=== EMPLOYEE MANAGEMENT SYSTEM ===\n");

foreach (Employee employee in employees)
{
    // Polymorphism in action: calling the same method name
    // but different implementations based on actual object type
    employee.DisplayEmployeeInfo();
    Console.WriteLine();
}

// Demonstrating GetFullName() method
Console.WriteLine("\n=== EMPLOYEE NAMES ===\n");
foreach (Employee employee in employees)
{
    Console.WriteLine($"ID: {employee.Id} - Name: {employee.GetFullName()}");
}
