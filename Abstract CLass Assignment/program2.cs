using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Abstract_CLass_Assignment
{
    class Program2
    {
        static void Main(string[] args)
        {
            Employee Sam = new Employee() { firstName = "sample", lastName = "student" };
            Sam.SayName();
            Console.ReadLine();
        }
    }
}
