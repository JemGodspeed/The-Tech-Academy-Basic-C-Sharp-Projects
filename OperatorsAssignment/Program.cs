using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create the employees objects and initialize its properties
            Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };

            Employee employee2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" };

            // Compare the two Employee objects using the overloaded '==' operator
            bool areEqual = employee1 == employee2;

            Console.WriteLine("Are employee1 and employee2 equal? " + areEqual);

            employee2.Id = 1;
            areEqual = employee1 == employee2;

            // Output the updated comparison result
            Console.WriteLine("Are employee1 and employee2 equal after updating Id? " + areEqual);
        }

    }
}
