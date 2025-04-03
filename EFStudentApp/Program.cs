using System;
using System.Linq;

namespace EFStudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                // Додаємо одного студента
                var student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john.doe@example.com"
                };

                context.Students.Add(student);
                context.SaveChanges();

                // Виводимо всіх студентів із бази даних
                var students = context.Students.ToList();
                foreach (var s in students)
                {
                    Console.WriteLine($"{s.Id}: {s.FirstName} {s.LastName} - {s.Email}");
                }
            }

            Console.WriteLine("Done. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
