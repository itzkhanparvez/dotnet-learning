# Object-Oriented Programming (OOP) Concepts

## What is Encapsulation?

Encapsulation is the bundling of data (fields) and methods into a single unit (class) and hiding the internal details from the outside world. We use private fields with public properties to control how data is accessed and modified. This protects data integrity and allows us to add validation without changing the external interface. In our example, we use `_firstName`, `_salary` as private fields and expose them through public properties.

## What is Inheritance?

Inheritance is a mechanism where a new class (derived/child) inherits properties and methods from an existing class (base/parent). It promotes code reuse and establishes a hierarchical relationship between classes. The child class can extend the parent class functionality by adding new properties or methods. In our code, `Employee` inherits from `Person`, and `Manager` inherits from `Employee`, creating a hierarchy that models real-world relationships.

## What is Polymorphism?

Polymorphism means "many forms" and allows objects of different types to be used interchangeably through a common interface. It enables a single method call to behave differently based on the object type. In our example, calling `employee.DisplayEmployeeInfo()` produces different outputs for `Employee` and `Manager` objects because each class overrides the method with its own implementation. This is achieved through method overriding.

## What is Abstraction?

Abstraction is the concept of hiding complex implementation details and showing only the essential features of an object. We use abstract classes and interfaces to define a contract that derived classes must follow. In our code, `Person` is an abstract class with an abstract method `DisplayInfo()` that forces all derived classes to provide their own implementation, without exposing how it's implemented.

## Why are they important in enterprise software?

**Encapsulation** provides data security and prevents unauthorized access to sensitive fields, ensuring that data can only be modified in controlled ways. **Inheritance** reduces code duplication and makes maintenance easier by centralizing common functionality in base classes. **Polymorphism** allows flexible and extensible code that can work with objects of different types without modification, making it easier to add new features. **Abstraction** simplifies complex systems by hiding unnecessary details and defining clear contracts, making the codebase more maintainable and scalable.

---

## Development Standards Applied

### Naming Conventions
- Used PascalCase for class names: `Person`, `Employee`, `Manager`
- Used PascalCase for method names: `GetFullName()`, `DisplayEmployeeInfo()`
- Used PascalCase for public properties: `FirstName`, `Department`, `Salary`
- Used camelCase with underscore prefix for private fields: `_firstName`, `_salary`

### Access Modifiers
- Private fields (`_id`, `_firstName`, etc.) to protect data
- Public properties with get/set accessors to control access
- Protected constructors in `Person` to prevent direct instantiation
- Virtual methods in `Employee` to allow override in `Manager`
- Abstract method in `Person` to enforce implementation in derived classes

### Code Quality
- Small, focused methods like `GetFullName()` that do one thing well
- Meaningful names that clearly express purpose: `DisplayEmployeeInfo()` vs `Display()`
- No duplicated code - common functionality in base classes
- Proper documentation through XML comments
- Clear separation of concerns across classes
