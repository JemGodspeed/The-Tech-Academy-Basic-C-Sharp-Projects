using System;

namespace Abstract_CLass_Assignment
{
    class Program2
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object and set first and last names
            Employee Sam = new Employee() { firstName = "Sample", lastName = "Student" };

            // Use polymorphism to create an object of type IQuittable and call Quit() on it
            IQuittable quittableEmployee = Sam;

            // Call the Quit method through the IQuittable reference
            quittableEmployee.Quit();
            Console.ReadLine();
        }
    }
}
