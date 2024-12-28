using System;

namespace Abstract_CLass_Assignment
{
    public abstract class Person // Abstract class that defines common properties and an abstract method for derived classes
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public abstract void SayName();
    }

}


