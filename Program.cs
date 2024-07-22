using System;
using System;

namespace StudentDatabaseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                // Ensure database is created
                context.Database.CreateIfNotExists();

                // Create a new student
                var student = new Student
                {
                    FirstName = "Tuka",
                    LastName = "Araibi"
                };

                // Add the student to the database
                context.Students.Add(student);
                context.SaveChanges();

                // Display the student details
                Console.WriteLine($"Student ID: {student.StudentId}, Name: {student.FirstName} {student.LastName}");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}