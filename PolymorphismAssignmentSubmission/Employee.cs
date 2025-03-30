// Employee inherits from Person and implements IQuittable interface
public class Employee : Person, IQuittable
{
    public int Id { get; set; }

    public void Quit()
    {
        Console.WriteLine($"{FirstName} {LastName} has quit the job.");
    }
}