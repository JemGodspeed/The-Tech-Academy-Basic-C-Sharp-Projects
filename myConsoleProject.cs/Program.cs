using System;

namespace myConsoleProject.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("hello "+name+"!");
            Console.Read();
            Console.WriteLine("Welcome to Acme Accounting Systems");
            Console.WriteLine("Remember, we’re “accounting” on you!");

        }
    }

}
