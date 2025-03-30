// Basic class with first and last name properties
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void SayName()
    {
        Console.WriteLine("Name: " + FirstName + " " + LastName);
    }
}