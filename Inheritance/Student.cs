using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Student : Person
    {
        static Student()
        {
            Console.WriteLine("Student Class Static Constructor");
        }

        public Student()
        {
            Console.WriteLine("Student Class Construtor");
        }
        internal uint id;
        internal string? collegeName;
        internal string? branch;
        internal byte year;

        internal void GoingToCollege()
        {
            Console.WriteLine("I am on my way to college");
        }

        internal void ComingBackHome()
        {
            Console.WriteLine("I am returning back home from college");
        }
    }
}
