using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_CLass_Assignment
{
   
        public class Employee : Person
        {
            public int Id { get; set; }

            public override void SayName()
            {
                Console.WriteLine($"Name: {firstName} {lastName}");
            }
        }
    }

