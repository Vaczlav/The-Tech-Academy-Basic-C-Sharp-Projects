// Employee.cs

using System;

// Create Employee class
public class Employee
{
    public int Id { get; set; }              // Unique identifier
    public string FirstName { get; set; }    // First name of employee
    public string LastName { get; set; }     // Last name of employee

    // Overload == operator to compare two Employees by Id
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // Check for null
        if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null)) return true;
        if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null)) return false;

        return emp1.Id == emp2.Id;
    }

    // Overload != operator (must be paired with ==)
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2);
    }

    // Override Equals for good practice
    public override bool Equals(object obj)
    {
        if (obj is Employee other)
        {
            return this.Id == other.Id;
        }
        return false;
    }

    // Override GetHashCode as Equals is overridden
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}