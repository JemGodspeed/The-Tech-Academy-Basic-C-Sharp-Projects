using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
                                 {

public class MathOperations
{
    // Define a void method that takes two integers as parameters
    public void PerformOperation(int num1, int num2)
    {
       
        int result = num1 * 2;
        Console.WriteLine($"Result after performing the operation on the first number: {result}");

        Console.WriteLine($"Second number: {num2}");
    }
}

// Define the main class of the application
class Program
{
    // Entry point of the application
    static void Main(string[] args)
    {
        // Instantiate the MathOperations class
        MathOperations mathOps = new MathOperations();

        // Call the method, passing two integers
        mathOps.PerformOperation(5, 10);

        // Call the method again, this time specifying the parameters by name
        mathOps.PerformOperation(num1: 8, num2: 15);

        // Keep the console window open until a key is pressed
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
}