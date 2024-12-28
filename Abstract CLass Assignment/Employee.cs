using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Abstract_CLass_Assignment
{
    // Employee class inherits from Person and implements IQuittable interface
    public class Employee : Person, IQuittable
    {
  
        public int Id { get; set; }

        // Override the SayName method from Person class to display employee's full name
        public override void SayName()
        {
            Console.WriteLine($"Name: {firstName} {lastName}");
        }

        // Implement the Quit method from IQuittable interface
        public void Quit()
        {
  
            Console.WriteLine($"{firstName} {lastName} has quit the job.");
        }
    }
}

